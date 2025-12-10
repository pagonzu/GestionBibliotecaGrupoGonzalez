using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class DocumentoDato : Entity<String>
    {
        private int añoEdicion;
        private String titulo;
        private String autor;
        private String editorial;
        private bool esLibro;
        private bool esAudioLibro;
        private String formato;
        private int duracionSegundos;

        public DocumentoDato(String ISBN, int año, string titulo, string autor, string editorial,
                             bool esLibro, bool esAudioLibro, string formato, int duracion)
            : base(ISBN)
        {
            this.añoEdicion = año;
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            this.esLibro = esLibro;
            this.esAudioLibro = esAudioLibro;
            this.formato = formato;
            this.duracionSegundos = duracion;
        }

        public int AñoEdicion
        {
            get { return añoEdicion; }
            set { añoEdicion = value; }
        }

        public String Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public String Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public String Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }

        public bool EsLibro
        {
            get { return esLibro; }
            set { esLibro = value; }
        }

        public bool EsAudioLibro
        {
            get { return esAudioLibro; }
            set { esAudioLibro = value; }
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