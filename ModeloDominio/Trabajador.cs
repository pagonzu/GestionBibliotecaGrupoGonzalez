using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public abstract class Trabajador
    {
        private String idTrabajador;
        private String nombre;
        private String password;

        public Trabajador(String nombre, String password)
        {
            idTrabajador = "";
            this.nombre = nombre;
            this.password = password;
        }

        public Trabajador(String idTrabajador, String nombre, String password)
        {
            this.idTrabajador = idTrabajador;
            this.nombre = nombre;
            this.password = password;
        }

        public String IdTrabajador
        { get { return idTrabajador; } }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Password
        { 
            get { return password; }
            set { password = value; }
        }
    }
}
