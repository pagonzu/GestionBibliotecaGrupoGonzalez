using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public abstract class Trabajador
    {
        private int idTrabajador;
        private String nombre;
        private String password;

        public Trabajador(String nombre, String password)
        {
            idTrabajador = 0;
            this.nombre = nombre;
            this.password = password;
        }

        public Trabajador(int idTrabajador, String nombre, String password)
        {
            this.idTrabajador = idTrabajador;
            this.nombre = nombre;
            this.password = password;
        }

        public int IdTrabajador
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
