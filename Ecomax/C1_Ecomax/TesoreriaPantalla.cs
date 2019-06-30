using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C2_Controlador;
using C4_Class;

namespace C1_Ecomax
{
    public partial class TesoreriaPantalla : Form
    {
        Eventos E;
        DataTable Tabla;
        TesoreriaControlador TC;

        public TesoreriaPantalla()
        {
            InitializeComponent();
            Tabla = new DataTable();
            E = new Eventos(this);
            TC = new TesoreriaControlador();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            StringBuilder filter = new StringBuilder();
            filter.Append(string.Format("CONVERT({0}, System.String) LIKE '%{1}%'", "Ticket", txtBuscar.Text));
            filter.Append(string.Format(" OR CONVERT({0}, System.String) LIKE '%{1}%'", "monto", txtBuscar.Text));
            filter.Append(string.Format(" OR CONVERT({0}, System.String) LIKE '%{1}%'", "n_comp", txtBuscar.Text));
            filter.Append(string.Format(" OR CONVERT({0}, System.String) LIKE '%{1}%'", "nombre", txtBuscar.Text));
            filter.Append(string.Format(" OR CONVERT({0}, System.String) LIKE '%{1}%'", "fecha", txtBuscar.Text));

            Tabla.DefaultView.RowFilter = filter.ToString();
        }
        private void Key_Press(object sender, KeyPressEventArgs e)
        {
            E.Key_press_global(sender, e);
            
        }

            private void Actualizar()
        {
            Tabla.Rows.Clear();
            dgReporte.Refresh();
            Tabla = TC.ObtenerReporteDT();
            dgReporte.DataSource = Tabla;
            dgReporte.Columns[0].HeaderText = "N° Ticket";
            dgReporte.Columns[0].Visible = true;

            dgReporte.Columns[1].HeaderText = "Monto";
            dgReporte.Columns[1].Visible = true;

            dgReporte.Columns[2].HeaderText = "Comprobante Tarjeta";
            dgReporte.Columns[2].Visible = true;

            dgReporte.Columns[3].HeaderText = "Modo de Pago";
            dgReporte.Columns[3].Visible = true;

            dgReporte.Columns[4].HeaderText = "Fecha";
            dgReporte.Columns[4].Visible = true;

            dgReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void Mover(object sender, MouseEventArgs e)
        {
            E.Mover_pantalla(sender, e);
        }
        private void TesoreriaPantalla_Load(object sender, EventArgs e)
        {
            Actualizar();
            labelEmpleado.Text = UserGlobal.DATOS.Apellido + " " + UserGlobal.DATOS.Nombre;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            E.CerrarSesion(sender, e);
        }
    }
}
