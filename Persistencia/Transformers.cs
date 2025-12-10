using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDominio;

namespace Persistencia
{
    internal static class Transformers
    {
        public static Usuario UsuarioDatoAUsuario(UsuarioDato usd)
        {
            if (usd == null) return null;
            Usuario u = new Usuario(usd.Id, usd.Nombre); // Asumiendo Id es DNI
            u.Baja = usd.Estado;
            return u;
        }

        public static UsuarioDato UsuarioAUsuarioDato(Usuario u)
        {
            if (u == null) return null;
            return new UsuarioDato(u.DNI, u.Nombre, u.Baja);
        }

        public static Libro LibroDatoALibro(LibroDato ld)
        {
            if (ld == null) return null;

            // Ajusta los parámetros según el constructor de tu clase Libro
            Libro l = new Libro(ld.Id,ld.AñoEdicion,ld.Titulo,ld.Autor,ld.Editorial);
            return l;
        }

        public static LibroDato LibroALibroDato(Libro l)
        {
            if (l == null) return null;

            // Ajusta los parámetros según el constructor de LibroDato
            return new LibroDato(l.ISBN,l.AñoEdicion,l.Titulo,l.Autor,l.Editorial);
        }

        public static AudioLibro AudioLibroDatoAAudioLibro(AudioLibroDato ald)
        {
            if (ald == null) return null;

            // Asumo que AudioLibro tiene duración o narrador
            Audiolibro al = new Audiolibro(ald.Id,ald.AñoEdicion,ald.Titulo,ald.Autor,ald.Editorial,ald.Formato,ald.DuracionSegundos);
            return al;
        }

        public static AudioLibroDato AudioLibroAAudioLibroDato(Audiolibro al)
        {
            if (al == null) return null;

            return new AudioLibroDato(al.);
        }


        public static Ejemplar EjemplarDatoAEjemplar(EjemplarDato ed)
        {
            if (ed == null) return null;

            // Un ejemplar suele necesitar el objeto Libro/Documento asociado.
            // Aquí asumimos que Ejemplar tiene un ID y quizás un estado (Deteriorado, etc.)
            Ejemplar e = new Ejemplar();

            // Si EjemplarDato guarda relación con el libro (ej. ISBN), habría que asignarlo:
            // e.LibroISBN = ed.LibroId; 

            return e;
        }

        public static EjemplarDato EjemplarAEjemplarDato(Ejemplar e)
        {
            if (e == null) return null;

            return new EjemplarDato(e.Id, e.Estado);
        }

        public static Prestamo PrestamoDatoAPrestamo(PrestamoDato pd)
        {
            if (pd == null) return null;

            // Reconstruir un préstamo suele requerir buscar el Usuario y el Ejemplar reales
            // Usamos los IDs guardados en el Dato para instanciar (o buscar)
            Usuario u = new Usuario(pd.UsuarioId, "NombrePlaceholder"); // O buscar en BD
            Ejemplar e = new Ejemplar(pd.EjemplarId, "EstadoPlaceholder"); // O buscar en BD

            Prestamo p = new Prestamo(pd.Id, u, e, pd.FechaPrestamo);
            p.FechaDevolucion = pd.FechaDevolucion; // Si existe

            return p;
        }

        public static PrestamoDato PrestamoAPrestamoDato(Prestamo p)
        {
            if (p == null) return null;

            // Al guardar en dato, solemos guardar solo los IDs de las relaciones
            return new PrestamoDato(p.Id, p.UsuarioSolicitante.DNI, p.EjemplarPrestado.Id, p.FechaInicio);
        }
-
        public static PersonalAdquisicion PersonalAdqDatoAPersonalAdq(PersonalAdquisicionDato pad)
        {
            if (pad == null) return null;

            PersonalAdquisicion pa = new PersonalAdquisicion(pad.Id, pad.Nombre);
            // pa.Sector = pad.Sector; // Propiedades especificas
            return pa;
        }

        public static PersonalAdquisicionDato PersonalAdqAPersonalAdqDato(PersonalAdquisicion pa)
        {
            if (pa == null) return null;

            return new PersonalAdquisicionDato(pa.DNI, pa.Nombre);
        }

        public static PersonalSala PersonalSalaDatoAPersonalSala(PersonalSalaDatos psd)
        {
            if (psd == null) return null;

            PersonalSala ps = new PersonalSala(psd.Id, psd.Nombre);
            // ps.Turno = psd.Turno;
            return ps;
        }

        public static PersonalSalaDatos PersonalSalaAPersonalSalaDato(PersonalSala ps)
        {
            if (ps == null) return null;

            return new PersonalSalaDatos(ps.DNI, ps.Nombre);
        }

    }
}
