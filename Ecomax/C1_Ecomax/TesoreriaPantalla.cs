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
        DataTable TablaGeneral;
        DataTable TablaDetalle;
        TesoreriaControlador TC;

        public TesoreriaPantalla()
        {
            InitializeComponent();
            TablaGeneral = new DataTable();
            TablaDetalle = new DataTable();
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

            TablaGeneral.DefaultView.RowFilter = filter.ToString();
        }
        private void Key_Press(object sender, KeyPressEventArgs e)
        {
            E.Key_press_global(sender, e);
            
        }

            private void Actualizar()
        {
            TablaGeneral.Rows.Clear();
            dgReporte.Refresh();
            TablaGeneral = TC.ObtenerReporteDT();
            dgReporte.DataSource = TablaGeneral;
            dgReporte.DataSource = TablaGeneral;
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

            DataGridViewButtonColumn dgBtneditar = new DataGridViewButtonColumn();
            dgBtneditar.Name = "Detalle";
            dgBtneditar.Text = "Ver";
            dgBtneditar.UseColumnTextForButtonValue = true;
            dgBtneditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            int columnIndex = 5;
            if (dgReporte.Columns["Ver"] == null)
            {
                dgReporte.Columns.Insert(columnIndex, dgBtneditar);
            }

            dgReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgReporte.Columns["Detalle"].Index)
            {
                BindingManagerBase bm = dgReporte.BindingContext[dgReporte.DataSource, dgReporte.DataMember];
                DataRow dr = ((DataRowView)bm.Current).Row;
                long ticket = (long)dr[0];

                TablaDetalle.Rows.Clear();
                dgDetalle.Refresh();
                TablaDetalle = TC.ObtenerDetalleDT(ticket);
                dgDetalle.DataSource = TablaDetalle;
                dgDetalle.DataSource = TablaDetalle;

                dgDetalle.Columns[0].HeaderText = "N° Articulo";
                dgDetalle.Columns[0].Visible = true;

                dgDetalle.Columns[1].HeaderText = "Descripción";
                dgDetalle.Columns[1].Visible = true;

                dgDetalle.Columns[2].HeaderText = "$xUnidad";
                dgDetalle.Columns[2].Visible = true;

                dgDetalle.Columns[3].HeaderText = "Cantidad";
                dgDetalle.Columns[3].Visible = true;

                dgDetalle.Columns[4].HeaderText = "Total";
                dgDetalle.Columns[4].Visible = true;

                dgDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                E.cartel("Se cargaron el detalle del ticket : " + ticket);
            }
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
