using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class PersonalSalaDatos : Entity<String>
    {
        private String nombre;
        private String password;
        private String tipoTrabajador;
        private int idSala;

        public PersonalSalaDatos(String idTrabajador, String nombre, String password, String tipoTrabajador, int idSala)
            : base(idTrabajador)
        {
            this.nombre = nombre;
            this.password = password;
            this.tipoTrabajador = tipoTrabajador;
            this.idSala = idSala;
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

        public String TipoTrabajador
        {
            get { return tipoTrabajador; }
            set { tipoTrabajador = value; }
        }

        public int IdSala
        {
            get { return idSala; }
            set { idSala = value; }
        }
    }
}