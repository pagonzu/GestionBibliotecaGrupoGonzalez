using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class PersonalAdquisiciones: Trabajador, IEquatable<PersonalAdquisiciones>
    {
        private int idAdquisiciones;

        public PersonalAdquisiciones(String nombre, String password) : base(nombre, password) {
            this.idAdquisiciones = 0;
        }

        public PersonalAdquisiciones(int idTrabajador, int idAdquisiciones, String nombre, String password) : base(idTrabajador, nombre, password)
        {
            this.idAdquisiciones = idAdquisiciones;
        }

        public int IdAdquisiciones
        {
            get { return idAdquisiciones; }
        }

        public bool Equals(PersonalAdquisiciones other)
        {
            return this.IdAdquisiciones == other.IdAdquisiciones;
        }

        public override string ToString()
        {
            return "Personal Adquisición " + IdAdquisiciones + " | Nombre: " + Nombre;
        }
    }
}
