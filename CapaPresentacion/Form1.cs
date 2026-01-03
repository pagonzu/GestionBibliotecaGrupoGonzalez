using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
using Persistencia; // Necesario para reconocer IPersistencia

namespace CapaPresentacion
{
    public partial class Loguearse : Form
    {
        // 1. Declaramos la variable para guardar la persistencia que viene de Program.cs
        private readonly IPersistencia _persistencia;

        // 2. Modificamos el constructor para recibir la persistencia (Inyección)
        public Loguearse(IPersistencia persistenciaInyectada)
        {
            InitializeComponent();
            // Guardamos la instancia para usarla en el botón entrar
            this._persistencia = persistenciaInyectada;
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            string usuario = nombreLog.Text;
            string pass = contraseñaLog.Text;

            if (opSala.Checked) // Si eligió Personal de Sala
            {
                // 3. Pasamos la instancia de persistencia al método Login
                ILNSala sesionSala = LNSala.Login(usuario, pass, _persistencia);

                if (sesionSala != null)
                {
                    // Abrimos la ventana principal pasando la sesión
                    FrmPrincipal frm = new FrmPSala(sesionSala);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña de Sala incorrectos.");
                }
            }
            else if (opAd.Checked) // Si eligió Personal de Adquisiciones
            {
                // 4. Pasamos la instancia de persistencia al método Login de Adquisiciones
                ILNAdquisiciones sesionAdq = LNAdquisicion.Login(usuario, pass, _persistencia);

                if (sesionAdq != null)
                {
                    FrmPrincipal frm = new FrmPAdq(sesionAdq);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña de Adquisiciones incorrectos.");
                }
            }
        }
    }
}