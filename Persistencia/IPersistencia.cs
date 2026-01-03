using ModeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public interface IPersistencia
    {
        // USUARIO
        void CREATE(Usuario entity);
        Usuario READ_USUARIO(string codigo);
        List<Usuario> READ_ALL_USUARIOS();
        void UPDATE(Usuario entity);
        void DELETE(Usuario entity);

        // EJEMPLAR
        void CREATE(Ejemplar entity);
        List<Ejemplar> READ_ALL_EJEMPLARES();
        Ejemplar READ(string codigo);
        void UPDATE(Ejemplar entity);
        void DELETE(Ejemplar entity);

        // LIBRO
        void CREATE(Libro entity);
        List<Libro> READ_ALL_LIBROS();
        Libro READ_LIBRO(string isbn);
        void UPDATE(Libro entity);
        void DELETE(Libro entity);

        // AUDIOLIBRO
        void CREATE(AudioLibro entity);
        List<AudioLibro> READ_ALL_AUDIOLIBROS();
        AudioLibro READ_AUDIOLIBRO(string isbn);
        void UPDATE(AudioLibro entity);
        void DELETE(AudioLibro entity);

        // PRESTAMO
        void CREATE(Prestamo entity);
        List<Prestamo> READ_ALL_PRESTAMOS();
        Prestamo READ_PRESTAMO(string idPrestamo);
        void UPDATE(Prestamo entity);
        void DELETE(Prestamo entity);

        // PERSONAL SALA
        void CREATE(PersonalSala entity);
        PersonalSala READ_PERSONAL_SALA(string usuario);
        List<PersonalSala> READ_ALL_PERSONAL_SALA();
        void UPDATE(PersonalSala entity);
        void DELETE(PersonalSala entity);

        // PERSONAL ADQUISICIONES
        void CREATE(PersonalAdquisiciones entity);
        PersonalAdquisiciones READ_PERSONAL_ADQUISICIONES(string usuario);
        List<PersonalAdquisiciones> READ_ALL_PERSONAL_ADQUISICIONES();
        void UPDATE(PersonalAdquisiciones entity);
        void DELETE(PersonalAdquisiciones entity);
    }
}
