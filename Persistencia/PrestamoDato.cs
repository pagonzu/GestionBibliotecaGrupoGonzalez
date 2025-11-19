using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class PrestamoDato : Entity<int>
    {
        private DateTime fechaPrestamo;
        private bool estado;
        private int idTrabajador;
        private String dniUsuario;

        public PrestamoDato(int idPrestamo, DateTime fechaPrestamo, bool estado, int idTrabajador, string dniUsuario) : base(idPrestamo)
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
        public int IdTrabajador
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
