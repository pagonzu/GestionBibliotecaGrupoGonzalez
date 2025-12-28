using ModeloDominio;
using System.Collections.Generic;

namespace LogicaNegocio
{
    public interface ILNPersonal
    {
        Personal PersonalLogueado { get; set; }

        // Gestión de usuarios
        void AltaUsuario(Usuario u);
        void BajaUsuario(string dni);
        void ActualizarUsuario(Usuario u);
        Usuario GetUsuarioPorDni(string dni);
        List<Usuario> GetTodosUsuarios();

        // Consultas asociadas a usuarios
        List<Ejemplar> GetEjemplaresPrestadosUsuario(string dniUsuario);
        bool UsuarioConPrestamoFueraDePlazo(string dniUsuario);
        List<Prestamo> GetPrestamosDeUsuario(string dniUsuario);
    }
}
