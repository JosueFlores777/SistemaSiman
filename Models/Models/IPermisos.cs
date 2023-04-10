using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    internal interface IPermisos
    {
        void AddPermisosRepros(Permisos IPermisosRepros);
        void EditPermisosRepros(Permisos IPermisosRepros);
        void DeletePermisosRepros(int IdPermisos);
        IEnumerable<Permisos> GetAllArchivoRepros();
        IEnumerable<Permisos> GetByArchivoReprosValue(int IdPermisosRepros);
    }
}
