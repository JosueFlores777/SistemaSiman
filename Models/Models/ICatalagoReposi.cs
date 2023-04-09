using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    internal interface ICatalagoReposi
    {
        void AddCatalago(Catalago ICatalago);
        void EditCatalago(Catalago ICatalago);
        void DeleteCatalago(int idCatalgo);
        IEnumerable<Catalago> GetAllCatalago();
        IEnumerable<Catalago> GetByCatalagoValue(int Idcataloo);
    }
}
