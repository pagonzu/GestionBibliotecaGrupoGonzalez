using ModeloDominio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicaNegocio
{
    public abstract class LNPersonal : ILNPersonal
    {
        // 1. Definimos el campo de la interfaz (sustituye el acoplamiento a la clase estática)
        protected readonly IPersistencia _datos;

        protected Personal personalLogueado;

        // 2. Constructor que recibe la persistencia (Inyección de Dependencias)
        protected LNPersonal(IPersistencia persistencia)
        {
            this._datos = persistencia;
        }

        public virtual Personal PersonalLogueado
        {
            get { return personalLogueado; }
            set { personalLogueado = value; }
        }

        // Gestión de usuarios usando la instancia inyectada
        public virtual void AltaUsuario(Usuario u)
        {
            // Ya no usamos Persistencia.Persistencia.CREATE
            _datos.CREATE(u);
        }

        public virtual void BajaUsuario(string dni)
        {
            var usuario = GetUsuarioPorDni(dni);
            if (usuario != null)
                _datos.DELETE(usuario); // Usamos la interfaz
        }

        public virtual void ActualizarUsuario(Usuario u)
        {
            _datos.UPDATE(u); // Usamos la interfaz
        }

        public virtual Usuario GetUsuarioPorDni(string dni)
        {
            return _datos.READ_USUARIO(dni); // Usamos la interfaz
        }

        public virtual List<Usuario> GetTodosUsuarios()
        {
            return _datos.READ_ALL_USUARIOS(); // Usamos la interfaz
        }

        // Consultas asociadas a usuarios
        public virtual List<Ejemplar> GetEjemplaresPrestadosUsuario(string dniUsuario)
        {
            // Usamos la interfaz para leer los préstamos
            var prestamos = _datos.READ_ALL_PRESTAMOS()
                .Where(p => p.Usuario.DNI == dniUsuario && p.Estado);

            var ejemplares = new List<Ejemplar>();
            foreach (var prestamo in prestamos)
            {
                ejemplares.AddRange(prestamo.Ejemplares.Where(e => e.Prestado));
            }
            return ejemplares;
        }

        public virtual bool UsuarioConPrestamoFueraDePlazo(string dniUsuario)
        {
            var hoy = DateTime.Now;
            // Usamos la interfaz para obtener los datos
            var prestamos = _datos.READ_ALL_PRESTAMOS()
                .Where(p => p.Usuario.DNI == dniUsuario && p.Estado);

            foreach (var p in prestamos)
            {
                foreach (var ej in p.Ejemplares.Where(e => e.Prestado))
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
            // Usamos la interfaz para obtener los préstamos
            return _datos.READ_ALL_PRESTAMOS()
                   .Where(p => p.Usuario.DNI == dniUsuario)
                   .ToList();
        }
    }
}