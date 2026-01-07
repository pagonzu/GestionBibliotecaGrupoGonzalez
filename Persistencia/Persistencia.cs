using ModeloDominio;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class Persistencia
    {
        //USUARIO
        public static void CREATE(Usuario entity)
        {
            UsuarioDato u = Transformers.UsuarioAUsuarioDato(entity);
            BD.TablaUsuarios.Add(u);
        }
        public static Usuario READ_USUARIO(string codigo)
        {
            Usuario usuario = null;
            foreach (var us in BD.TablaUsuarios) if (us.Id == codigo) usuario = Transformers.UsuarioDatoAUsuario(us);
            return usuario;
        }

        public static List<Usuario> READ_ALL_USUARIOS()
        {
            List<Usuario> listaDominio = new List<Usuario>();
            foreach (var dato in BD.TablaUsuarios)
            {
                listaDominio.Add(Transformers.UsuarioDatoAUsuario(dato));
            }
            return listaDominio;
        }

        public static void UPDATE(Usuario entity)
        {
            var datoExistente = BD.TablaUsuarios.FirstOrDefault(x => x.Id == entity.DNI);

            if (datoExistente != null)
            {
                BD.TablaUsuarios.Remove(datoExistente);
                BD.TablaUsuarios.Add(Transformers.UsuarioAUsuarioDato(entity));
            }
        }

        public static void DELETE(Usuario entity)
        {
            var dato = BD.TablaUsuarios.FirstOrDefault(x => x.Id == entity.DNI);
            if (dato != null) BD.TablaUsuarios.Remove(dato);
        }
        
        //EJEMPLAR
        public static void CREATE(Ejemplar entity)
        {
            EjemplarDato a = Transformers.EjemplarAEjemplarDato(entity);
            BD.TablaEjemplares.Add(a);
        }

        public static List<Ejemplar> READ_ALL_EJEMPLARES()
        {
            List<Ejemplar> lista = new List<Ejemplar>();
            foreach (var d in BD.TablaEjemplares) lista.Add(Transformers.EjemplarDatoAEjemplar(d));
            return lista;
        }

        public static Ejemplar READ(string codigo)
        {
            Ejemplar ejemplar = null;
            foreach (var d in BD.TablaEjemplares) if (d.Id == codigo) ejemplar = Transformers.EjemplarDatoAEjemplar(d);
            return ejemplar;
        }

        public static void UPDATE(Ejemplar entity)
        {
            var dato = BD.TablaEjemplares.FirstOrDefault(x => x.Id == entity.Codigo);
            if (dato != null)
            {
                BD.TablaEjemplares.Remove(dato);
                BD.TablaEjemplares.Add(Transformers.EjemplarAEjemplarDato(entity));
            }
        }

        public static void DELETE(Ejemplar entity)
        {
            var dato = BD.TablaEjemplares.FirstOrDefault(x => x.Id == entity.Codigo);
            if (dato != null) BD.TablaEjemplares.Remove(dato);
        }

        //LIBRO
        public static void CREATE(Libro entity)
        {
            LibroDato l = Transformers.LibroALibroDato(entity);
            BD.TablaLibros.Add(l);
        }

        public static List<Libro> READ_ALL_LIBROS()
        {
            List<Libro> lista = new List<Libro>();
            foreach (var d in BD.TablaLibros) lista.Add(Transformers.LibroDatoALibro(d));
            return lista;
        }

        public static Libro READ_LIBRO(string isbn)
        {
            foreach (var d in BD.TablaLibros)
                if (d.ISBN == isbn) return Transformers.LibroDatoALibro(d);
            return null;
        }

        public static void UPDATE(Libro entity)
        {
            var dato = BD.TablaLibros.FirstOrDefault(x => x.ISBN == entity.ISBN);
            if (dato != null)
            {
                BD.TablaLibros.Remove(dato);
                BD.TablaLibros.Add(Transformers.LibroALibroDato(entity));
            }
        }

        public static void DELETE(Libro entity)
        {
            var dato = BD.TablaLibros.FirstOrDefault(x => x.ISBN == entity.ISBN);
            if (dato != null) BD.TablaLibros.Remove(dato);
        }

        //AUDIOLIBRO
        public static void CREATE(AudioLibro entity)
        {
            AudioLibroDato ad = Transformers.AudioLibroAAudioLibroDato(entity);
            BD.TablaAudioLibros.Add(ad);
        }

        public static List<AudioLibro> READ_ALL_AUDIOLIBROS()
        {
            List<AudioLibro> lista = new List<AudioLibro>();
            foreach (var d in BD.TablaAudioLibros) lista.Add(Transformers.AudioLibroDatoAAudioLibro(d));
            return lista;
        }

        public static AudioLibro READ_AUDIOLIBRO(string isbn)
        {
            foreach (var d in BD.TablaAudioLibros)
                if (d.ISBN == isbn) return Transformers.AudioLibroDatoAAudioLibro(d);
            return null;
        }

        public static void UPDATE(AudioLibro entity)
        {
            var dato = BD.TablaAudioLibros.FirstOrDefault(x => x.Id == entity.ISBN);
            if (dato != null)
            {
                BD.TablaAudioLibros.Remove(dato);
                BD.TablaAudioLibros.Add(Transformers.AudioLibroAAudioLibroDato(entity));
            }
        }

        public static void DELETE(AudioLibro entity)
        {
            var dato = BD.TablaAudioLibros.FirstOrDefault(x => x.Id == entity.ISBN);
            if (dato != null) BD.TablaAudioLibros.Remove(dato);
        }

        //PRESTAMO
        public static void CREATE(Prestamo entity)
        {
            PrestamoDato p = Transformers.PrestamoAPrestamoDato(entity);
            BD.TablaPrestamos.Add(p);
        }

        public static List<Prestamo> READ_ALL_PRESTAMOS()
        {
            List<Prestamo> lista = new List<Prestamo>();
            foreach (var d in BD.TablaPrestamos) lista.Add(Transformers.PrestamoDatoAPrestamo(d));
            return lista;
        }

        public static Prestamo READ_PRESTAMO(string idPrestamo)
        {
            Prestamo prestamo = null;
            foreach (var ps in BD.TablaPrestamos) if (ps.Id == idPrestamo) prestamo = Transformers.PrestamoDatoAPrestamo(ps);
            return prestamo;
        }

        public static void UPDATE(Prestamo entity)
        {
            var dato = BD.TablaPrestamos.FirstOrDefault(x => x.Id == entity.Id);
            if (dato != null)
            {
                BD.TablaPrestamos.Remove(dato);
                BD.TablaPrestamos.Add(Transformers.PrestamoAPrestamoDato(entity));
            }
        }

        public static void DELETE(Prestamo entity)
        {
            var dato = BD.TablaPrestamos.FirstOrDefault(x => x.Id == entity.Id);
            if (dato != null) BD.TablaPrestamos.Remove(dato);
        }

        //PERSONAL SALA
        public static void CREATE(PersonalSala entity)
        {
            PersonalSalaDato p = Transformers.PersonalSalaAPersonalSalaDato(entity);
            BD.TablaPersonalSala.Add(p);
        }

        public static PersonalSala READ_PERSONAL_SALA(string usuario)
        {
            PersonalSala personalSala = null;
            foreach (var ps in BD.TablaPersonalSala) if (ps.Nombre == usuario) personalSala = Transformers.PersonalSalaDatoAPersonalSala(ps);
            return personalSala;
        }

        public static List<PersonalSala> READ_ALL_PERSONAL_SALA()
        {
            List<PersonalSala> lista = new List<PersonalSala>();
            foreach (var d in BD.TablaPersonalSala) lista.Add(Transformers.PersonalSalaDatoAPersonalSala(d));
            return lista;
        }

        public static void UPDATE(PersonalSala entity)
        {
            var dato = BD.TablaPersonalSala.FirstOrDefault(x => x.Id == entity.IdPersonal);
            if (dato != null)
            {
                BD.TablaPersonalSala.Remove(dato);
                BD.TablaPersonalSala.Add(Transformers.PersonalSalaAPersonalSalaDato(entity));
            }
        }

        public static void DELETE(PersonalSala entity)
        {
            var dato = BD.TablaPersonalSala.FirstOrDefault(x => x.Id == entity.IdPersonal);
            if (dato != null) BD.TablaPersonalSala.Remove(dato);
        }

        //PERSONAL ADQUISICIONES
        public static void CREATE(PersonalAdquisiciones entity)
        {
            PersonalAdquisicionDato p = Transformers.PersonalAdqAPersonalAdqDato(entity);
            BD.TablaPersonalAdquisicion.Add(p);
        }
        public static PersonalAdquisiciones READ_PERSONAL_ADQUISICIONES(string usuario)
        {
            PersonalAdquisiciones personalAdquisiciones = null;
            foreach (var ps in BD.TablaPersonalAdquisicion) if (ps.Nombre == usuario) personalAdquisiciones = Transformers.PersonalAdqDatoAPersonalAdq(ps);
            return personalAdquisiciones;
        }

        public static List<PersonalAdquisiciones> READ_ALL_PERSONAL_ADQUISICIONES()
        {
            List<PersonalAdquisiciones> lista = new List<PersonalAdquisiciones>();
            foreach (var d in BD.TablaPersonalAdquisicion) lista.Add(Transformers.PersonalAdqDatoAPersonalAdq(d));
            return lista;
        }

        public static void UPDATE(PersonalAdquisiciones entity)
        {
            var dato = BD.TablaPersonalAdquisicion.FirstOrDefault(x => x.Id == entity.IdPersonal);
            if (dato != null)
            {
                BD.TablaPersonalAdquisicion.Remove(dato);
                BD.TablaPersonalAdquisicion.Add(Transformers.PersonalAdqAPersonalAdqDato(entity));
            }
        }

        public static void DELETE(PersonalAdquisiciones entity)
        {
            var dato = BD.TablaPersonalAdquisicion.FirstOrDefault(x => x.Id == entity.IdPersonal);
            if (dato != null) BD.TablaPersonalAdquisicion.Remove(dato);
        }
    }
}
