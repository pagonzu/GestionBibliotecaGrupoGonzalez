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
    public partial class FrmPSala : FrmPrincipal
    {
        private ILNSala sesion;
        public FrmPSala():base()
        {
            InitializeComponent();
        }
        public FrmPSala(ILNPersonal n) : base(n)
        {
            InitializeComponent();
            sesion = (ILNSala)n;
        }


    }
}
