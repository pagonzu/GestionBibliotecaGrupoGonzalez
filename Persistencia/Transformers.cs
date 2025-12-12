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
            Usuario u = new Usuario(usd.Id, usd.Nombre);
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

            return new Libro(ld.Id, ld.AñoEdicion, ld.Titulo, ld.Autor, ld.Editorial);
        }

        public static LibroDato LibroALibroDato(Libro l)
        {
            if (l == null) return null;

            return new LibroDato(l.ISBN,l.AñoEdicion,l.Titulo,l.Autor,l.Editorial);
        }

        public static AudioLibro AudioLibroDatoAAudioLibro(AudioLibroDato ald)
        {
            if (ald == null) return null;

            return new AudioLibro(ald.Id, ald.AñoEdicion, ald.Titulo, ald.Autor, ald.Editorial, ald.Formato, ald.DuracionSegundos);
        }

        public static AudioLibroDato AudioLibroAAudioLibroDato(AudioLibro al)
        {
            if (al == null) return null;

            return new AudioLibroDato(al.ISBN,al.AñoEdicion,al.Titulo,al.Autor,al.Editorial,al.Formato,al.DuracionSegundos);
        }


        public static Ejemplar EjemplarDatoAEjemplar(EjemplarDato ed)
        {
            if (ed == null) return null;

            return new Ejemplar(ed.Id, ed.Estado, ed.Trabajador, ed.ISBN); //Falta buscar en las tablas y sacar el objeto a partir de clave
        }

        public static EjemplarDato EjemplarAEjemplarDato(Ejemplar e)
        {
            if (e == null) return null;

            return new EjemplarDato(e.Codigo,e.Estado, e.Trabajador.IdTrabajador.ToString(), e.Documento.ISBN); //Revisar el ToString, quizas hay que cambiar algo en las tablas o Trabajador
        }

        public static Prestamo PrestamoDatoAPrestamo(PrestamoDato pd)
        {
            if (pd == null) return null;
   
            return new Prestamo(pd.Id, pd.FechaPrestamo, pd.Estado, pd.IdTrabajador, pd.DNIUsuario);  //Falta buscar en las tablas y sacar el objeto a partir de clave; 
        }

        public static PrestamoDato PrestamoAPrestamoDato(Prestamo p)
        {
            if (p == null) return null;

            return new PrestamoDato(p.Id,p.Fecha,p.Estado,p.Trabajador.IdTrabajador,p.Usuario.DNI);
        }

        public static PersonalAdquisiciones PersonalAdqDatoAPersonalAdq(PersonalAdquisicionesDatos pad)
        {
            if (pad == null) return null;

            return new PersonalAdquisiciones(pad.Id, pad.IdAdquisiciones, pad.Nombre, pad.Password);
        }

        public static PersonalAdquisicionesDatos PersonalAdqAPersonalAdqDato(PersonalAdquisiciones pa)
        {
            if (pa == null) return null;

            return new PersonalAdquisicionesDatos(pa.IdTrabajador,pa.Nombre,pa.Password,pa.GetType().ToString(),pa.IdAdquisiciones);
        }

        public static PersonalSala PersonalSalaDatoAPersonalSala(PersonalSalaDatos psd)
        {
            if (psd == null) return null;

            return new PersonalSala(psd.Id, psd.IdSala, psd.Nombre, psd.Password);
        }

        public static PersonalSalaDatos PersonalSalaAPersonalSalaDato(PersonalSala ps)
        {
            if (ps == null) return null;

            return new PersonalSalaDatos(ps.IdTrabajador,ps.Nombre,ps.Password,ps.GetType().ToString(),ps.IdSala);
        }

    }
}
