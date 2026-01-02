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
    public partial class BusquedaPrestamo : Form
    {
        private ILNSala sesion;
        private Prestamo prestamoActual;

        public BusquedaPrestamo(ILNSala sesion, string idPrestamo)
        {
            InitializeComponent();
            this.sesion = sesion;

            this.prestamoActual = sesion.GetPrestamoPorId(idPrestamo);

            CargarDatosEncabezado();
            CargarGridEjemplares();
        }

        private void CargarDatosEncabezado()
        {
            textBoxID.Text = prestamoActual.Id;
            textBoxUsuario.Text = prestamoActual.Usuario.Nombre + " (DNI: " + prestamoActual.Usuario.DNI + ")";
            textBoxFecha.Text = prestamoActual.Fecha.ToShortDateString();
            textBoxEstado.Text = prestamoActual.Estado ? "Prestado" : "No prestado";
        }

        private void CargarGridEjemplares()
        {
            var listaVisual = prestamoActual.Ejemplares.Select(e => new {Codigo = e.Codigo,Titulo = e.Documento.Titulo,EstadoDevolucion = e.Prestado ? "PRESTADO" : "DEVUELTO" }).ToList();
            dataGridView1.DataSource = listaVisual;
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un libro de la lista para devolver.");
                return;
            }

            string codigoLibro = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string estadoActual = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            if (estadoActual == "DEVUELTO")
            {
                MessageBox.Show("Este libro ya ha sido devuelto.");
                return;
            }

            DialogResult dr = MessageBox.Show("¿Confirmar devolución del libro?", "Devolución", MessageBoxButtons.YesNo);
            
            if (dr == DialogResult.Yes)
            {
                sesion.DevolverEjemplar(prestamoActual.Id, codigoLibro, DateTime.Now);

                MessageBox.Show("Libro devuelto correctamente.");

                prestamoActual = sesion.GetPrestamoPorId(prestamoActual.Id);
                CargarDatosEncabezado();
                CargarGridEjemplares();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
