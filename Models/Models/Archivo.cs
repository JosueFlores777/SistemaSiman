using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    internal class Archivo : Usuarios
    {
        private int IdArchivo;
        private int IdUser;
        private String ArchivoName;
        private String FechaRegisArchi;
        private String FechaElimiArchi;
        private String PathFisicoArchiw;
        private String ContentTypeArchi;
        private String IdentefiArchi;

        public int IdArchivo1 { 
            get => IdArchivo; set => IdArchivo = value; }
        public int IdUser1 { 
            get => IdUser; set => IdUser = base.IdUsuarios1; }
        public string ArchivoName1 { 
            get => ArchivoName; set => ArchivoName = value; }
        public string FechaRegisArchi1 { 
            get => FechaRegisArchi; set => FechaRegisArchi = value; }
        public string FechaElimiArchi1 { 
            get => FechaElimiArchi; set => FechaElimiArchi = value; }
        public string PathFisicoArchiw1 { 
            get => PathFisicoArchiw; set => PathFisicoArchiw = value; }
        public string ContentTypeArchi1 { 
            get => ContentTypeArchi; set => ContentTypeArchi = value; }
        public string IdentefiArchi1 { 
            get => IdentefiArchi; set => IdentefiArchi = value; }
    }
}
