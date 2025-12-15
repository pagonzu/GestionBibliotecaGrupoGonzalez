using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class PrestamoDato : Entity<String>
    {
        private DateTime fechaPrestamo;
        private bool estado;
        private String idTrabajador;
        private String dniUsuario;

        public PrestamoDato(String idPrestamo, DateTime fechaPrestamo, bool estado, String idTrabajador, string dniUsuario) : base(idPrestamo)
        {
            this.fechaPrestamo = fechaPrestamo;
            this.estado = estado;
            this.idTrabajador = idTrabajador;
            this.dniUsuario = dniUsuario;
        }
        public DateTime FechaPrestamo
        {
            get { return fechaPrestamo; }
            set { fechaPrestamo = value; }
        }
        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public String IdTrabajador
        {
            get { return idTrabajador; }
            set { idTrabajador = value; }
        }
        public string DNIUsuario
        {
            get { return dniUsuario; }
            set { dniUsuario = value; }
        }
    }
}
