using ModeloDominio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicaNegocio
{
    public abstract class LNPersonal : ILNPersonal
    {
        protected Personal personalLogueado;

        public virtual Personal PersonalLogueado
        {
            get { return personalLogueado; }
            set { personalLogueado = value; }
        }

        // Gestión de usuarios
        public virtual void AltaUsuario(Usuario u)
        {
            Persistencia.Persistencia.CREATE(u);
        }

        public virtual void BajaUsuario(string dni)
        {
            var usuario = GetUsuarioPorDni(dni);
            if (usuario != null)
                Persistencia.Persistencia.DELETE(usuario);
        }

        public virtual void ActualizarUsuario(Usuario u)
        {
            Persistencia.Persistencia.UPDATE(u);
        }

        public virtual Usuario GetUsuarioPorDni(string dni)
        {
            return Persistencia.Persistencia.READ_USUARIO(dni);
        }

        public virtual List<Usuario> GetTodosUsuarios()
        {
            return Persistencia.Persistencia.READ_ALL_USUARIOS();
        }

        // Consultas asociadas a usuarios
        public virtual List<Ejemplar> GetEjemplaresPrestadosUsuario(string dniUsuario)
        {
            var prestamos = Persistencia.Persistencia.READ_ALL_PRESTAMOS()
                .Where(p => p.Usuario.DNI == dniUsuario && p.Estado);

            var ejemplares = new List<Ejemplar>();
            foreach (var prestamo in prestamos)
            {
                ejemplares.AddRange(prestamo.Ejemplares.Where(e => e.Estado && e.Prestado));
            }
            return ejemplares;
        }

        public virtual bool UsuarioConPrestamoFueraDePlazo(string dniUsuario)
        {
            var hoy = DateTime.Now;
            var prestamos = Persistencia.Persistencia.READ_ALL_PRESTAMOS()
                .Where(p => p.Usuario.DNI == dniUsuario && p.Estado);

            foreach (var p in prestamos)
            {
                foreach (var ej in p.Ejemplares.Where(e => e.Estado && e.Prestado))
                {
                    int diasMaximo = ej.Documento is AudioLibro ? 10 : 15;
                    if ((hoy - p.Fecha).TotalDays > diasMaximo)
                        return true;
                }
            }
            return false;
        }

        public virtual List<Prestamo> GetPrestamosDeUsuario(string dniUsuario)
        {
            return Persistencia.Persistencia.READ_ALL_PRESTAMOS()
                   .Where(p => p.Usuario.DNI == dniUsuario)
                   .ToList();
        }
    }
}
