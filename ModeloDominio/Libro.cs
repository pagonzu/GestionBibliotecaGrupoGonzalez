using ModeloDominio.EditorDeTexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    internal class Libro : Documento
    {
        public Libro(string isbn, int añoEdicion, string titulo, string autor, string editorial) 
            : base(isbn, añoEdicion, titulo, autor, editorial)
        {
        }
        public void hola() { }
    }
}
