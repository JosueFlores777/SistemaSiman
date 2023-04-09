using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    internal class Solicitudes
    {
        private int IdApplicationSoli;
        private int idClientAplicat;
        private int IdUserManageAplita;
        private String SaleDateAplica;
        private double FullSaleAplica;

        //Properties
        public int IdApplicationSoli1
        {
            get => IdApplicationSoli; set => IdApplicationSoli = value;
        }
        public int IdClientAplicat
        {
            get => idClientAplicat; set => idClientAplicat = value;
        }
        public int IdUserManageAplita1
        {
            get => IdUserManageAplita; set => IdUserManageAplita = value;
        }

        [DataType(DataType.Date)]
        public string SaleDateAplica1
        {
            get => SaleDateAplica; set => SaleDateAplica = value;
        }
        public double FullSaleAplica1
        {
            get => FullSaleAplica; set => FullSaleAplica = value;
        }
    }
}
