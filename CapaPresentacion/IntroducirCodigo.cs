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
using static System.Collections.Specialized.BitVector32;

namespace CapaPresentacion
{
    public partial class IntroducirCodigo : Form
    {
        private ILNAdquisiciones sesion;
        private string modo;
        public IntroducirCodigo(ILNAdquisiciones sesion,string modo)
        {
            InitializeComponent();
            this.sesion = sesion;
            this.modo = modo;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            Ejemplar ej = sesion.GetEjemplarPorCodigo(txtCodigo.Text);
            if (modo.Equals("Alta"))
            {
                if (ej != null)
                {
                    DialogResult respuesta = MessageBox.Show(
                    "Ya existe un ejemplar con ese codigo. ¿Quieres introducir otro?",
                    "Ejemplar existente",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                    if (respuesta == DialogResult.No)
                    {
                        this.Close(); // Se cierra y vuelve al principal 
                    }
                    else
                    {
                        txtCodigo.Clear(); // Limpia el texto para introducir otro [cite: 114]
                        txtCodigo.Focus();

                    }

                }
                else
                {
                    AltaEjemplar alta = new AltaEjemplar(sesion, txtCodigo.Text,"Alta");
                    alta.Show();
                }
            }
            if (modo.Equals("Baja"))
            {
                if (ej == null)
                {
                    DialogResult respuesta = MessageBox.Show(
                    "No existe un ejemplar con ese codigo. ¿Quieres introducir otro?",
                    "Ejemplar no existente",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                    if (respuesta == DialogResult.No)
                    {
                        this.Close(); // Se cierra y vuelve al principal 
                    }
                    else
                    {
                        txtCodigo.Clear(); // Limpia el texto para introducir otro [cite: 114]
                        txtCodigo.Focus();

                    }

                }
                else
                {
                    AltaEjemplar baja = new AltaEjemplar(sesion, txtCodigo.Text,"Baja");
                    baja.Show();
                }
            }
            if (modo.Equals("Busqueda"))
            {
                if (ej == null)
                {
                    DialogResult respuesta = MessageBox.Show(
                    "No existe un ejemplar con ese codigo. ¿Quieres introducir otro?",
                    "Ejemplar no existente",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                    if (respuesta == DialogResult.No)
                    {
                        this.Close(); // Se cierra y vuelve al principal 
                    }
                    else
                    {
                        txtCodigo.Clear(); // Limpia el texto para introducir otro [cite: 114]
                        txtCodigo.Focus();

                    }

                }
                else
                {
                    AltaEjemplar baja = new AltaEjemplar(sesion, txtCodigo.Text, "Busqueda");
                    baja.Show();
                }
            }
        }
    }
}
