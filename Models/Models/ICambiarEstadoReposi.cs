using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    internal interface ICambiarEstadoReposi
    {
        void AddCambioEstado(CambiarEstado ICambiarEstado);
        void EditCambioEstado(CambiarEstado ICambiarEstado);
        void DeleteCambioEstado(int CambiarEstadoId);
        IEnumerable<CambiarEstado> GetAllCambiosEstados();
        IEnumerable<CambiarEstado> GetByCambioEstados(int CambiarEstadoId);
    }
}
