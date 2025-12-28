using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class PersonalAdquisiciones: Personal, IEquatable<PersonalAdquisiciones>
    {

        public PersonalAdquisiciones(String nombre, String password) : base(nombre, password) {}

        public PersonalAdquisiciones(String idTrabajador, String nombre, String password) : base(idTrabajador, nombre, password)
        {}

        public bool Equals(PersonalAdquisiciones other)
        {
            if (other == null) return false;
            return this.IdPersonal == other.IdPersonal;
        }

        public override string ToString()
        {
            return "Personal Adquisición " + IdPersonal + " | Nombre: " + Nombre;
        }
    }
}
