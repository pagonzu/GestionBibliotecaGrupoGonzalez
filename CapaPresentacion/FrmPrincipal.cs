using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        // Guardamos la lógica que recibimos del Login
        private ILNPersonal _logica;
        public FrmPrincipal(ILNPersonal sesion)
        {
            InitializeComponent();
            this._logica = sesion;
            this.Text = _logica.PersonalLogueado.Nombre + " - Gestión de biblioteca";
            ConfigurarPermisos();
        }

        private void ConfigurarPermisos()
        {
            // Si la lógica NO es de Adquisiciones, escondemos esos menús
            if (!(_logica is LNAdquisicion))
            {
                documnetosToolStripMenuItem.Visible = false; 
                ejemplaresToolStripMenuItem.Visible = false;

            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIntroducirDNI FrmDni = new FrmIntroducirDNI(_logica,"Alta");
            FrmDni.Show();
            
        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIntroducirDNI FrmDni = new FrmIntroducirDNI(_logica,"Busqueda");
            FrmDni.Show();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIntroducirDNI FrmDni = new FrmIntroducirDNI(_logica, "Baja");
            FrmDni.Show();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ILNAdquisiciones logicaAdq = _logica as ILNAdquisiciones;
            IntroducirISBN FrmDni = new IntroducirISBN(logicaAdq, "Alta");
            FrmDni.Show();
        }

        private void bajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ILNAdquisiciones logicaAdq = _logica as ILNAdquisiciones;
            IntroducirISBN FrmDni = new IntroducirISBN(logicaAdq, "Baja");
            FrmDni.Show();
        }

        private void busquedaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ILNAdquisiciones logicaAdq = _logica as ILNAdquisiciones;
            IntroducirISBN FrmDni = new IntroducirISBN(logicaAdq, "Busqueda");
            FrmDni.Show();
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ILNAdquisiciones logicaAdq = _logica as ILNAdquisiciones;
            IntroducirCodigo FrmCdg = new IntroducirCodigo(logicaAdq, "Alta");
            FrmCdg.Show();
        }
    }
}
