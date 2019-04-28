using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ecomax
{
    public partial class Modo_Pago : Form
    {
        Pantalla_caja p_caja;
        private object[] RegistrarVenta;
        private object[] DescuentaCantidad;
        private long Ticket;
        private double Total;
        
        public Modo_Pago()
        {
            InitializeComponent();
            p_caja = new Pantalla_caja();
        }

        private void Modo_Pago_Shown(object sender, EventArgs e)
        {
            /* DescuentaCantidad
             * 0toN = (int)cant_descontar;  */
            /* RegistrarVenta
             * 0 = (long)Ticket;
             * 1 = (double) Total;
             * 2toN = (int)n_art ; */
            int cant = p_caja.set_cant();
            RegistrarVenta = new object[cant];
            DescuentaCantidad = new object[cant - 2];
            RegistrarVenta = p_caja.Ob_registrarVenta();
            DescuentaCantidad = p_caja.Ob_DescuentaCantidad();
            labelPrecio_total.Text = RegistrarVenta[1].ToString();
            labelTicket.Text = RegistrarVenta[0].ToString();


        }
    }
}
