using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Prestamo
    {
        private int id;
        private DateTime fecha;
        bool estado;
        PersonalSala trabajador;
        Usuario usuario;

        public Prestamo(int id, DateTime fecha, bool estado, PersonalSala trabajador, Usuario usuario)
        {
            this.id = id;
            this.fecha = fecha;
            this.estado = estado;
            this.trabajador = trabajador;
            this.usuario = usuario;
        }
        public int Id
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
    }
}
