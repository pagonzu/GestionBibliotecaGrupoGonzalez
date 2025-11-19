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
        private string _codigo;
        private bool _estado;
        private Trabajador _trabajador;
        private Documento _documento;
        public Ejemplar(string codigo, bool estado, Trabajador trabajadorCompra, Documento documento)
        {
            Codigo = codigo;
            Estado = estado;
            Trabajador = trabajadorCompra;
            Documento = documento;
        }

        public bool Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }


        public Trabajador Trabajador
        {
            get { return _trabajador; }
            set { _trabajador = value; }
        }

        public Documento Documento
        {
            get { return _documento; }
            set { _documento = value; }
        }


    }
}
