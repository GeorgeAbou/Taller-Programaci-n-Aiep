using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace museo
{
    internal class Galeria
    {
        private int idGaleria;
        private string nombreGaleria;
        private List<Exposicion> listaExposiciones;

        public int IdGaleria
        {
            get { return idGaleria; }
            set { idGaleria = value; }
        }
        public string NombreGaleria
        {
            get { return nombreGaleria; }
            set { nombreGaleria = value; }

        }
        public List<Exposicion> ListaExposiciones
        {
            get { return listaExposiciones; }
            set { listaExposiciones = value; }
        }
        //Constructor
        public Galeria(int idGaleria, string nombreGaleria, List<Exposicion> listaExposiciones)
        {
            IdGaleria = idGaleria;
            NombreGaleria = nombreGaleria;
            List<Exposicion> ListaExposiciones = listaExposiciones;

        }
    }
}