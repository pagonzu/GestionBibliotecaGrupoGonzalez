using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ModeloDominio.EditorDeTexto;

namespace ModeloDominio
{
    public class Prestamo: IEquatable<Prestamo>
    {
        private String id;
        private DateTime fecha;
        bool estado;
        List<Ejemplar> ejemplaresPrestados;
        PersonalSala trabajador;
        Usuario usuario;

        public Prestamo(String id, DateTime fecha, bool estado, PersonalSala trabajador, Usuario usuario, List<Ejemplar> ejemplaresPrestados)
        {
            this.id = id;
            this.fecha = fecha;
            this.estado = estado;
            this.trabajador = trabajador;
            this.usuario = usuario;
            this.ejemplaresPrestados = ejemplaresPrestados;
        }
        public String Id
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public PersonalSala Trabajador 
        {
            get { return trabajador; }
            set { trabajador = value; }
        }
        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public List<Ejemplar> Ejemplares
        {
            get { return ejemplaresPrestados; }
            set { ejemplaresPrestados = value; }
        }

        public bool Equals(Prestamo other)
        {
            if (other == null) return false;
            return this.Id == other.Id;
        }


        public override string ToString()
        {
            return "Prestamo " + Id + " al Usuario: " + this.Usuario.ToString() +  " por el trabajador " + this.Trabajador.ToString();
        }
    }
}
