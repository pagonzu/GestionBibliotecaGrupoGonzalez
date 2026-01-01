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
using static System.Collections.Specialized.BitVector32;

namespace CapaPresentacion
{
    public partial class UnoAUnoUsuarios : Form
    {
        BindingSource miDirector = new BindingSource();
        public UnoAUnoUsuarios(ILNPersonal sesion)
        {
            InitializeComponent();
            // 1. Cargamos los datos en el director
            miDirector.DataSource = sesion.GetTodosUsuarios();

            // 2. CONECTAMOS EL NAVEGADOR (El mando al director)
            // Esto hace que las flechas muevan la lista del director
            bindingNavigator1.BindingSource = miDirector;

            // 3. CREAMOS LOS DATABINDINGS (Los hilos invisibles)
            // Enlazamos la propiedad "Text" de cada cuadro al director 
            txtDni.DataBindings.Add(new Binding("Text", miDirector, "Dni", true));
            txtNombre.DataBindings.Add(new Binding("Text", miDirector, "Nombre", true));
        }


    }
}
