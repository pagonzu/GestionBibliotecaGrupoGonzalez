using LogicaNegocio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. CREAMOS LA INSTANCIA ÚNICA DE PERSISTENCIA
            IPersistencia persistencia = new Persistencia.Persistencia();

            // 2. INICIALIZAMOS LOS ADMINS (pasando la persistencia)
            LNAdquisicion.InicializarAdmin(persistencia);
            LNSala.InicializarAdmin(persistencia);

            // 3. PASAMOS LA PERSISTENCIA AL LOGIN
            // El formulario de login la guardará para poder usarla en el método Login de la lógica
            Application.Run(new Loguearse(persistencia));
        }
    }
    
}
