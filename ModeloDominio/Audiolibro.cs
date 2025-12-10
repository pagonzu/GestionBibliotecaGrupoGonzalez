using ModeloDominio;
using ModeloDominio.EditorDeTexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class AudioLibro : Documento
    {

        private string formato;
        private int duracionSegundos;
        public AudioLibro(string isbn, int añoEdicion, string titulo, string autor, string editorial, bool esLibro, bool esAudioLibro, string formato, int duracion)
            : base(isbn, añoEdicion, titulo, autor, editorial,esLibro, esAudioLibro)
        {
            Formato = formato;
            DuracionSegundos = duracion;
        }
        public string Formato
        {
            get { return formato; }
            set { formato = value; }
        }


        public int DuracionSegundos
        {
            get { return duracionSegundos; }
            set { duracionSegundos = value; }
        }




    }
}