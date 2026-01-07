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
    public partial class AltaPrestamo : Form
    {
        private LNSala sesion;
        private List<Ejemplar> cesta = new List<Ejemplar>();

        public AltaPrestamo(LNSala sesion)
        {
            InitializeComponent();
            this.sesion = sesion;

            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            List<Usuario> usuarios = sesion.GetTodosUsuarios();

            comboBox1.DataSource = usuarios;
            comboBox1.DisplayMember = "Dni";
            comboBox1.ValueMember = "Dni";
        }


        private void btnAnadir_Click(object sender, EventArgs e)
        {
            string codigo = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Introduce un código de ejemplar.");
                return;
            }

            Ejemplar ej = sesion.GetEjemplarPorCodigo(codigo);

            if (ej == null)
            {
                MessageBox.Show("No existe ningún ejemplar con ese código.");
                textBox2.SelectAll();
                return;
            }

            if (ej.Prestado)
            {
                MessageBox.Show("Este ejemplar está prestado.");
                return;
            }

            if (ej.Prestado)
            {
                MessageBox.Show("Este ejemplar está dado de baja.");
                return;
            }

            if (cesta.Any(x => x.Codigo == ej.Codigo))
            {
                MessageBox.Show("Ya has añadido este ejemplar.");
                return;
            }

            cesta.Add(ej);
            ActualizarListaVisual();

            textBox2.Clear();
            textBox2.Focus();
        }

        private void ActualizarListaVisual()
        {
            listBox1.Items.Clear();
            foreach (Ejemplar ej in cesta)
            {
                listBox1.Items.Add("[" + ej.Codigo + "] - " + ej.Documento.Titulo);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("No has seleccionado un usuario.");
                return;
            }

            if (cesta.Count == 0)
            {
                MessageBox.Show("Añade al menos un libro.");
                return;
            }

            try
            {
                Usuario usuarioSeleccionado = (Usuario)comboBox1.SelectedItem;

                String idPrestamo = "P-" + DateTime.Now.ToString("yyyyMMddHHmmss");
                Prestamo nuevoPrestamo = new Prestamo(idPrestamo,DateTime.Now,true,(PersonalSala)sesion.PersonalLogueado,usuarioSeleccionado,cesta);
                sesion.AltaPrestamo(nuevoPrestamo);

                MessageBox.Show("Préstamo realizado.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
