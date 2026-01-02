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
    public partial class ListadoPrestamos : Form
    {
        public ListadoPrestamos(ILNSala sesion)
        {
            InitializeComponent();
            dataGridView1.DataSource = sesion.GetTodosPrestamos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
