using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Persistencia
{
    internal class EjemplarDato: Entity<String>
    {
        private bool estado;
        private bool prestado;
        private String idTrabajador;
        private String isbn;

        public EjemplarDato(String codigo, bool prestado, String id_t, String ISBN): base(codigo)
        {
            
            this.prestado = prestado;
            this.idTrabajador = id_t;
            this.isbn = ISBN;
        }
        

        public bool Prestado
        {
            get { return prestado; }
            set { prestado = value; }
        }

        public String Trabajador
        {
            get { return idTrabajador; }
            set { idTrabajador = value; }
        }

        public String ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }
    }
}
