using LogicaNegocio;
using ModeloDominio;
using ModeloDominio.EditorDeTexto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class AltaDocumento : Form
    {
        private ILNAdquisiciones sesion;
        private string isbn;
        private string modo;
        public AltaDocumento(ILNAdquisiciones sesion,string isbn,string modo)
        {
            InitializeComponent();
            this.isbn = isbn;
            this.sesion = sesion;
            txtISBN.Text = isbn;
            this.modo = modo;
            txtISBN.Enabled = false;
            if (modo.Equals("Busqueda") || modo.Equals("Baja")) {
                Documento d =sesion.GetDocumentoPorIsbn(txtISBN.Text);
                txtAutor.Text = d.Autor;
                txtAutor.ReadOnly=true;
                txtAñoEdicion.Text = d.AñoEdicion.ToString();
                txtAñoEdicion.ReadOnly=true;
                txtEditorial.Text = d.Editorial;
                txtEditorial.ReadOnly=true;
                txtTitulo.Text = d.Titulo;
                txtTitulo.ReadOnly=true;
                if(d is AudioLibro)
                {
                    Audiolibro.Checked = true;
                    
                    // Es un audiolibro: mostramos duración y ocultamos páginas
                    AudioLibro a = (AudioLibro)d;
                    txtDuracion.Text = a.DuracionSegundos.ToString();
                    txtDuracion.Visible = true;
                    Duracion.Visible = true;
                    
                    txtDuracion.ReadOnly = true;
                }
                else if (d is Libro)
                {
                    Libro.Checked = true;
                    txtDuracion.Visible = false;
                    Duracion.Visible = false;
                }
            }
            if (modo.Equals("Busqueda"))
            {
                Dar.Visible = false;
                Añadir.Visible = false;
            }
            if (modo.Equals("Baja"))
            {
                Dar.Text = "Eliminar Documento";
                Dar.BackColor = Color.Red;
                Añadir.Visible = false;
            }
        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            FrmEntradaClave i = new FrmEntradaClave(sesion, "Alta","Documento");
            i.ShowDialog();
        }

        private void Dar_Click(object sender, EventArgs e)
        {
            if (modo.Equals("Alta")) {
                // 1. PRIMERO validamos. Si falta algo, "return" para la ejecución.
                if (!ValidarCampos())
                {
                    return;
                }

                // 2. Usamos un bloque try-catch por si meten letras donde van números
                try
                {
                    if (Libro.Checked)
                    {
                        // Ahora es seguro hacer el parse porque sabemos que no está vacío
                        Libro l = new Libro(txtISBN.Text, int.Parse(txtAñoEdicion.Text), txtTitulo.Text, txtAutor.Text, txtEditorial.Text);
                        sesion.AltaLibro(l);
                    }
                    else
                    {
                        // Aquí el validador ya comprobó que txtDuracion tiene algo
                        AudioLibro a = new AudioLibro(txtISBN.Text, int.Parse(txtAñoEdicion.Text), txtTitulo.Text, txtAutor.Text, txtEditorial.Text, "Audiolibro", int.Parse(txtDuracion.Text));
                        sesion.AltaAudioLibro(a);
                    }

                    MessageBox.Show("Documento guardado con éxito.");
                    this.Close();
                }
                catch (FormatException)
                {
                    // Esto captura si escriben "hola" en el año o la duración
                    MessageBox.Show("El año y la duración deben ser números válidos.", "Error de formato");
                }
            }
            if (modo.Equals("Baja"))
            {
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar este documento? Se eliminarán todos sus ejemplares.",
                    "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    sesion.BajaLibro(txtISBN.Text); // La lógica se encarga de si es Libro o AudioLibro
                    this.Close();
                }
                return;
            }

        }



        private void Audiolibro_CheckedChanged(object sender, EventArgs e)
        {
            // La visibilidad depende directamente de si está chequeado o no
            txtDuracion.Visible = Audiolibro.Checked;
            Duracion.Visible = Audiolibro.Checked;
        }

        private void Libro_CheckedChanged(object sender, EventArgs e)
        {
            // Si marcas libro, asegúrate de que lo de audiolibro se oculte
            if (Libro.Checked)
            {
                txtDuracion.Visible = false;
                Duracion.Visible = false;
            }
        }
        private bool ValidarCampos()
        {
            // 1. Comprobamos los campos comunes a todos los documentos
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtAutor.Text) ||
                string.IsNullOrWhiteSpace(txtEditorial.Text) ||
                string.IsNullOrWhiteSpace(txtAñoEdicion.Text))
            {
                MessageBox.Show("Todos los campos generales (Título, Autor, Editorial, Año) son obligatorios.", "Faltan datos");
                return false;
            }

            
            

            if (Audiolibro.Checked && string.IsNullOrWhiteSpace(txtDuracion.Text))
            {
                MessageBox.Show("Debes introducir la duración del audiolibro.", "Faltan datos");
                return false;
            }

            return true; // Si llega aquí, todo está relleno correctamente
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
