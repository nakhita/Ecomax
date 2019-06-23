using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C4_Class;

namespace C1_Ecomax
{
    public partial class TesoreriaPantalla : Form
    {
        public TesoreriaPantalla()
        {
            InitializeComponent();
        }

        private void TesoreriaPantalla_Load(object sender, EventArgs e)
        {
            labelEmpleado.Text = UserGlobal.DATOS.Apellido + " " + UserGlobal.DATOS.Nombre;
        }
    }
}
