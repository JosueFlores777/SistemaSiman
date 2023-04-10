using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    internal class Permisos
    {
        private int IdPermisos;
        private String CodigoPermi;
        private String NombrePermi;
        private String UrlPer;
        private int PermisPadre;
        private int MenuPermiso;
        private String IconoPermi;
        private int OrdenPermi;
        private int AsignPerm;
        private int TieneHijosPermiso;

        public int IdPermisos1 { 
            get => IdPermisos; set => IdPermisos = value; }
        public string CodigoPermi1 { 
            get => CodigoPermi; set => CodigoPermi = value; }
        public string NombrePermi1 { 
            get => NombrePermi; set => NombrePermi = value; }
        public string UrlPer1 { 
            get => UrlPer; set => UrlPer = value; }
        public int PermisPadre1 { 
            get => PermisPadre; set => PermisPadre = value; }
        public int MenuPermiso1 { 
            get => MenuPermiso; set => MenuPermiso = value; }
        public string IconoPermi1 { 
            get => IconoPermi; set => IconoPermi = value; }
        public int OrdenPermi1 { 
            get => OrdenPermi; set => OrdenPermi = value; }
        public int AsignPerm1 { 
            get => AsignPerm; set => AsignPerm = value; }
        public int TieneHijosPermiso1 {
            get => TieneHijosPermiso; set => TieneHijosPermiso = value; }
    }
}
