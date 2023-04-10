using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    internal class RolPermiso : Rol 
    {
        private int IdRolPermiso;
        private int IdRol;
        private int IdPermiso;

        public int IdRolPermiso1 { 
            get => IdRolPermiso; set => IdRolPermiso = value; }
        public int IdRol2 { 
            get => IdRol; set => IdRol = base.IdRol1; }
        public int IdPermiso1 { 
            get => IdPermiso; set => IdPermiso = value; }
    }
}
