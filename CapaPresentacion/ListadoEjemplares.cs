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
    public partial class ListadoEjemplares : Form
    {
        BindingSource miDirector = new BindingSource();
        public ListadoEjemplares()
        {
            InitializeComponent();
        }

        public ListadoEjemplares(ILNAdquisiciones sesion)
        {
            InitializeComponent();

            miDirector.DataSource = sesion.GetTodosEjemplares();
            dataGridView1.DataSource = miDirector;
        }
    }
}
