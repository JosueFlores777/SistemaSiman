using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// interfaz abtracta
//para dependecia independite 
namespace Models.Models
{
    internal interface IProdcutsRepository
    {
        void AddProdu(Products IProductRepo);
        void EditProduc(Products IProductRepo);
        void DeleteProduc(int IdPrdocut);
        IEnumerable<Products> GetAllProduct();
        IEnumerable<Products> GetByProductValue(int IdProducts);//searchs
    
    }
}
