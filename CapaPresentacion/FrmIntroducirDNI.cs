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
    public partial class FrmIntroducirDNI : Form
    {
        private ILNPersonal sesionPersonal;
        private string modo;

        public FrmIntroducirDNI(ILNPersonal sesion, string modo)
        {
            InitializeComponent();
            sesionPersonal = sesion;
            this.modo = modo;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (modo.Equals("Alta"))
            {

                Usuario u = sesionPersonal.GetUsuarioPorDni(txtId.Text);
                if (u != null)
                {

                    DialogResult respuesta = MessageBox.Show(
                    "Ya existe un usuario con ese DNI. ¿Quieres introducir otro?",
                    "Usuario existente",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                    if (respuesta == DialogResult.No)
                    {
                        this.Close(); // Se cierra y vuelve al principal 
                    }
                    else
                    {
                        txtId.Clear(); // Limpia el texto para introducir otro [cite: 114]

                    }


                }
                else
                {
                    DarAltaUsuario alta = new DarAltaUsuario(sesionPersonal, txtId.Text,modo);
                    alta.Show();
                    this.Hide();

                }
            }
            if (modo.Equals("Busqueda") || modo.Equals("Baja"))
            {

                Usuario u = sesionPersonal.GetUsuarioPorDni(txtId.Text);
                if (u == null)
                {

                    DialogResult respuesta = MessageBox.Show(
                    "No existe un usuario con ese DNI. ¿Quieres introducir otro?",
                    "Usuario no existente",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                    if (respuesta == DialogResult.No)
                    {
                        this.Close(); // Se cierra y vuelve al principal 
                    }
                    else
                    {
                        txtId.Clear(); // Limpia el texto para introducir otro [cite: 114]
                        txtId.Focus();
                    }


                }
                else
                {
                    DarAltaUsuario alta = new DarAltaUsuario(sesionPersonal, txtId.Text,modo);
                    alta.Show();
                    this.Hide();

                }


            }
            
        }

        private void FrmIntroducirDNI_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
