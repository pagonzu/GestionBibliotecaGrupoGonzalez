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
        private String idTrabajador;
        private String isbn;

        public EjemplarDato(String codigo, bool estado,String id_t,String ISBN): base(codigo)
        {
            this.estado = estado;
            this.idTrabajador = id_t;
            this.isbn = ISBN;
        }
        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
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
