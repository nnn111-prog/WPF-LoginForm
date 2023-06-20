using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LoginForm.Models
{
    public interface ITypeRepository
    {
        void Add(TypeModel typeModel);
        void Edit(TypeModel typeModel);
        void Remove(int id_type);
        TypeModel GetById(int id_type);
        TypeModel GetByUsername(string name_type);
    }
}
