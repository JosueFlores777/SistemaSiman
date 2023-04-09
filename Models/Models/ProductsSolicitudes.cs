
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    internal class ProductsSolicitudes : Products
    {
        private int IdProductProApli;
        private int IdVentaProductProApli;
        private int IdProduct;
        private int StockProduc;
        private String Indications;
        private String Observations;

        //Properties
        public int IdProductProApli1
        {//references
            get => IdProductProApli; set => IdProductProApli = base.IdProduct1;
        }
        public int IdVentaProductProApli1
        {
            get => IdVentaProductProApli; set => IdVentaProductProApli = value;
        }
        public int IdProduct1
        {
            get => IdProduct; set => IdProduct = value;
        }
        public int StockProduc1
        {
            get => StockProduc; set => StockProduc = value;
        }
        public string Indications1
        {
            get => Indications; set => Indications = value;
        }
        public string Observations1
        {
            get => Observations; set => Observations = value;
        }
    }
}
