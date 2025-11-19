using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal static class BD
    {
        private static Tabla<String, EjemplarDato> tablaEjemplares;

        public static Tabla<String, EjemplarDato> TablaEjemplar {  
            get {
                if (tablaEjemplares == null)
                {
                    BD.tablaEjemplares = new Tabla<string, EjemplarDato>();
                }
            } 
            set { } 
        }


    }
}
