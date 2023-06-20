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
    public class DescriptionModel
    {
        public string Datasheet_id { get; set; }
        public string PID_id { get; set; }
        public string Item_name { get; set; }
        public int Count { get; set; }
        public string Specification { get; set; }
        public string Material { get; set; }
        public string Power { get; set; }
        public string Remark { get; set; }   
        public int Model_equipment_id { get; set; }
        public virtual ModelEquipmentModel ModelEquipmentModel { get; set; }
        public int Subtype_equipment_id { get; set; }
        public virtual SubtypeModel SubtypeModel { get; set; }
        public int Spatial_position_id { get; set; }
        public virtual PositionModel PositionModel { get; set; }
        public int Open_design_id { get; set; }
        public virtual  ParameterModel ParameterModel { get; set; }
    }
}
