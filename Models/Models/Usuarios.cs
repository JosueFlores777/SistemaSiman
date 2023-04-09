using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    internal class Usuarios
    {
		private int IdUsuarios;
        private int IdDeperamento;
        private String NombreUsuario;
		private String IdentiFiAcceUsu;
		private String ActivoUser;
		private String ContraseUser;
		private int CambiarContrasUser;
		private String FechaRegistroUser;
		private String FechaActualiUser;
		private String FechaEstableContraUser;
		private String TipoUsuer;
		private String CodigoTempoUser;

        public int IdUsuarios1 { 
            get => IdUsuarios; set => IdUsuarios = value; }
        public int IdDeperamento1 { 
            get => IdDeperamento; set => IdDeperamento = value; }
        public string NombreUsuario1 {
            get => NombreUsuario; set => NombreUsuario = value; }
        public string IdentiFiAcceUsu1 { 
            get => IdentiFiAcceUsu; set => IdentiFiAcceUsu = value; }
        public string ActivoUser1 { 
            get => ActivoUser; set => ActivoUser = value; }
        public string ContraseUser1 { 
            get => ContraseUser; set => ContraseUser = value; }
        public int CambiarContrasUser1 { 
            get => CambiarContrasUser; set => CambiarContrasUser = value; }
        public string FechaRegistroUser1 { 
            get => FechaRegistroUser; set => FechaRegistroUser = value; }
        public string FechaActualiUser1 { 
            get => FechaActualiUser; set => FechaActualiUser = value; }
        public string FechaEstableContraUser1 { 
            get => FechaEstableContraUser; set => FechaEstableContraUser = value; }
        public string TipoUsuer1 { 
            get => TipoUsuer; set => TipoUsuer = value; }
        public string CodigoTempoUsu1 { 
            get => CodigoTempoUser; set => CodigoTempoUser = value; }
    }
}
