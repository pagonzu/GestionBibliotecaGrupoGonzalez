using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class PersonalSala: Trabajador, IEquatable<PersonalSala>
    {
        private int idSala;

        public PersonalSala(String nombre, String password) : base(nombre, password)
        {
            this.idSala = 0;
        }

        public PersonalSala(String idTrabajador, int idSala, String nombre, String password) : base(idTrabajador, nombre, password)
        {
            this.idSala = idSala;
        }

        public int IdSala
        {
            get { return idSala; }
        }

        public bool Equals(PersonalSala other)
        {
            return this.IdSala == other.IdSala;
        }

        public override string ToString()
        {
            return "Personal Adquisición " + IdSala + " | Nombre: " + Nombre;
        }
    }
}
