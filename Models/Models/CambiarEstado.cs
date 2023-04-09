using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    internal class CambiarEstado : Solicitudes
    {

        private int IdCambiarEstad;
        private int IdSolicitudes;
        private int IdSuarios;//referencia
        private int IdEstado;//referencia
        private String FechaCambi;
        private String Mensaje;

        public int IdCambiarEstad1 { 
            get => IdCambiarEstad; set => IdCambiarEstad = value; }
        public int IdSolicitudes1 { 
            get => IdSolicitudes; set => IdSolicitudes = base.IdApplicationSoli1; }
        public int IdSuarios1 { 
            get => IdSuarios; set => IdSuarios = value; }
        public int IdEstado1 { 
            get => IdEstado; set => IdEstado = value; }
        public string FechaCambi1 { 
            get => FechaCambi; set => FechaCambi = value; }
        public string Mensaje1 { 
            get => Mensaje; set => Mensaje = value; }
    }
}
