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
    public partial class PantallaJefe : Form
    {
        EmpleadoControlador Emp_Controlador;
        Eventos E;

        public PantallaJefe()
        {
            InitializeComponent();
            Emp_Controlador = new EmpleadoControlador();
            E = new Eventos(this);
        }

        private void Cargar_Empleado()
        {
            dgEmpleados.Rows.Clear();
            dgEmpleados.Refresh();
            dgEmpleados.DataSource = Emp_Controlador.Obtener_Empleados();
            dgEmpleados.Columns[0].HeaderText = "Legajo";
            dgEmpleados.Columns[0].Visible = true;

            dgEmpleados.Columns[1].HeaderText = "Nombre";
            dgEmpleados.Columns[1].Visible = true;

            dgEmpleados.Columns[2].HeaderText = "Apellido";
            dgEmpleados.Columns[2].Visible = true;

            dgEmpleados.Columns[3].HeaderText = "ID_Categoria";
            dgEmpleados.Columns[3].Visible = false;

            dgEmpleados.Columns[4].HeaderText = "Categoria";
            dgEmpleados.Columns[4].Visible = true;

            dgEmpleados.Columns[5].HeaderText = "ID_Sucursal";
            dgEmpleados.Columns[5].Visible = false;

            dgEmpleados.Columns[6].HeaderText = "Sucursal";
            dgEmpleados.Columns[6].Visible = true;

            dgEmpleados.Columns[7].HeaderText = "Localidad";
            dgEmpleados.Columns[7].Visible = true;

            dgEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void Mover(object sender, MouseEventArgs e)
        {
            E.Mover_pantalla(sender, e);
        }

        private void PantallaJefe_Load(object sender, EventArgs e)
        {
            Cargar_Empleado();
            labelEmpleado.Text = UserGlobal.DATOS.Apellido + " " + UserGlobal.DATOS.Nombre;
        }

    }
}
