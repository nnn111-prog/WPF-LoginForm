using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LoginForm.Models
{
    public class UserModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private int id_developers;
        public int Id_developers
        {
            get { return id_developers; }
            set { id_developers = value; OnPropertyChanged("Id_developers"); }
        }
        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; OnPropertyChanged("Username"); }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged("Password"); }
        }
    }

}
