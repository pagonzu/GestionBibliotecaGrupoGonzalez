using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class PersonalSala: Personal, IEquatable<PersonalSala>
    {
        private int idSala;

        public PersonalSala(String nombre, String password) : base(nombre, password)
        {}

        public PersonalSala(String idTrabajador, String nombre, String password) : base(idTrabajador, nombre, password)
        {}

        public bool Equals(PersonalSala other)
        {
            if (other == null) return false;
            return this.IdPersonal == other.IdPersonal;
        }

        public override string ToString()
        {
            return "Personal Sala " + IdPersonal + " | Nombre: " + Nombre;
        }
    }
}
