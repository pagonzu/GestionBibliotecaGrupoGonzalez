using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ModeloDominio;

namespace LogicaNegocio
{
    internal class UsuarioLogica
    {
        public void anyadirUsuario(Usuario u)
        {
            Persistencia.Persistencia.CREATE(u);
        }
    }
}
