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
    public partial class UnoAUnoDocumentos : Form
    {
        BindingSource miDirector = new BindingSource();

        public UnoAUnoDocumentos(ILNAdquisiciones sesion)
        {
            InitializeComponent();

            miDirector.DataSource = sesion.GetTodosDocumentos();

            bindingNavigator1.BindingSource = miDirector;


            textBoxISBN.DataBindings.Add(new Binding("Text", miDirector, "ISBN", true));
            textBoxTitulo.DataBindings.Add(new Binding("Text", miDirector, "Titulo", true));
            textBoxAutor.DataBindings.Add(new Binding("Text", miDirector, "Autor", true));
            textBoxEditorial.DataBindings.Add(new Binding("Text", miDirector, "Editorial", true));
            textBoxAño.DataBindings.Add(new Binding("Text", miDirector, "AñoEdicion", true));
        }
    }
}

