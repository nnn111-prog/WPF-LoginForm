using System.Threading.Tasks;
using WPF_LoginForm.ViewModel;
using System.Collections.ObjectModel;

namespace WPF_LoginForm.ViewModels
{
    public class AccountViewModel : ViewModelBase
    {
        public AccountViewModel()
        {

            // Пользователь
            UpdateUsersListCommand = new RelayCommand(obj => UpdateUsersTable());
            ClearUserPropertiesCommand = new RelayCommand(obj => ClearUserProperties());
            AddUserCommand = new AsyncCommand(AddUserAsync, () => true);
            DeleteUserCommand = new AsyncCommand(DeleteUserAsync, () => true);
            EditUserCommand = new AsyncCommand(EditUserAsync, () => true);
        }

        #region Команды_Пользователей
        public RelayCommand UpdateUsersListCommand { get; set; }
        public RelayCommand ClearUserPropertiesCommand { get; set; }
        public AsyncCommand AddUserCommand { get; set; }
        public AsyncCommand DeleteUserCommand { get; set; }
        public AsyncCommand EditUserCommand { get; set; }
        #endregion

        #region Методы_пользователей
        private void UpdateUsersTable()
        {
            UsersTable = new ObservableCollection<UserView>(_userService.GetAllUsers());
            Roles = new ObservableCollection<string>(_userService.GetRolesCollection());
        }
        private void ClearUserProperties()
        {
            SelectedRole = null;
            Login = null;
            Password = null;
            SelectedUserRow = null;
        }
        public async Task AddUserAsync()
        {
            if (string.IsNullOrEmpty(Login) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(SelectedRole))
            {
                return;
            }

            if (_userService.UserIsYetRegister(Login))
            {
                MessageBox.Show("Такой пользователь уже существует!");
                return;
            }
            await _userService.AddUserAsync(new UserView()
            {
                Login = this.Login,
                Password = this.Password,
                Role = this.SelectedRole
            });
            UpdateUsersTable();
        }
        public async Task DeleteUserAsync()
        {
            if (SelectedUserRow == null || SelectedUserRow.Id == null)
            {
                return;
            }

            int id = SelectedUserRow.Id ?? -1;
            if (id == -1)
                return;
            await _userService.RemoveRangeAsync(new[] { id });
            UpdateUsersTable();
        }
        public async Task EditUserAsync()
        {
            if (SelectedUserRow == null
                || SelectedUserRow.Id == null
                || string.IsNullOrEmpty(Login)
                || string.IsNullOrEmpty(Password)
                || SelectedRole == null)
            {
                return;
            }

            await _userService.UpdateUserAsync(new UserView()
            {
                Id = SelectedUserRow.Id,
                Login = this.Login,
                Password = this.Password,
                Role = this.SelectedRole
            });

            UpdateUsersTable();
        }


        #endregion
    }

}
