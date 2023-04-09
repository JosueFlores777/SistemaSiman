using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// interfaz abtracta
//para dependecia independite 
namespace InvetariosSiman.Models
{
    internal interface IProdcutsRepository
    {
        void add(Products productRepo);
        void Edit(Products productRepo);
        void Delete(int id);
        IEnumerable<Products> GetAll();
        IEnumerable<Products> GetByBalue(int id);//searchs
    }
}
