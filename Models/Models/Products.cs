using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//metadata attribute validations
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace InvetariosSiman.Models
{
    public class Products
    {
        private String NameProduct;
        private int IdProduct;
        private String DescriptionProduct;
        private double PriceProduct;
        private String SizeProduct;
        private String ColorProduct;
        private String StockProduct;

        //Properties

        public int IdProduct1
        {
            get => IdProduct; set => IdProduct = value;
        }

        [DisplayName("Product NameProduct1")]
        [Required(ErrorMessage = "Product You need to add a name")]
        public string NameProduct1 {
            get => NameProduct; set => NameProduct = value; }

        [DisplayName("Product DescriptionProduct1")]
        [Required(ErrorMessage = "Product You need to add a name")]
        [StringLength(250,MinimumLength =15, ErrorMessage =("Product type must be between 15 a 250 characters"))]
        public string DescriptionProduct1 { 
            get => DescriptionProduct; set => DescriptionProduct = value; }


        [DisplayName("Product PriceProduct1")]
        [Range(0, 99999.99)]
        [Required(ErrorMessage = "Product You need to add a price")]
        public double PriceProduct1 { 
            get => PriceProduct; set => PriceProduct = value; }


        [DisplayName("Product SizeProduct1")]
        [Required(ErrorMessage = "Product You need to add a size")]
        [StringLength(15, MinimumLength = 1, ErrorMessage = ("Product type must be between 1 a 15 characters"))]
        public string SizeProduct1 { 
            get => SizeProduct; set => SizeProduct = value; }


        [DisplayName("Product ColorProduct1")]
        [Required(ErrorMessage = "Product You need to add a color")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = ("Product type must be between 1 a 25 characters"))]
        public string ColorProduct1 { 
            get => ColorProduct; set => ColorProduct = value; }

        [DisplayName("Product StockProduct1")]
        [Range(0, 99999.99)]
        [Required(ErrorMessage = "Product You need to add a price")]
        public string StockProduct1 { 
            get => StockProduct; set => StockProduct = value; }
    }

}
