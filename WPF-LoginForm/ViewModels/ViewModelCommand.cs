using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_LoginForm.ViewModel
{
    public class ViewModelCommand : ICommand
    {
        //Fields
        private readonly Action<object> _executeAction;
        //private readonly Predicate<object> _canExecuteAction;
        private readonly Func<object, bool> _canExecute;

        //Events
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        //Constructors
        public ViewModelCommand(Action<object> executeAction)
        {
            _executeAction = executeAction;
            _canExecute = null;
        }

        public ViewModelCommand(Action<object> executeAction, Func<object, bool> canExecute)
        {
            _executeAction = executeAction;
            _canExecute = canExecute;
        }        

        //Methods
        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _executeAction(parameter);
        }
    }
}
