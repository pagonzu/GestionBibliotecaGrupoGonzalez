using ModeloDominio;
using ModeloDominio.EditorDeTexto;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicaNegocio
{
    public class LNAdquisicion : LNPersonal, ILNAdquisiciones
    {
        // Login ESTÁTICO: valida TablaPersonalAdquisicion y devuelve instancia
        public static LNAdquisicion Login(string usuario, string contraseña)
        {
            PersonalAdquisiciones personal = Persistencia.Persistencia.READ_PERSONAL_ADQUISICIONES(usuario);
            if (personal == null) return null;
            if (personal.Password != contraseña) return null;

            var instancia = new LNAdquisicion(personal);
            return instancia;
        }
        private LNAdquisicion(PersonalAdquisiciones p) {
            PersonalLogueado = p;
        } // Privado: solo vía Login()

        // Libros
        public void AltaLibro(Libro libro)
        {
            Persistencia.Persistencia.CREATE(libro);
        }

        public void BajaLibro(string isbn)
        {
            Libro libro = GetLibroPorIsbn(isbn);
            if (libro != null) Persistencia.Persistencia.DELETE(libro);
        }

        public void ActualizarLibro(Libro libro)
        {
            Persistencia.Persistencia.UPDATE(libro);
        }

        public Libro GetLibroPorIsbn(string isbn)
        {
            return Persistencia.Persistencia.READ_ALL_LIBROS()
                   .FirstOrDefault(l => l.ISBN == isbn);
        }

        public List<Libro> GetTodosLibros()
        {
            return Persistencia.Persistencia.READ_ALL_LIBROS();
        }

        // Audiolibros
        public void AltaAudioLibro(AudioLibro audioLibro)
        {
            Persistencia.Persistencia.CREATE(audioLibro);
        }

        public void BajaAudioLibro(string isbn)
        {
            var audio = GetAudioLibroPorIsbn(isbn);
            if (audio != null) Persistencia.Persistencia.DELETE(audio);
        }

        public void ActualizarAudioLibro(AudioLibro audioLibro)
        {
            Persistencia.Persistencia.UPDATE(audioLibro);
        }

        public AudioLibro GetAudioLibroPorIsbn(string isbn)
        {
            return Persistencia.Persistencia.READ_ALL_AUDIOLIBROS()
                   .FirstOrDefault(a => a.ISBN == isbn);
        }

        public List<AudioLibro> GetTodosAudioLibros()
        {
            return Persistencia.Persistencia.READ_ALL_AUDIOLIBROS();
        }

        // Ejemplares
        public void AltaEjemplar(Ejemplar ejemplar)
        {
            ejemplar.Trabajador = PersonalLogueado;
            Persistencia.Persistencia.CREATE(ejemplar);
        }

        public void BajaEjemplar(string codigoEjemplar)
        {
            Ejemplar ej = GetEjemplarPorCodigo(codigoEjemplar);
            if (ej != null)
            {
                ej.Estado = false;
                Persistencia.Persistencia.UPDATE(ej);
            }
        }

        public void ActualizarEjemplar(Ejemplar ejemplar)
        {
            Persistencia.Persistencia.UPDATE(ejemplar);
        }

        public Ejemplar GetEjemplarPorCodigo(string codigoEjemplar)
        {
            return Persistencia.Persistencia.READ(codigoEjemplar);
        }

        public List<Ejemplar> GetEjemplaresDeDocumento(string isbn)
        {
            return Persistencia.Persistencia.READ_ALL_EJEMPLARES()
                   .Where(e => e.Documento.ISBN == isbn)
                   .ToList();
        }

        public bool ExisteEjemplarDisponible(string isbn)
        {
            return GetEjemplaresDeDocumento(isbn)
                   .Any(e => !e.Estado && !e.Prestado);
        }

        public DateTime? GetFechaPrevisionDisponible(string isbn)
        {
            var prestamos = Persistencia.Persistencia.READ_ALL_PRESTAMOS()
                .Where(p => p.Estado &&
                       p.Ejemplares.Any(e => e.Documento.ISBN == isbn && e.Prestado));

            DateTime? fechaMinima = null;
            foreach (var p in prestamos)
            {
                foreach (var e in p.Ejemplares.Where(ej => ej.Documento.ISBN == isbn && ej.Prestado))
                {
                    int diasMaximo = e.Documento is AudioLibro ? 10 : 15;
                    var fechaPrevista = p.Fecha.AddDays(diasMaximo);
                    if (fechaMinima == null || fechaPrevista < fechaMinima)
                        fechaMinima = fechaPrevista;
                }
            }
            return fechaMinima;
        }

        public List<Documento> GetTodosDocumentos()
        {
            var docs = new List<Documento>();
            docs.AddRange(GetTodosLibros());
            docs.AddRange(GetTodosAudioLibros());
            return docs.Cast<Documento>().ToList();
        }
    }
}

