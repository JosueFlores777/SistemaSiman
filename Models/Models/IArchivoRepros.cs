using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    internal interface IArchivoRepros
    {
        void AddArchivoRepros(Archivo IArchivoRepros);
        void EditArchivoRepros(Archivo IArchivoRepros);
        void DeleteArchivoRepros(int IdArchivoRepros);
        IEnumerable<Archivo> GetAllArchivoRepros();
        IEnumerable<Archivo> GetByArchivoReprosValue(int IdArchivoRepros);
    }
}
