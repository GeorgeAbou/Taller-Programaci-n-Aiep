using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace museo
{
    internal class Autor
    {
        int id;
        String nombre;
        String Apellido;
        int edad;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
    }
}
    
