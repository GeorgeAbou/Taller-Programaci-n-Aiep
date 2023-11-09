using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace museo
{
    internal class ObraArte
    {
        private int idObra;
        private String nombreObra;
        private String autor;
        private String fecha;
        private String descripcion;

        public int IdObra
        {
            get { return idObra; }
            set { idObra = value; }
        }
        public string NombreObra
        {
            get { return nombreObra; }
            set { nombreObra = value; }
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public String Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public ObraArte( int idObra, String nombreObra,String autor, String fecha,String descripcion)
        {
            IdObra = idObra;
            NombreObra= nombreObra;
            Autor = autor;
            Fecha = fecha;
            Descripcion = descripcion;
        }

        
            
    }
}
