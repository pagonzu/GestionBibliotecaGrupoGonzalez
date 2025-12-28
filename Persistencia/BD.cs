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
        private static Tabla<String, LibroDato> tablaLibros;
        private static Tabla<String, AudioLibroDato> tablaAudioLibros;
        private static Tabla<String, PrestamoDato> tablaPrestamos; 
        private static Tabla<String, PersonalAdquisicionDato> tablaPersonalAdquisicion;
        private static Tabla<String, PersonalSalaDato> tablaPersonalSala;

        
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
        public static Tabla<String, EjemplarDato> TablaEjemplares
        {
            get
            {
                if (tablaEjemplares == null)
                {
                    BD.tablaEjemplares = new Tabla<string, EjemplarDato>();
                }
                return tablaEjemplares;
            }
        }

        

        public static Tabla<String, LibroDato> TablaLibros
        {
            get
            {
                if (tablaLibros == null)
                {
                    BD.tablaLibros = new Tabla<string, LibroDato>();
                }
                return tablaLibros;
            }
        }

        public static Tabla<String, AudioLibroDato> TablaAudioLibros
        {
            get
            {
                if (tablaAudioLibros == null)
                {
                    BD.tablaAudioLibros = new Tabla<string, AudioLibroDato>();
                }
                return tablaAudioLibros;
            }
        }
        public static Tabla<String, PrestamoDato> TablaPrestamos
        {
            get
            {
                if (tablaPrestamos == null)
                {
                    BD.tablaPrestamos = new Tabla<string, PrestamoDato>();
                }
                return tablaPrestamos;
            }
        }

        public static Tabla<String, PersonalAdquisicionDato> TablaPersonalAdquisicion
        {
            get
            {
                if (tablaPersonalAdquisicion == null)
                {
                    BD.tablaPersonalAdquisicion = new Tabla<string, PersonalAdquisicionDato>();
                }
                return tablaPersonalAdquisicion;
            }
        }

        public static Tabla<String, PersonalSalaDato> TablaPersonalSala
        {
            get
            {
                if (tablaPersonalSala == null)
                {
                    BD.tablaPersonalSala = new Tabla<string, PersonalSalaDato>();
                }
                return tablaPersonalSala;
            }
        }
    


}
}
