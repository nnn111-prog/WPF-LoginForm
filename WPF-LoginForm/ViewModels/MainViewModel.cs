using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_LoginForm.Models;
using WPF_LoginForm.Repositories;
using WPF_LoginForm.ViewModel;

namespace WPF_LoginForm.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        //Fields
        private UserAccountModel _currentUserAccount;
        private ViewModelBase _currentChildView;
        private string _caption;
        private IconChar _icon;

        private IUserRepository userRepository;

        public UserAccountModel CurrentUserAccount
        {
            get
            {
                return _currentUserAccount;
            }

            set
            {
                _currentUserAccount = value;
                OnPropertyChanged(nameof(CurrentUserAccount));
            }
        }
        public ViewModelBase CurrentChildView
        {
            get
            {
                return _currentChildView;
            }
            set
            {
                _currentChildView = value;
                OnPropertyChanged(nameof(CurrentChildView));
            }
        }
        public string Caption
        {
            get
            {
                return _caption;
            }
            set
            {
                _caption = value;
                OnPropertyChanged(nameof(Caption));
            }
        }
        public IconChar Icon
        {
            get
            {
                return _icon;
            }
            set
            {
                _icon = value;
                OnPropertyChanged(nameof(Icon));
            }
        }
        //--> Commands
        public ICommand ShowHomeViewCommand { get; }
        public ICommand ShowAccountViewCommand { get; }
        public ICommand ShowOil_equipmentViewCommand { get; }

        public MainViewModel()
        {
            userRepository = new UserRepository();
            CurrentUserAccount = new UserAccountModel();

            //Initialize commands
            ShowHomeViewCommand = new ViewModelCommand(ExecuteShowHomeViewCommand);
            ShowAccountViewCommand = new ViewModelCommand(ExecuteShowAccountViewCommand);
            ShowOil_equipmentViewCommand = new ViewModelCommand(ExecuteShowOil_equipmentViewCommand);
            //Default view
            ExecuteShowAccountViewCommand(null);

            LoadCurrentUserData();
        }
        private void ExecuteShowAccountViewCommand(object obj)
        {
            CurrentChildView = new AccountViewModel();
            Caption = "Accounts";
            Icon = IconChar.UserGroup;
        }

        private void ExecuteShowOil_equipmentViewCommand(object obj)
        {
            CurrentChildView = new Oil_equipmentViewModel();
            Caption = "Oil_equipment";
            Icon = IconChar.UserGroup;
        }
        private void ExecuteShowHomeViewCommand(object obj)
        {
            CurrentChildView = new HomeViewModel();
            Caption = "Dashboard";
            Icon = IconChar.Home;
        }

        private void LoadCurrentUserData()
        {
            var user = userRepository.GetByUsername(Thread.CurrentPrincipal.Identity.Name);
            if (user != null)
            {
                CurrentUserAccount.Username = user.Username;
                CurrentUserAccount.DisplayName = $"{user.Username}";
            }
            else
            {
                CurrentUserAccount.DisplayName = "Invalid user, not logged in";
                //Hide child views.
            }
        }
    }
}
