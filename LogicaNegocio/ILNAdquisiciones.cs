using ModeloDominio;
using ModeloDominio.EditorDeTexto;
using System;
using System.Collections.Generic;

namespace LogicaNegocio
{
    public interface ILNAdquisiciones:ILNPersonal
    {
        // Libros
        void AltaLibro(Libro libro);
        void BajaLibro(string isbn);
        void ActualizarLibro(Libro libro);
        Libro GetLibroPorIsbn(string isbn);
        List<Libro> GetTodosLibros();

        // Audiolibros
        void AltaAudioLibro(AudioLibro audioLibro);
        void BajaAudioLibro(string isbn);
        void ActualizarAudioLibro(AudioLibro audioLibro);
        AudioLibro GetAudioLibroPorIsbn(string isbn);
        List<AudioLibro> GetTodosAudioLibros();

        // Ejemplares
        void AltaEjemplar(Ejemplar ejemplar);
        void BajaEjemplar(string codigoEjemplar);
        void ActualizarEjemplar(Ejemplar ejemplar);
        Ejemplar GetEjemplarPorCodigo(string codigoEjemplar);
        List<Ejemplar> GetEjemplaresDeDocumento(string isbn);

        // Consultas avanzadas
        bool ExisteEjemplarDisponible(string isbn);
        DateTime? GetFechaPrevisionDisponible(string isbn);
        List<Documento> GetTodosDocumentos();
        Documento GetDocumentoPorIsbn(string isbn);

    }
}
