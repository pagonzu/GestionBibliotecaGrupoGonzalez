using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class AudiolibroDato : DocumentoDato
    {
        private String _formato;
        private int _duracionSegundos;

        public AudiolibroDato(String ISBN, int año, string titulo, string autor, string editorial,
                              bool esLibro, bool esAudioLibro, string formato, int duracion)
            : base(ISBN, año, titulo, autor, editorial, esLibro, esAudioLibro, formato, duracion)
        {
            this._formato = formato;
            this._duracionSegundos = duracion;
        }

        public String Formato
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