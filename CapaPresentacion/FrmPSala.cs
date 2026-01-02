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
    public partial class FrmPSala : FrmPrincipal
    {
        private LNSala sesion;
        public FrmPSala():base()
        {
            InitializeComponent();
        }
        public FrmPSala(ILNPersonal n) : base(n)
        {
            InitializeComponent();
            sesion = (LNSala)n;

            this.altaToolStripMenuItem3.Click += new EventHandler(AltaPrestamo_Click);
            this.listadoToolStripMenuItem1.Click += new EventHandler(ListadoPrestamos_Click);
            this.busquedaToolStripMenuItem3.Click += new EventHandler(BusquedaPrestamo_Click);
        }

        private void AltaPrestamo_Click(object sender, EventArgs e)
        {
            AltaPrestamo frm = new AltaPrestamo(sesion);
            frm.MdiParent = this;
            frm.Show();
        }

        private void ListadoPrestamos_Click(object sender, EventArgs e)
        {
            ListadoPrestamos frm = new ListadoPrestamos(sesion);
            frm.MdiParent = this;
            frm.Show();
        }

        private void BusquedaPrestamo_Click(object sender, EventArgs e)
        {
            FrmEntradaClave frm = new FrmEntradaClave(sesion, "Busqueda", "Prestamo");
            frm.MdiParent = this;
            frm.Show();
        }

    }
}
