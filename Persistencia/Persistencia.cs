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

        // ----------------------------------------------------------------
        // SECCIÓN: USUARIOS (Ya tenías parte de esto)
        // ----------------------------------------------------------------
        public static void CREATE(Usuario entity)
        {
            UsuarioDato u = Transformers.UsuarioAUsuarioDato(entity);
            BD.TablaUsuarios.Add(u);
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
            // Buscamos el dato antiguo por su ID (o DNI/Correo)
            var datoExistente = BD.TablaUsuarios.FirstOrDefault(x => x.Id == entity.Id);

            if (datoExistente != null)
            {
                BD.TablaUsuarios.Remove(datoExistente); // Borramos el viejo
                BD.TablaUsuarios.Add(Transformers.UsuarioAUsuarioDato(entity)); // Añadimos el nuevo actualizado
            }
        }

        public static void DELETE(Usuario entity)
        {
            var dato = BD.TablaUsuarios.FirstOrDefault(x => x.Id == entity.Id);
            if (dato != null) BD.TablaUsuarios.Remove(dato);
        }

        // ----------------------------------------------------------------
        // SECCIÓN: EJEMPLARES (Corrección del TODO)
        // ----------------------------------------------------------------
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

        public static Ejemplar READ()
        {
            Ejemplar ejemplar = null;
            foreach (var d in BD.TablaEjemplares) if (d.Id == ejemplar.Codigo) ejemplar = Transformers.EjemplarDatoAEjemplar(d);
            return ejemplar;
        }

        public static void UPDATE(Ejemplar entity)
        {
            var dato = BD.TablaEjemplares.FirstOrDefault(x => x.Id == entity.Id);
            if (dato != null)
            {
                BD.TablaEjemplares.Remove(dato);
                BD.TablaEjemplares.Add(Transformers.EjemplarAEjemplarDato(entity));
            }
        }

        public static void DELETE(Ejemplar entity)
        {
            var dato = BD.TablaEjemplares.FirstOrDefault(x => x.Id == entity.Id);
            if (dato != null) BD.TablaEjemplares.Remove(dato);
        }

        // ----------------------------------------------------------------
        // SECCIÓN: LIBROS
        // ----------------------------------------------------------------
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

        public static void UPDATE(Libro entity)
        {
            // Asumiendo que el identificador es ISBN o Id
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

        // ----------------------------------------------------------------
        // SECCIÓN: AUDIOLIBROS
        // ----------------------------------------------------------------
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

        public static void UPDATE(AudioLibro entity)
        {
            var dato = BD.TablaAudioLibros.FirstOrDefault(x => x.Id == entity.Id);
            if (dato != null)
            {
                BD.TablaAudioLibros.Remove(dato);
                BD.TablaAudioLibros.Add(Transformers.AudioLibroAAudioLibroDato(entity));
            }
        }

        public static void DELETE(AudioLibro entity)
        {
            var dato = BD.TablaAudioLibros.FirstOrDefault(x => x.Id == entity.Id);
            if (dato != null) BD.TablaAudioLibros.Remove(dato);
        }

        // ----------------------------------------------------------------
        // SECCIÓN: PRESTAMOS
        // ----------------------------------------------------------------
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

        // ----------------------------------------------------------------
        // SECCIÓN: PERSONAL (Adquisición y Sala)
        // ----------------------------------------------------------------

        // PERSONAL ADQUISICION
        public static void CREATE(PersonalAdquisicion entity)
        {
            PersonalAdquisicionDato p = Transformers.PersonalAdqAPersonalAdqDato(entity);
            BD.TablaPersonalAdquisicion.Add(p);
        }
        public static void CREATE(Ejemplar entity)
        {
            // TODO: añadir clase Transformer
            EjemplarDato a = null;

            BD.TablaEjemplares.Add(a);
        }

        public static void CREATE(Usuario e)
        {
            // TODO: añadir clase Transformer
            UsuarioDato u = Transformers.UsuarioAUsuarioDato(e);

            BD.TablaUsuarios.Add(u);
        }
    }
}
