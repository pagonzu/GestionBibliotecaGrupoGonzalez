using ModeloDominio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicaNegocio
{
    public class LNSala : LNPersonal, ILNSala
    {
        // Login ESTÁTICO: valida TablaPersonalSala y devuelve instancia
        public static LNSala Login(string usuario, string contraseña)
        {
            PersonalSala personal = Persistencia.Persistencia.READ_PERSONAL_SALA(usuario);
            if (personal == null) return null;
            if (personal.Password != contraseña) return null;

            var instancia = new LNSala(personal);
            return instancia;
        }

        private LNSala(PersonalSala p) { 
            base.PersonalLogueado = p;
        }

        private LNSala() { } // Privado: solo vía Login()

        // Préstamos
        public void AltaPrestamo(Prestamo p)
        {
            p.Trabajador = PersonalLogueado as PersonalSala;
            Persistencia.Persistencia.CREATE(p);
        }

        public void ActualizarPrestamo(Prestamo p)
        {
            Persistencia.Persistencia.UPDATE(p);
        }

        public void BajaPrestamo(string idPrestamo)
        {
            var prestamo = GetPrestamoPorId(idPrestamo);
            if (prestamo != null)
                Persistencia.Persistencia.DELETE(prestamo);
        }

        public Prestamo GetPrestamoPorId(string idPrestamo)
        {
            return Persistencia.Persistencia.READ_PRESTAMO(idPrestamo);
        }

        public List<Prestamo> GetTodosPrestamos()
        {
            return Persistencia.Persistencia.READ_ALL_PRESTAMOS();
        }

        public string GetEstadoPrestamo(string idPrestamo)
        {
            var p = GetPrestamoPorId(idPrestamo);
            return p?.Estado.ToString();
        }

        public List<Ejemplar> GetEjemplaresNoDevueltos(string idPrestamo)
        {
            var p = GetPrestamoPorId(idPrestamo);
            return p?.Ejemplares.Where(e => e.Prestado).ToList() ?? new List<Ejemplar>();
        }

        public List<Prestamo> GetPrestamosPorDocumento(string isbn)
        {
            return Persistencia.Persistencia.READ_ALL_PRESTAMOS()
                   .Where(p => p.Ejemplares.Any(e => e.Documento.ISBN == isbn))
                   .ToList();
        }

        public void DevolverEjemplar(string idPrestamo, string codigoEjemplar, DateTime fechaDevolucion)
        {
            var p = GetPrestamoPorId(idPrestamo);
            if (p == null) return;

            var ej = p.Ejemplares.FirstOrDefault(e => e.Codigo == codigoEjemplar);
            if (ej != null)
            {
                ej.Prestado = false;
            }

            if (p.Ejemplares.All(e => !e.Prestado))
                p.Estado = true;

            Persistencia.Persistencia.UPDATE(p);
        }

        public List<Prestamo> GetPrestamosFueraDePlazoEnProceso()
        {
            var hoy = DateTime.Now;
            return Persistencia.Persistencia.READ_ALL_PRESTAMOS()
                .Where(p => p.Estado)
                .Where(p => p.Ejemplares.Any(e => e.Prestado &&
                    ((hoy - p.Fecha).TotalDays > (e.Documento is AudioLibro ? 10 : 15))))
                .ToList();
        }
        public Ejemplar GetEjemplarPorCodigo(string codigo)
        {
            return Persistencia.Persistencia.READ(codigo);
        }
    }
}
