using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class PersonalSalaDato : Entity<String>
    {
        private String nombre;
        private String password;

        public PersonalSalaDato(String idTrabajador, String nombre, String password)
            : base(idTrabajador)
        {
            this.nombre = nombre;
            this.password = password;
        }


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