using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class DocumentoDato : Entity<String>
    {
        private String isbn;
        private int añoEdicion;
        private String titulo;
        private String autor;
        private String editorial;
        private bool esLibro;
        private bool esAudioLibro;
        private String formato;
        private int duracionSegundos;

        public DocumentoDato(String ISBN, int año, string titulo, string autor, string editorial)
            : base(ISBN)
        {
            this.isbn = ISBN;
            this.añoEdicion = año;
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            
        }

        public String ISBN
        {
            get { return this.isbn; }
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

        
    }
}