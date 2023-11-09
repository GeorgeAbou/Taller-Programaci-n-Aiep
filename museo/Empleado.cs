using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace museo
{
    public abstract class Empleado
    {
        private int id;
        private String usuario;
        private String nombre;
        private String apellido;
        private String password;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public String Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public bool Iniciar_Sesion(string usuario, String contraseña)
        {
            if (usuario == Usuario && contraseña == password)
            {
                Console.WriteLine("Iiciando session por " + Nombre + "" + Apellido);
                return true;
            }
            else
            {
                Console.WriteLine(" Usuario o Contraseña invalida");
                return false;
            }
        }

    }
}
