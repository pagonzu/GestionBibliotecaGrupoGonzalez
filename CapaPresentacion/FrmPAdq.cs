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

namespace CapaPresentacion
{
    public partial class FrmPAdq : FrmPrincipal
    {
        private LNAdquisicion sesion;
        public FrmPAdq():base()
        {
            InitializeComponent();
        }
        public FrmPAdq(ILNPersonal n) : base(n)
        {
            InitializeComponent();
            sesion = (LNAdquisicion)n;
            
            this.altaToolStripMenuItem1.Click += new EventHandler(altaToolStripMenuItem1_Click);
            this.bajaToolStripMenuItem1.Click += new EventHandler(bajaToolStripMenuItem1_Click);
            this.busquedaToolStripMenuItem1.Click += new EventHandler(busquedaToolStripMenuItem1_Click);

            this.altaToolStripMenuItem2.Click += new EventHandler(altaToolStripMenuItem2_Click);
            this.bajaToolStripMenuItem2.Click += new EventHandler(bajaToolStripMenuItem2_Click);
            this.busquedaToolStripMenuItem2.Click += new EventHandler(busquedaToolStripMenuItem2_Click);
            this.listadoToolStripMenuItem.Click += new EventHandler(listadoToolStripMenuItem_Click);
        }
        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmEntradaClave frm = new FrmEntradaClave(sesion, "Alta", "Documento");
            frm.MdiParent = this;
            frm.Show();
        }

        private void bajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmEntradaClave frm = new FrmEntradaClave(sesion, "Baja", "Documento");
            frm.MdiParent = this;
            frm.Show();
        }

        private void busquedaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmEntradaClave frm = new FrmEntradaClave(sesion, "Busqueda", "Documento");
            frm.MdiParent = this;
            frm.Show();
        }

        
        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmEntradaClave Frm = new FrmEntradaClave(sesion, "Alta", "Ejemplar");
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void bajaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmEntradaClave Frm = new FrmEntradaClave(sesion, "Baja", "Ejemplar");
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void busquedaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmEntradaClave Frm = new FrmEntradaClave(sesion, "Busqueda", "Ejemplar");
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoDocumentos Frm = new ListadoDocumentos(sesion);
            Frm.MdiParent = this;
            Frm.Show();
        }


    }
}
