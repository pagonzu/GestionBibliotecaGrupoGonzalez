using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class LibroDato : DocumentoDato
    {
        public LibroDato(String ISBN, int año, string titulo, string autor, string editorial,
                         bool esLibro, bool esAudioLibro, string formato, int duracion)
            : base(ISBN, año, titulo, autor, editorial, esLibro, esAudioLibro, formato, duracion)
        {
        }

        
    }
}