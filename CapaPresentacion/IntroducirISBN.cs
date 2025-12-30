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
    public partial class IntroducirISBN : Form
    {
        private ILNAdquisiciones sesion;
        private string modo;
        public IntroducirISBN(ILNAdquisiciones sesion,string modo)
        {
            InitializeComponent();
            this.sesion = sesion;
            this.modo = modo;
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            Documento d = sesion.GetDocumentoPorIsbn(txtISBN.Text);
            if (modo.Equals("Alta"))
            {
                if (d != null)
                {
                    DialogResult respuesta = MessageBox.Show(
                    "Ya existe un documento con ese ISBN. ¿Quieres introducir otro?",
                    "Documento existente",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                    if (respuesta == DialogResult.No)
                    {
                        this.Close(); // Se cierra y vuelve al principal 
                    }
                    else
                    {
                        txtISBN.Clear(); // Limpia el texto para introducir otro [cite: 114]
                        txtISBN.Focus();

                    }

                }
                else {
                    AltaDocumento alta = new AltaDocumento(sesion, txtISBN.Text); 
                    alta.Show();
                }
                }

            }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
