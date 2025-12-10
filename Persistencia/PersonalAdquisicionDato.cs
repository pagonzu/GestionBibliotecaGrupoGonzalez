using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class PersonalAdquisicionesDatos : Entity<int>
    {
        private String nombre;
        private String password;
        private String tipoTrabajador;
        private int idAdquisiciones;

        public PersonalAdquisicionesDatos(int idTrabajador, String nombre, String password, String tipoTrabajador, int idAdquisiciones)
            : base(idTrabajador)
        {
            this.nombre = nombre;
            this.password = password;
            this.tipoTrabajador = tipoTrabajador;
            this.idAdquisiciones = idAdquisiciones;
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

        public int IdAdquisiciones
        {
            get { return idAdquisiciones; }
            set { idAdquisiciones = value; }
        }
    }
}