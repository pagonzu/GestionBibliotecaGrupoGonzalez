using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class EjemplarDato: Entity<String>
    {
        private int ejemplo;

        public EjemplarDato(String codigo, int ejemplo): base(codigo)
        {
            this.ejemplo = ejemplo;
        }
    }
}
