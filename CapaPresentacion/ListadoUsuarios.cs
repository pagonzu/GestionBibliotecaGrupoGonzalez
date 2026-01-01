using LogicaNegocio;
using ModeloDominio;
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
    public partial class ListadoUsuarios : Form
    {
        private BindingSource miDirector = new BindingSource();
        public ListadoUsuarios(ILNPersonal sesion)
        {
            InitializeComponent();
            miDirector.DataSource = sesion.GetTodosUsuarios();

            lstDNI.DataSource = miDirector;
            lstDNI.DisplayMember = "Dni";
            lstNombre.DataSource = miDirector;
            lstNombre.DisplayMember = "Nombre";


        }

        private void DNI_Click(object sender, EventArgs e)
        {
            // Obtenemos la lista que tiene el director, la ordenamos por nombre
            // y le decimos al director que los datos han cambiado.
            List<Usuario> lista = (List<Usuario>)miDirector.DataSource;

            // Usamos LINQ (OrderBy) para ordenar fácilmente
            miDirector.DataSource = lista.OrderBy(u => u.Nombre).ToList();

            // El auxiliar dice que ResetBindings avisa a los controles de que hay cambios
            miDirector.ResetBindings(false);
        }

        private void Nombre_Click(object sender, EventArgs e)
        {
            // Obtenemos la lista que tiene el director, la ordenamos por nombre
            // y le decimos al director que los datos han cambiado.
            List<Usuario> lista = (List<Usuario>)miDirector.DataSource;

            // Usamos LINQ (OrderBy) para ordenar fácilmente
            miDirector.DataSource = lista.OrderBy(u => u.Nombre).ToList();

            // El auxiliar dice que ResetBindings avisa a los controles de que hay cambios
            miDirector.ResetBindings(false);
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
