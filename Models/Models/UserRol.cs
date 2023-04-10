using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    internal class UserRol : Rol
    {
        private int idUserRol;
        private int idRol;
        private int idUsuario;
        
        public int IdUserRol { 
            get => idUserRol; set => idUserRol = value; }
        public int IdRol { 
            get => idRol; set => idRol = base.IdRol1; }
        public int IdUsuario { 
            get => idUsuario; set => idUsuario = value; }
    }
}
