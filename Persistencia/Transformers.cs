using ModeloDominio;
using ModeloDominio.EditorDeTexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            PersonalAdquisiciones trabajador = null;
            if (ed.Trabajador != null && BD.TablaPersonalAdquisicion.Contains(ed.Trabajador))
            {
                var trabajadorDato = BD.TablaPersonalAdquisicion[ed.Trabajador];
                trabajador = PersonalAdqDatoAPersonalAdq(trabajadorDato);
            }

            Documento documento = null;
            if (ed.ISBN != null)
            {
                if (BD.TablaLibros.Contains(ed.ISBN))
                {
                    var libroDato = BD.TablaLibros[ed.ISBN];
                    documento = LibroDatoALibro(libroDato);
                }
                else if (BD.TablaAudioLibros.Contains(ed.ISBN))
                {
                    var audioDato = BD.TablaAudioLibros[ed.ISBN];
                    documento = AudioLibroDatoAAudioLibro(audioDato);
                }
            }

            return new Ejemplar(ed.Id, ed.Estado, ed.Prestado, trabajador, documento);
        }

        public static EjemplarDato EjemplarAEjemplarDato(Ejemplar e)
        {
            if (e == null) return null;

            return new EjemplarDato(e.Codigo, e.Estado, e.Prestado, e.Trabajador.IdPersonal, e.Documento.ISBN);
        }

        public static Prestamo PrestamoDatoAPrestamo(PrestamoDato pd)
        {
            if (pd == null) return null;

            PersonalSala trabajador = null;
            if (pd.IdTrabajador != null && BD.TablaPersonalSala.Contains(pd.IdTrabajador))
            {
                var trabajadorDato = BD.TablaPersonalSala[pd.IdTrabajador];
                trabajador = PersonalSalaDatoAPersonalSala(trabajadorDato);
            }

            Usuario usuario = null;
            if(pd.DNIUsuario != null && BD.TablaUsuarios.Contains(pd.DNIUsuario))
            {
                var usuarioDato = BD.TablaUsuarios[pd.DNIUsuario];
                usuario = UsuarioDatoAUsuario(usuarioDato);
            }

            List<Ejemplar> listaEjemplares = new List<Ejemplar>();
            if (pd.ListaEjemplares != null)
            {
                foreach (string idEjemplar in pd.ListaEjemplares)
                {
                    if (BD.TablaEjemplares.Contains(idEjemplar))
                    {
                        var ejemplarDato = BD.TablaEjemplares[idEjemplar];
                        listaEjemplares.Add(EjemplarDatoAEjemplar(ejemplarDato));
                    }
                }
            }

            return new Prestamo(pd.Id, pd.FechaPrestamo, pd.Estado, trabajador, usuario, listaEjemplares);
        }

        public static PrestamoDato PrestamoAPrestamoDato(Prestamo p)
        {
            if (p == null) return null;

            List<string> listaEjemplares = new List<string>();
            foreach (Ejemplar ejemplar in p.Ejemplares)
            {
                listaEjemplares.Add(ejemplar.Codigo);
            }

            return new PrestamoDato(p.Id,p.Fecha,p.Estado,p.Trabajador.IdPersonal,p.Usuario.DNI,listaEjemplares);
        }

        public static PersonalAdquisiciones PersonalAdqDatoAPersonalAdq(PersonalAdquisicionDato pad)
        {
            if (pad == null) return null;

            return new PersonalAdquisiciones(pad.Id, pad.Nombre, pad.Password);
        }

        public static PersonalAdquisicionDato PersonalAdqAPersonalAdqDato(PersonalAdquisiciones pa)
        {
            if (pa == null) return null;

            return new PersonalAdquisicionDato(pa.IdPersonal, pa.Nombre, pa.Password);
        }

        public static PersonalSala PersonalSalaDatoAPersonalSala(PersonalSalaDato psd)
        {
            if (psd == null) return null;

            return new PersonalSala(psd.Id, psd.Nombre, psd.Password);
        }

        public static PersonalSalaDato PersonalSalaAPersonalSalaDato(PersonalSala ps)
        {
            if (ps == null) return null;

            return new PersonalSalaDato(ps.IdPersonal, ps.Nombre, ps.Password);
        }

    }
}
