using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class AudioLibroDato : DocumentoDato
    {
        private String formato;
        private int duracionSegundos;

        public AudioLibroDato(String ISBN, int año, string titulo, string autor, string editorial,
                               string formato, int duracion)
            : base(ISBN, año, titulo, autor, editorial)
        {
            this.formato = formato;
            this.duracionSegundos = duracion;
        }

        public String Formato
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