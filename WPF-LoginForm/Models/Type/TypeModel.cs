using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_LoginForm.Models.Type;

namespace WPF_LoginForm.Models
{
    public class TypeModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private int id_type;
        public int Id_type {
            get { return id_type; }
            set { id_type = value; } 
        }
        private string name_type;
        public string Name_type { 
            get { return name_type; }
            set { name_type = value; }
        }
        public int SubtypeId { get; set; }
        public List <SubtypeModel> Subtypes { get; set; }
       
    }
}
