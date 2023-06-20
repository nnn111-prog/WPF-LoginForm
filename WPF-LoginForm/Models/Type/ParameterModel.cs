using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LoginForm.Models.Type
{
    public class ParameterModel
    {
        public int Id_parameter { get; set; }
        public string Oper_temp { get; set; }
        public string Oper_press { get; set; }
        public string Des_temp { get; set;}
        public string Des_press { get;set; }
        public string Environment { get; set; }
    }
}
