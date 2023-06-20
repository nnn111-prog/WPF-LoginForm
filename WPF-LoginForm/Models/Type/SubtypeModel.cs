using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LoginForm.Models.Type
{
    public class SubtypeModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private int id_subtype;
        public int Id_subtype
        {
            get { return id_subtype; }
            set { id_subtype = value; }
        }
        private string name_subtype;
        public string Name_subtype
        {
            get { return name_subtype; }
            set { name_subtype = value; }
        }
    }
}
