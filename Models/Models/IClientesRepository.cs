using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    internal interface IClientesRepository
    {
        void AddClient(Clientes IClientesRepo);
        void EditCliente(Clientes IClientesRepo);
        void DeleteCliente(int Id);

        IEnumerable<Clientes> GetAllClients();
        IEnumerable<Clientes> GetByClientValue(int Id);

    }
}
