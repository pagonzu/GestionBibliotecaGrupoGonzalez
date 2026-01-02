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
    public partial class ListadoDocumentos : Form
    {
        
        private BindingSource miDirector = new BindingSource();
        public ListadoDocumentos(LNAdquisicion sesion)
        {
            InitializeComponent();
            
            miDirector.DataSource = sesion.GetTodosDocumentos();
            dgvDocumentos.DataSource = miDirector;
        }

        
    }
}
