using ModeloDominio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicaNegocio
{
    public class LNSala : LNPersonal, ILNSala
    {
        // 1. CONSTRUCTOR: Recibe el personal y la persistencia
        // Usamos :base(persistencia) para enviarla a LNPersonal
        public LNSala(PersonalSala p, IPersistencia persistencia) : base(persistencia)
        {
            this.personalLogueado = p;
        }

        // 2. INICIALIZAR ADMIN: Ahora requiere recibir la persistencia
        public static void InicializarAdmin(IPersistencia persistencia)
        {
            PersonalSala admin = new PersonalSala("yazid", "2005");
            // Usamos la instancia recibida, no la clase estática
            persistencia.CREATE(admin);
        }

        // 3. LOGIN: Recibe la persistencia desde la Capa de Presentación
        public static LNSala Login(string usuario, string contraseña, IPersistencia persistencia)
        {
            // Usamos la instancia de persistencia inyectada para buscar al usuario
            PersonalSala personal = persistencia.READ_PERSONAL_SALA(usuario);

            if (personal == null) return null;
            if (personal.Password != contraseña) return null;

            // Creamos la instancia de la lógica pasando la persistencia
            return new LNSala(personal, persistencia);
        }

        // --- MÉTODOS DE PRÉSTAMOS ---
        // Todos usan "_datos", que es la interfaz heredada de LNPersonal

        public void AltaPrestamo(Prestamo p)
        {
            p.Trabajador = PersonalLogueado as PersonalSala;
            _datos.CREATE(p);
        }

        public void ActualizarPrestamo(Prestamo p)
        {
            _datos.UPDATE(p);
        }

        public void BajaPrestamo(string idPrestamo)
        {
            var prestamo = GetPrestamoPorId(idPrestamo);
            if (prestamo != null)
                _datos.DELETE(prestamo);
        }

        public Prestamo GetPrestamoPorId(string idPrestamo)
        {
            return _datos.READ_PRESTAMO(idPrestamo);
        }

        public List<Prestamo> GetTodosPrestamos()
        {
            return _datos.READ_ALL_PRESTAMOS();
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
            return _datos.READ_ALL_PRESTAMOS()
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

            _datos.UPDATE(p);
        }

        public List<Prestamo> GetPrestamosFueraDePlazoEnProceso()
        {
            var hoy = DateTime.Now;
            return _datos.READ_ALL_PRESTAMOS()
                .Where(p => p.Estado)
                .Where(p => p.Ejemplares.Any(e => e.Prestado &&
                    ((hoy - p.Fecha).TotalDays > (e.Documento is AudioLibro ? 10 : 15))))
                .ToList();
        }

        public Ejemplar GetEjemplarPorCodigo(string codigo)
        {
            return _datos.READ(codigo);
        }
    }
}