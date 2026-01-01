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
    public partial class BusquedaPorDNI : Form
    {
        private ILNPersonal sesion;
        private BindingSource miBindingSource = new BindingSource();
        public BusquedaPorDNI(ILNPersonal p)
        {
            InitializeComponent();
            sesion = p;
            // 2. Le damos la partitura al director (La lista de usuarios de la lógica)
            miBindingSource.DataSource = sesion.GetTodosUsuarios();

            // 3. Conectamos el ComboBox al Director
            // Queremos que muestre los DNIs de la lista
            cbDNI.DataSource = miBindingSource;
            cbDNI.DisplayMember = "Dni";

            // 4. CREAMOS EL DATABINDING (El hilo invisible para el nombre)
            // "Text" -> Queremos cambiar el texto del cuadro
            // miBindingSource -> El origen es nuestro director de orquesta
            // "Nombre" -> Queremos que saque el dato de la propiedad Nombre del usuario actual
            txtNombre.DataBindings.Add(new Binding("Text", miBindingSource, "Nombre", true));
        }

        
    }
}
