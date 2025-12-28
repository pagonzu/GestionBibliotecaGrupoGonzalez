using ModeloDominio;
using ModeloDominio.EditorDeTexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Ejemplar: IEquatable<Ejemplar>
    {
        private string codigo;
        private bool estado;
        private bool prestado;
        private Personal trabajador;
        private Documento documento;
        public Ejemplar(string codigo, bool estado, bool prestado, Personal trabajadorCompra, Documento documento)
        {
            this.codigo = codigo;
            this.estado = estado;
            this.prestado = prestado;
            this.trabajador = trabajadorCompra;
            this.documento = documento;
        }

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public bool Prestado
        {
            get { return prestado; }
            set { prestado = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public Personal Trabajador
        {
            get { return trabajador; }
            set { trabajador = value; }
        }

        public Documento Documento
        {
            get { return documento; }
            set { documento = value; }
        }

        public bool Equals(Ejemplar other)
        {
            if (other == null) return false;
            return this.codigo == other.codigo;
        }
    }
}
