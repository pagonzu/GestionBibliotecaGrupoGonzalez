using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    internal class Prestamo
    {
        private int id;
        private DateTime fecha;
        bool estado;
        Trabajador trabajador;
        Usuario usuario;

        public Prestamo(int id, DateTime fecha, bool estado, Trabajador trabajador, Usuario usuario)
        {
            this.id = id;
            this.fecha = fecha;
            this.estado = estado;
            this.trabajador = trabajador;
            this.usuario = usuario;
        }
        public int getId() { return id; }
        public DateTime getFecha() { return fecha; }
        public bool getEstado() { return estado; }
        public Trabajador getTrabajador() { return trabajador; }
        public Usuario getUsuario() { return usuario; }
        public void setFecha(DateTime fecha) { this.fecha = fecha; }
        public void setEstado(bool estado) {  this.estado = estado; }
    }
}
