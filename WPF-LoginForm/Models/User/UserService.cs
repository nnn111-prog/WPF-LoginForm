using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LoginForm.Models.User
{
    internal class UserService
    {
        private static List<UserModel> userModelsList;
        public UserService()
        {
            userModelsList = new List<UserModel>();
        }
        public List<UserModel> GetAllUsers()
        {
            return userModelsList;
        }
        public bool Add(UserModel newModel)
        {
            userModelsList.Add(newModel);
            return true;
        }
        public bool Update(UserModel updateModel)
        {
            bool IsUpdated = false;
            for (int index = 0; index < userModelsList.Count; index++)
            {
                if (userModelsList[index].Id_developers == updateModel.Id_developers)
                {
                    userModelsList[index].Username = updateModel.Username;
                    userModelsList[index].Password = updateModel.Password;
                    IsUpdated = true;
                    break;
                }
            }
            return IsUpdated;
        }
        public bool Delete(int id_developers)
        {
            bool IsDeleted = false;
            for (int index = 0; index < userModelsList.Count; index++)
            {
                if (userModelsList[index].Id_developers == id_developers)
                {
                    userModelsList.RemoveAt(index);

                    IsDeleted = true;
                    break;
                }
            }
            return IsDeleted;
        }

        public UserModel Search(int id_developers)
        {
            return userModelsList.FirstOrDefault(e => e.Id_developers == id_developers);
        }
    }
}
