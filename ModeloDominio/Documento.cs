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
       
        internal abstract class Documento
        {
            private string _isbn;
            private int _añoEdicion;
            private string _titulo;
            private string _autor;
            private string _editorial;
            private bool esLibro;
            private bool esAudioLibro;

            public Documento(string isbn, int año, string titulo, string autor, string editorial, bool esLibro, bool esAudioLibro)
            {
                _isbn = isbn;
                _añoEdicion = año;
                _titulo = titulo;
                _autor = autor;
                _editorial = editorial;
                this.esLibro = esLibro;
                this.esAudioLibro = esAudioLibro;
            }

            public string ISBN
            {
                get { return _isbn; }
                set { _isbn = value; }
            }

            public int AñoEdicion
            {
                get { return _añoEdicion; }
                set { _añoEdicion = value; }
            }

            public string Titulo
            {
                get { return _titulo; }
                set { _titulo = value; }
            }

            public string Autor
            {
                get { return _autor; }
                set { _autor = value; }
            }

            public string Editorial
            {
                get { return _editorial; }
                set { _editorial = value; }
            }

            

            
            
        }
    }
}
