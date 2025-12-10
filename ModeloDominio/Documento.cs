using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace EditorDeTexto
    {
       
        public abstract class Documento
        {
            private string isbn;
            private int añoEdicion;
            private string titulo;
            private string autor;
            private string editorial;
            private bool esLibro;
            private bool esAudioLibro;

            public Documento(string isbn, int año, string titulo, string autor, string editorial)
            {
                isbn = isbn;
                añoEdicion = año;
                titulo = titulo;
                autor = autor;
                editorial = editorial;
                
            }

            public string ISBN
            {
                get { return isbn; }
                set { isbn = value; }
            }

            public int AñoEdicion
            {
                get { return añoEdicion; }
                set { añoEdicion = value; }
            }

            public string Titulo
            {
                get { return titulo; }
                set { titulo = value; }
            }

            public string Autor
            {
                get { return autor; }
                set { autor = value; }
            }

            public string Editorial
            {
                get { return editorial; }
                set { editorial = value; }
            }

            

           







        }
    }
}
