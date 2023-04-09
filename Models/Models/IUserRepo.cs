using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    internal interface IUserRepo
    {
        void AddUser(Usuarios IUsersRepos);
        void EditUser(Usuarios IUsersRepos);
        void DeleteUser(int IdUsers);
        IEnumerable <Usuarios> GetAllUsers();
        IEnumerable <Usuarios> GetByUsersValue(int IdUser);
    }
}
