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
        public FrmPrincipal() {
            InitializeComponent();
        }
        public FrmPrincipal(ILNPersonal sesion)
        {
            InitializeComponent();
            this._logica = sesion;
            this.IsMdiContainer = true;
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
            else {
                prestamoToolStripMenuItem.Visible = false;
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEntradaClave frm = new FrmEntradaClave(_logica, "Alta", "Usuario");
            frm.MdiParent = this;
            frm.Show();
        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEntradaClave frm = new FrmEntradaClave(_logica, "Busqueda", "Usuario");
            frm.MdiParent = this;
            frm.Show();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEntradaClave frm = new FrmEntradaClave(_logica, "Baja", "Usuario");
            frm.MdiParent = this;
            frm.Show();
        }

        

        private void busquedaPorDNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusquedaPorDNI FrmDni = new BusquedaPorDNI(_logica);
            FrmDni.Show();
        }

        private void listadoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoUsuarios FrmDni = new ListadoUsuarios(_logica);
            FrmDni.Show();
        }

        private void recorridoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnoAUnoUsuarios u = new UnoAUnoUsuarios(_logica);
            u.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro que deseas cerrar sesión?","Cerrar Sesión",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Loguearse login = new Loguearse(true);
                login.Show();
                this.Dispose();
            }
        }
    }
}
