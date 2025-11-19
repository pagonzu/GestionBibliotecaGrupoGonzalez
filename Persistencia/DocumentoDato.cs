using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq; 

namespace Persistencia
{
    internal class DocumentoDato : Entity<String>
    {
        

        private int _año_edicion;
        private String _titulo;
        private String _autor;
        private String _editorial;
        private bool _esLibro;   
        private bool _esAudioLibro; 

       

        public DocumentoDato(String ISBN, int año, string titulo, string autor, string editorial, bool esLibro, bool esAudioLibro) : base(ISBN)
        {
            // Inicialización de campos
            this._año_edicion = año;
            this._titulo = titulo;
            this._autor = autor;
            this._editorial = editorial;
            this._esLibro = esLibro;
            this._esAudioLibro = esAudioLibro;
        }

        // ===============================================
        // Propiedades (Getters y Setters)
        // ===============================================

        public int AñoEdicion
        {
            get { return _año_edicion; }
            set { _año_edicion = value; }
        }

        public String Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public String Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }

        public String Editorial
        {
            get { return _editorial; }
            set { _editorial = value; }
        }

        
        public bool EsLibro
        {
            get { return _esLibro; }
            set { _esLibro = value; }
        }

        public bool EsAudioLibro
        {
            get { return _esAudioLibro; }
            set { _esAudioLibro = value; }
        }
    }
}