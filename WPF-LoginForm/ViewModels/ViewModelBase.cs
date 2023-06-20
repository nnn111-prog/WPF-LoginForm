using Org.BouncyCastle.Security.Certificates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_LoginForm.ViewModels;

namespace WPF_LoginForm.ViewModel
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //public static implicit operator ViewModelBase(AccountViewModel v) => throw new NotImplementedException();
    }  
}
