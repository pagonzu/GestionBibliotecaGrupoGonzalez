using ModeloDominio;
using System;
using System.Collections.Generic;

namespace LogicaNegocio
{
    public interface ILNSala
    {
        // Gestión de préstamos
        void AltaPrestamo(Prestamo p);
        void ActualizarPrestamo(Prestamo p);
        void BajaPrestamo(string idPrestamo);
        Prestamo GetPrestamoPorId(string idPrestamo);
        List<Prestamo> GetTodosPrestamos();

        // Consultas específicas
        string GetEstadoPrestamo(string idPrestamo);
        List<Ejemplar> GetEjemplaresNoDevueltos(string idPrestamo);
        List<Prestamo> GetPrestamosPorDocumento(string isbn);
        void DevolverEjemplar(string idPrestamo, string codigoEjemplar, DateTime fechaDevolucion);
        List<Prestamo> GetPrestamosFueraDePlazoEnProceso();
    }
}
