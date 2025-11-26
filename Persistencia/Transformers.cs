using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDominio;

namespace Persistencia
{
    internal static class Transformers
    {
        public static Usuario UsuarioDatoAUsuario(UsuarioDato usd)
        {
            if (usd == null) return null;

            Usuario u = new Usuario(usd.Id, usd.Nombre);
            u.Baja = usd.Estado; // Estado = true significa dado de baja

            return u;
        }

        public static UsuarioDato UsuarioAUsuarioDato(Usuario u)
        {
            if (u == null) return null;

            UsuarioDato usd = new UsuarioDato(u.DNI, u.Nombre, u.Baja);

            return usd;
        }
    }
}