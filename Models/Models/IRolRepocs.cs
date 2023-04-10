using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    internal interface IRolRepocs
    {
        void AddRol(Rol IRolRepo);
        void EditRol(Rol IRolRepo);
        void DeleteRol(int IdRol);

        IEnumerable<Rol> GetAllRol();
        IEnumerable<Rol> GetByRolValue(int IdRol);
    }
}
