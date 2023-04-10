using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    internal interface IRolPermiso
    {
        void AddRolPermiso(RolPermiso IRolPermiso);
        void EditRolPermiso(RolPermiso IRolPermiso);
        void DeleteRolPermiso(int IdRolPermiso);
        IEnumerable<RolPermiso> GetAllRolPermiso();
        IEnumerable<RolPermiso> GetByRolPermisoValue(int IdRolPermiso);
    }
}
