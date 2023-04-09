using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    internal interface IProductsSolitRepos
    {
        void AddProSoli(ProductsSolicitudes IProductsSolicitudes);
        void EditProSoli(ProductsSolicitudes IProductsSolicitudes);
        void DeleteProSoli(int Id);
        IEnumerable<ProductsSolicitudes> GetAllProduSolic();
        IEnumerable<ProductsSolicitudes> GetByProducSolicValue(int IdProdSoli);
    }
}
