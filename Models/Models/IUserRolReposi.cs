using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    internal interface IUserRolReposi
    {
        void AddUserRol(UserRol IUserRolRepo);
        void EditUserRol(UserRol IUserRolRepo);
        void DeleteUserRol(int IdUserRol);

        IEnumerable<UserRol> GetAllUserRol();
        IEnumerable<UserRol> GetByUserRolValue(int IdUserRol);
    }
}
