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
        private static Tabla<String, UsuarioDato> tablaUsuarios;

        public static Tabla<String, EjemplarDato> TablaEjemplares {  
            get {
                if (tablaEjemplares == null)
                {
                    BD.tablaEjemplares = new Tabla<string, EjemplarDato>();
                    return tablaEjemplares;
                } else
                {
                    return tablaEjemplares;
                }
            } 
        }


        public static Tabla<String, UsuarioDato> TablaUsuarios {  
            get {
                if (tablaUsuarios == null)
                {
                    BD.tablaUsuarios = new Tabla<string, UsuarioDato>();
                    return tablaUsuarios;
                } else
                {
                    return tablaUsuarios;
                }
            } 
        }


    }
}
