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

namespace CapaPresentacion
{
    public partial class Loguearse : Form
    {
        public Loguearse()
        {
            InitializeComponent();
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            string usuario = nombreLog.Text;
            string pass = contraseñaLog.Text;
            if (opSala.Checked) // Si eligió Personal de Sala
            {
                // Llamamos al método estático de Login que ya tienes hecho
                var sesionSala = LNSala.Login(usuario, pass);

                if (sesionSala != null)
                {
                    // Si el login es correcto, abrimos la ventana principal
                    
                    FrmPrincipal frm = new FrmPrincipal(sesionSala);
                    frm.Show();
                    this.Hide(); // Escondemos el login
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña de Sala incorrectos.");
                }
            }
            else if (opAd.Checked) // Si eligió Personal de Adquisiciones
            {
                var sesionAdq = LNAdquisicion.Login(usuario, pass);

                if (sesionAdq != null)
                {
                    FrmPrincipal frm = new FrmPrincipal(sesionAdq);
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
