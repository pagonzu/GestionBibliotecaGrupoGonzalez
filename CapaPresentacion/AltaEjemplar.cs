using LogicaNegocio;
using ModeloDominio;
using ModeloDominio.EditorDeTexto;
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
    public partial class AltaEjemplar : Form
    {
        private ILNAdquisiciones sesion;

        public AltaEjemplar(ILNAdquisiciones sesion, string codigoRecibido)
        {
            InitializeComponent();
            this.sesion = sesion;

            // 1. Bloqueamos el código porque ya viene definido de la ventana anterior
            txtCodigo.Text = codigoRecibido;
            txtCodigo.Enabled = false;

            // 2. Cargamos el personal de la sesión [2025-12-30]
            txtPersonal.Text = sesion.PersonalLogueado.Nombre;

            // 3. Cargamos la lista de ISBNs para que el usuario elija uno
            List<Documento> listaDocs = sesion.GetTodosDocumentos();
            cmbDocumento.DataSource = listaDocs;
            cmbDocumento.DisplayMember = "Isbn";
            cmbDocumento.ValueMember = "Isbn";
        }

        // ESTO DEBE SER EL CLICK DE UN BOTÓN "ACEPTAR"
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validamos que haya algo seleccionado en el combo
                if (cmbDocumento.SelectedItem == null) return;

                // 1. Comprobamos si el código ya existe (Seguridad)
                if (sesion.GetEjemplarPorCodigo(txtCodigo.Text) != null)
                {
                    MessageBox.Show("Este código de ejemplar ya está registrado.");
                    return;
                }

                // 2. Obtenemos los datos del formulario
                bool prestado = Prestado.Checked;
                Documento docSeleccionado = (Documento)cmbDocumento.SelectedItem;
                Personal p = sesion.PersonalLogueado;

                // 3. Creamos el objeto de dominio (Pass by Reference) [2025-12-21]
                Ejemplar nuevoEj = new Ejemplar(txtCodigo.Text, prestado, p, docSeleccionado);

                // 4. Guardamos en la lógica
                sesion.AltaEjemplar(nuevoEj);

                MessageBox.Show("Ejemplar añadido con éxito.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
