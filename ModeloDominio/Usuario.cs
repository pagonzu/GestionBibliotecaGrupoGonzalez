using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Usuario: IEquatable<Usuario>
    {
        private String dni;
        private String nombre;
        private Boolean baja;

        public Usuario(String nombre) 
        {
            this.dni = "";
            this.nombre = nombre;
            this.baja = false;
        }

        public Usuario(String DNI, String nombre)
        {
            this.dni = DNI;
            this.nombre = nombre;
            this.baja = false;
        }

        public String DNI 
        { 
            get { return this.dni; }
        }

        public String Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public Boolean Baja
        {
            get { return this.baja; }
            set { this.baja = value; }
        }

        public bool Equals(Usuario other)
        {
            return this.DNI.Equals(other.DNI);
        }

        public override string ToString()
        {
            return "Usuario " + DNI + " | Nombre: " + Nombre + " | Baja: " + (Baja ? "Si" : "No");
        }


    }
}
