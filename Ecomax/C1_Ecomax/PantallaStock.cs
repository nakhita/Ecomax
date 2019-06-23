using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C2_Controlador;

namespace C1_Ecomax
{
    public partial class PantallaStock : Form
    {
        PantallaStockControlador PSC;
        public PantallaStock()
        {
            InitializeComponent();
            PSC = new PantallaStockControlador();
        }

        private void PantallaStock_Load(object sender, EventArgs e)
        {
            int canti = PSC.ObtenerCanti();
            string[] Box = new string[canti];
            Box = PSC.RellenarComboBox();
        }
    }
}
