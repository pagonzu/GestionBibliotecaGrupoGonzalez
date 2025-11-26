using ModeloDominio;
using ModeloDominio.EditorDeTexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    internal class Audiolibro : Documento
    {

        private string _formato;
        private int _duracionSegundos;
        public Audiolibro(string isbn, int añoEdicion, string titulo, string autor, string editorial, bool esLibro, bool esAudioLibro, string formato, int duracion)
            : base(isbn, añoEdicion, titulo, autor, editorial,esLibro, esAudioLibro)
        {
            Formato = formato;
            DuracionSegundos = duracion;
        }
        public string Formato
        {
            get { return _formato; }
            set { _formato = value; }
        }


        public int DuracionSegundos
        {
            get { return _duracionSegundos; }
            set { _duracionSegundos = value; }
        }




    }
}