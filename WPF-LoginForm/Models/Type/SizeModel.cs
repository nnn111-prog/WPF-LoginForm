using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LoginForm.Models.Type
{
    public class SizeModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private int id_size;
        public int Id_size
        {
            get { return id_size; }
            set { id_size = value; }
        }
        private int weight_oper;
        public int Weight_oper
        {
            get { return weight_oper; }
            set { weight_oper = value; }
        }
        private int weight_erec;
        public int Weight_erec
        {
            get { return weight_erec; }
            set { weight_erec = value; }
        }
        private int diameter;
        public int Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }
        private int length;
        public int Length
        {
            get { return diameter; }
            set { diameter = value; }
        }
    }
}
