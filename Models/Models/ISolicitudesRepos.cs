using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    internal interface ISolicitudesRepos
    {
        void AddSolicitudes(Solicitudes ISolicitudes);
        void EditSolicitudes(Solicitudes ISolicitudes);
        void DeleteSolicitudes(int Id);
        IEnumerable<Solicitudes> GetAllSolicutdes();
        IEnumerable<Solicitudes> GetBySolitValue(int Id);
    }
}
