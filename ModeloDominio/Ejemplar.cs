using ModeloDominio;
using ModeloDominio.EditorDeTexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Ejemplar
    {
        private string codigo;
        private bool estado;
        private Trabajador trabajador;
        private Documento documento;
        public Ejemplar(string codigo, bool estado, Trabajador trabajadorCompra, Documento documento)
        {
            Codigo = codigo;
            Estado = estado;
            Trabajador = trabajadorCompra;
            Documento = documento;
        }

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }


        public Trabajador Trabajador
        {
            get { return trabajador; }
            set { trabajador = value; }
        }

        public Documento Documento
        {
            get { return documento; }
            set { documento = value; }
        }


    }
}
