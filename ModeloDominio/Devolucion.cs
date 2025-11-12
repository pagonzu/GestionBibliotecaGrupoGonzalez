using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    internal class Devolucion
    {
        private Prestamo prestamo;
        private Ejemplar ejemplar;
        DateTime fechaDevolucionAproximada;

        public Devolucion(Prestamo prestamo, Ejemplar ejemplar, DateTime fechaDevolucionAproximada)
        {
            this.prestamo = prestamo;
            this.ejemplar = ejemplar;
            this.fechaDevolucionAproximada = fechaDevolucionAproximada;
        }

        public Prestamo getPrestamo() { return prestamo; }
        public Ejemplar getEjemplar() { return ejemplar; }
        public DateTime getFechaDevolucionAproximada() { return fechaDevolucionAproximada; }
    }
}