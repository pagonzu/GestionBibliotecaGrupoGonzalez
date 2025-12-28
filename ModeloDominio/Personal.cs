using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public abstract class Personal
    {
        private String idPersonal;
        private String nombre;
        private String password;

        public Personal(String nombre, String password)
        {
            idPersonal = "";
            this.nombre = nombre;
            this.password = password;
        }

        public Personal(String idPersonal, String nombre, String password)
        {
            this.idPersonal = idPersonal;
            this.nombre = nombre;
            this.password = password;
        }

        public String IdPersonal
        { get { return idPersonal; } }

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
