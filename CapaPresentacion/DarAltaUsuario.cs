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
    public partial class DarAltaUsuario : Form
    {
        private ILNPersonal sesion;
        private string modo;
        public DarAltaUsuario(ILNPersonal sesion, string dni,string modo)
        {
            InitializeComponent();
            this.sesion = sesion;
            this.modo = modo;
            txtDNI.Text = dni;
            txtDNI.Enabled = false;

            // CONFIGURACIÓN INICIAL SEGÚN EL MODO
            if (modo.Equals("Busqueda") || modo.Equals("Baja"))
            {
                // 1. Buscamos al usuario para mostrar su nombre inmediatamente
                Usuario u = sesion.GetUsuarioPorDni(dni);
                if (u != null)
                {
                    txtNombre.Text = u.Nombre;
                    txtNombre.Enabled = false; // No se puede editar en búsqueda/baja
                }

                if (modo.Equals("Busqueda"))
                {
                    Aceptar.Visible = false; // En búsqueda solo miramos
                    this.Text = "Consulta de Usuario";
                }
                else if (modo.Equals("Baja"))
                {
                    Aceptar.Text = "Dar de Baja"; // Cambiamos el texto del botón
                    this.Text = "Baja de Usuario";
                }
            }
        }

        private void DarAltaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {


            if (modo.Equals("Alta"))
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {

                    MessageBox.Show("Debes introducir un nombre para el usuario", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtNombre.Focus(); // Devolvemos el foco al campo para que escriba
                    return; // Detenemos la ejecución aquí
                }
                else
                {
                    Usuario u = new Usuario(txtDNI.Text, txtNombre.Text);
                    sesion.AltaUsuario(u);
                    // Notificar al usuario y cerrar
                    MessageBox.Show("Usuario dado de alta correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
            }
            if (modo.Equals("Baja"))
            {
                // El PDF exige un mensaje de aviso antes de borrar
                DialogResult result = MessageBox.Show(
                    "¿Está seguro de que desea eliminar al usuario?",
                    "Aviso",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    
                    sesion.BajaUsuario(txtDNI.Text);

                    MessageBox.Show("Usuario eliminado correctamente.");
                    this.Close();
                }
            }



        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
