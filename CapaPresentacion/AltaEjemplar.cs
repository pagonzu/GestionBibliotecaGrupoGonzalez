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
        private string modo;
        private string cod;

        public AltaEjemplar(ILNAdquisiciones sesion, string codigoRecibido, string modo)
        {
            InitializeComponent();
            this.sesion = sesion;
            cod = codigoRecibido;

            // 1. Bloqueamos el código porque ya viene definido de la ventana anterior
            txtCodigo.Text = codigoRecibido;
            txtCodigo.ReadOnly = true;
            this.modo = modo;
            // 2. Cargamos el personal de la sesión [2025-12-30]
            txtPersonal.Text = sesion.PersonalLogueado.Nombre;
            txtPersonal.ReadOnly = true;

            // 3. Cargamos la lista de ISBNs para que el usuario elija uno
            if (modo.Equals("Alta")) {
                List<Documento> listaDocs = sesion.GetTodosDocumentos();
                cmbDocumento.DataSource = listaDocs;
                cmbDocumento.DisplayMember = "Isbn";
                cmbDocumento.ValueMember = "Isbn";
                

            }
            if (modo.Equals("Busqueda")|| modo.Equals("Baja"))
            {
                Ejemplar ej = sesion.GetEjemplarPorCodigo(codigoRecibido);
                // 2. Creamos una lista temporal solo con el documento de ese ejemplar
                // para que el ComboBox pueda "enlazarse" correctamente
                List<Documento> listaTemporal = new List<Documento>();
                listaTemporal.Add(ej.Documento); // Usamos la referencia al documento [cite: 2025-12-21]

                cmbDocumento.DataSource = listaTemporal;
                cmbDocumento.DisplayMember = "Isbn";
                cmbDocumento.ValueMember = "Isbn";

                // 3. Bloqueamos el combo y el checkbox para que sea solo lectura
                cmbDocumento.Enabled = false;
                Prestado.Checked = ej.Prestado;
                Prestado.Enabled = false;


            }
            if (modo.Equals("Baja"))
            {
                Aceptar.BackColor = Color.Red;
            }
            if (modo.Equals("Busqueda"))
            {
                Aceptar.Visible = false;
            }
        }

        // ESTO DEBE SER EL CLICK DE UN BOTÓN "ACEPTAR"
        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (modo.Equals("Alta"))
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
            if (modo.Equals("Baja"))
            {
                // Añadimos confirmación de seguridad
                DialogResult res = MessageBox.Show($"¿Seguro que desea eliminar el ejemplar con código {cod}?",
                                   "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    sesion.BajaEjemplar(cod);
                    MessageBox.Show("Ejemplar eliminado con éxito.");
                    this.Close();
                }
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
