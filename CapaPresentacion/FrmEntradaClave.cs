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
    public partial class FrmEntradaClave : Form
    {
        private ILNPersonal sesion;
        private string modo; // "Alta", "Baja", "Busqueda"
        private string tipo; // "Usuario", "Documento", "Ejemplar"

        public FrmEntradaClave(ILNPersonal sesion, string modo, string tipo)
        {
            InitializeComponent();
            this.sesion = sesion;
            this.modo = modo;
            this.tipo = tipo;

            // Personalizamos el texto según el tipo
            this.Text = "Introducir " + tipo;
            lblEtiqueta.Text = "Introduce el " + tipo + ":";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            object encontrado = null;
            string clave = txtClave.Text;

            // 1. Buscamos según el tipo usando la sesión [cite: 2025-12-21]
            if (tipo == "Usuario") encontrado = sesion.GetUsuarioPorDni(clave);
            else if (tipo == "Documento") encontrado = (sesion as ILNAdquisiciones).GetDocumentoPorIsbn(clave);
            else if (tipo == "Ejemplar") encontrado = (sesion as ILNAdquisiciones).GetEjemplarPorCodigo(clave);

            // 2. Lógica de validación genérica
            if (modo == "Alta" && encontrado != null)
            {
                MostrarError("Ya existe este " + tipo + ". ¿Quieres probar con otro?");
            }
            else if ((modo == "Baja" || modo == "Busqueda") && encontrado == null)
            {
                MostrarError("No existe este " + tipo + ". ¿Quieres probar con otro?");
            }
            else
            {
                // 3. Abrimos el formulario final
                AbrirFormularioFinal(clave);
            }
        }

        private void AbrirFormularioFinal(string clave)
        {
            Form proximo = null;
            if (tipo == "Usuario") proximo = new DarAltaUsuario(sesion, clave, modo);
            else if (tipo == "Documento") proximo = new AltaDocumento(sesion as ILNAdquisiciones, clave, modo);
            else if (tipo == "Ejemplar") proximo = new AltaEjemplar(sesion as ILNAdquisiciones, clave, modo);

            if (proximo != null)
            {
                proximo.MdiParent = this.MdiParent; // Mantenemos el estilo MDI
                proximo.Show();
                this.Close();
            }
        }

        private void MostrarError(string mensaje)
        {
            DialogResult res = MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) this.Close();
            else txtClave.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
