using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    internal class Rol
    {
        private int IdRol;
        private String NombreRol;
        private String DescripcionRol;
        private String FechaCreacRol;
        private String FechaActuaRol;
        private int AsignableRol;

        public int IdRol1 { 
            get => IdRol; set => IdRol = value; }
        public string NombreRol1 { 
            get => NombreRol; set => NombreRol = value; }
        public string DescripcionRol1 { 
            get => DescripcionRol; set => DescripcionRol = value; }
        public string FechaCreacRol1 { 
            get => FechaCreacRol; set => FechaCreacRol = value; }
        public string FechaActuaRol1 { 
            get => FechaActuaRol; set => FechaActuaRol = value; }
        public int AsignableRol1 { 
            get => AsignableRol; set => AsignableRol = value; }
    }
}
