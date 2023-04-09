using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    internal class Clientes
    {
        private int IdCliente;
        private int IdAchivo;//referencia
        private string NameCliente;
        private string ApellidoCliente;
        private string CorreoElectronico;
        private string DirrecionCliente;
        private string TelefonoCliente;

        public int IdCliente1 { 
            get => IdCliente; set => IdCliente = value; }
        public int IdAchivo1 { 
            get => IdAchivo; set => IdAchivo = value; }
        public string NameCliente1 { 
            get => NameCliente; set => NameCliente = value; }
        public string ApellidoCliente1 { 
            get => ApellidoCliente; set => ApellidoCliente = value; }
        public string CorreoElectronico1 { 
            get => CorreoElectronico; set => CorreoElectronico = value; }
        public string DirrecionCliente1 { 
            get => DirrecionCliente; set => DirrecionCliente = value; }
        public string TelefonoCliente1 { 
            get => TelefonoCliente; set => TelefonoCliente = value; }
    }
}
