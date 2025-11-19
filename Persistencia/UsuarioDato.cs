using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class UsuarioDato : Entity<String>
    {
        private String nombre;
        private bool estado;

        public UsuarioDato(String dni, string nombre, bool estado) : base(dni)
        {
            this.nombre = nombre;
            this.estado = estado;
        }
        public String Nombre
        {
            get { return nombre; }
            set { this.nombre = value}
        }
        public bool Estado
        { 
            get { return estado; } 
            set { this.estado = value; } 
        }
    }
}
