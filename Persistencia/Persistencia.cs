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
