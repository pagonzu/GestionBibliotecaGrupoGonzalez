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
        // 1. CONSTRUCTOR: Inyecta la persistencia y la envía al padre (LNPersonal)
        public LNAdquisicion(PersonalAdquisiciones p, IPersistencia persistencia)
            : base(persistencia)
        {
            this.personalLogueado = p;
        }

        // 2. INICIALIZAR ADMIN: Ahora requiere la instancia de persistencia
        public static void InicializarAdmin(IPersistencia persistencia)
        {
            PersonalAdquisiciones admin = new PersonalAdquisiciones("yazid", "2005");
            persistencia.CREATE(admin);
        }

        // 3. LOGIN: Recibe la persistencia para poder buscar y crear la instancia
        public static LNAdquisicion Login(string usuario, string contraseña, IPersistencia persistencia)
        {
            PersonalAdquisiciones personal = persistencia.READ_PERSONAL_ADQUISICIONES(usuario);

            if (personal == null || personal.Password != contraseña) return null;

            return new LNAdquisicion(personal, persistencia);
        }

        // --- GESTIÓN DE LIBROS ---
        public void AltaLibro(Libro libro)
        {
            _datos.CREATE(libro);
        }

        public void BajaLibro(string isbn)
        {
            Libro libro = GetLibroPorIsbn(isbn);
            if (libro != null) _datos.DELETE(libro);
        }

        public void ActualizarLibro(Libro libro)
        {
            _datos.UPDATE(libro);
        }

        public Libro GetLibroPorIsbn(string isbn)
        {
            return _datos.READ_ALL_LIBROS()
                   .FirstOrDefault(l => l.ISBN == isbn);
        }

        public List<Libro> GetTodosLibros()
        {
            return _datos.READ_ALL_LIBROS();
        }

        // --- GESTIÓN DE AUDIOLIBROS ---
        public void AltaAudioLibro(AudioLibro audioLibro)
        {
            _datos.CREATE(audioLibro);
        }

        public void BajaAudioLibro(string isbn)
        {
            var audio = GetAudioLibroPorIsbn(isbn);
            if (audio != null) _datos.DELETE(audio);
        }

        public void ActualizarAudioLibro(AudioLibro audioLibro)
        {
            _datos.UPDATE(audioLibro);
        }

        public AudioLibro GetAudioLibroPorIsbn(string isbn)
        {
            return _datos.READ_ALL_AUDIOLIBROS()
                   .FirstOrDefault(a => a.ISBN == isbn);
        }

        public List<AudioLibro> GetTodosAudioLibros()
        {
            return _datos.READ_ALL_AUDIOLIBROS();
        }

        // --- GESTIÓN DE EJEMPLARES ---
        public void AltaEjemplar(Ejemplar ejemplar)
        {
            // Asignamos el trabajador logueado antes de guardar
            ejemplar.Trabajador = PersonalLogueado;
            // Usamos la persistencia inyectada [cite: 2025-12-30]
            _datos.CREATE(ejemplar);
        }

        public void BajaEjemplar(string codigoEjemplar)
        {
            Ejemplar ej = GetEjemplarPorCodigo(codigoEjemplar);
            if (ej != null)
            {
                ej.Prestado = false;
                _datos.DELETE(ej);
            }
        }

        public void ActualizarEjemplar(Ejemplar ejemplar)
        {
            _datos.UPDATE(ejemplar);
        }

        public Ejemplar GetEjemplarPorCodigo(string codigoEjemplar)
        {
            return _datos.READ(codigoEjemplar);
        }

        public List<Ejemplar> GetEjemplaresDeDocumento(string isbn)
        {
            return _datos.READ_ALL_EJEMPLARES()
                   .Where(e => e.Documento.ISBN == isbn)
                   .ToList();
        }

        public List<Ejemplar> GetTodosEjemplares()
        {
            return _datos.READ_ALL_EJEMPLARES();
        }

        public bool ExisteEjemplarDisponible(string isbn)
        {
            return GetEjemplaresDeDocumento(isbn)
                   .Any(e => !e.Prestado);
        }

        public DateTime? GetFechaPrevisionDisponible(string isbn)
        {
            var prestamos = _datos.READ_ALL_PRESTAMOS()
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
            return docs;
        }

        public Documento GetDocumentoPorIsbn(string isbn)
        {
            Documento doc = GetLibroPorIsbn(isbn);
            if (doc == null)
            {
                doc = GetAudioLibroPorIsbn(isbn);
            }
            return doc;
        }
    }
}