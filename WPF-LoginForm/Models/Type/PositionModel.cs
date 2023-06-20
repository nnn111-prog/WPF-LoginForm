using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LoginForm.Models.Type
{
    public class PositionModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private int id_position;
        public int Id_position
        {
            get { return id_position; }
            set { id_position = value; }
        }
        private string name_position;
        public string Name_position
        {
            get { return name_position; }
            set { name_position = value; }
        }
    }
}
