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
        DataTable dt;
        Eventos E;
        bool esNuevo = true;

        public PantallaJefe()
        {
            InitializeComponent();
            Emp_Controlador = new EmpleadoControlador();
            dt = new DataTable();
            E = new Eventos(this);
        }

        private void Cargar_Empleado()
        {
            dt.Rows.Clear();
            dgEmpleados.Columns.Clear();
            dgEmpleados.Refresh();
            dt = Emp_Controlador.Obtener_Empleados();
            dgEmpleados.Refresh();
            dgEmpleados.DataSource = dt;
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

            dgEmpleados.Columns[8].HeaderText = "Password";
            dgEmpleados.Columns[8].Visible = true;

            DataGridViewButtonColumn dgBtneditar = new DataGridViewButtonColumn();
            dgBtneditar.Name = "Editar";
            dgBtneditar.Text = "Editar";
            dgBtneditar.UseColumnTextForButtonValue = true;
            int columnIndex = 9;
            if (dgEmpleados.Columns["Editar"] == null)
            {
                dgEmpleados.Columns.Insert(columnIndex, dgBtneditar);
            }

            DataGridViewButtonColumn dgBtnEliminar = new DataGridViewButtonColumn();
            dgBtnEliminar.Name = "Eliminar";
            dgBtnEliminar.Text = "Eliminar";
            dgBtnEliminar.UseColumnTextForButtonValue = true;
            columnIndex = 10;
            if (dgEmpleados.Columns["Eliminar"] == null)
            {
                dgEmpleados.Columns.Insert(columnIndex, dgBtnEliminar);
            }

            dgEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void Cargar_Categorias()
        {
            List<ComboBoxItem> categorias = Emp_Controlador.Obtener_Categorias();

            cbRol.Items.Clear();
            foreach (ComboBoxItem item in categorias)
            {
                cbRol.Items.Add(item);
            }

            cbRol.SelectedIndex = 0;
        }

        private void Cargar_Sucursales()
        {
            List<ComboBoxItem> sucursales = Emp_Controlador.Obtener_Sucursales();

            cbSucursal.Items.Clear();
            foreach (ComboBoxItem item in sucursales)
            {
                cbSucursal.Items.Add(item);
            }

            cbSucursal.SelectedIndex = 0;
        }
        private void Key_Press(object sender, KeyPressEventArgs e)
        {
            int key = E.Key_press_global(sender, e);
            if (key == 1)
            {
                BtnGuardar_Click(sender,e);
            }

        }
        private void Limpiar()
        {
            txtLegajo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtPassword.Text = "";
            cbSucursal.SelectedIndex = 0;
            cbRol.SelectedIndex = 0;
        }

        private void Mover(object sender, MouseEventArgs e)
        {
            E.Mover_pantalla(sender, e);
        }

        private void PantallaJefe_Load(object sender, EventArgs e)
        {
            Cargar_Empleado();
            Cargar_Categorias();
            Cargar_Sucursales();
            Limpiar();
            esNuevo = true;
            labelEmpleado.Text = UserGlobal.DATOS.Apellido + " " + UserGlobal.DATOS.Nombre;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            Empleado Emp = new Empleado();
            Emp.Legajo = txtLegajo.Text;
            Emp.Nombre = txtNombre.Text;
            Emp.Apellido = txtApellido.Text;
            Emp.ID_Categoria = (cbRol.SelectedItem as ComboBoxItem).Value;
            Emp.ID_Sucursal = (cbSucursal.SelectedItem as ComboBoxItem).Value;
            Emp.Password = txtPassword.Text;

            StringBuilder Validacion = Emp_Controlador.Validar_Empleado(Emp, esNuevo);

            if (Validacion.Length > 0)
            {
                E.cartel(Validacion.ToString());
            } else
            {
                if (esNuevo)
                {
                    resultado = Emp_Controlador.Insertar_Empleado(Emp);
                }
                else
                {
                    resultado = Emp_Controlador.Actualizar_Empleado(Emp);
                }

                if (resultado == 1)
                {
                    Limpiar();
                    E.cartel("Se guardo con exito");
                    Cargar_Empleado();
                }
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            StringBuilder filter = new StringBuilder();
            filter.Append(string.Format("CONVERT({0}, System.String) LIKE '%{1}%'", "Legajo", txtBuscar.Text));
            filter.Append(string.Format(" OR {0} LIKE '%{1}%'", "Nombre", txtBuscar.Text));
            filter.Append(string.Format(" OR {0} LIKE '%{1}%'", "Apellido", txtBuscar.Text));
            filter.Append(string.Format(" OR {0} LIKE '%{1}%'", "NombreCategoria", txtBuscar.Text));
            filter.Append(string.Format(" OR {0} LIKE '%{1}%'", "NombreSucursal", txtBuscar.Text));
            filter.Append(string.Format(" OR {0} LIKE '%{1}%'", "LocalidadSucursal", txtBuscar.Text));

            dt.DefaultView.RowFilter = filter.ToString();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgEmpleados.Columns["Editar"].Index)
            {
                DataRow dr = dt.Rows[e.RowIndex];
                int legajo = (int) dr[0];
                txtLegajo.Text = dr[0].ToString();
                txtNombre.Text = dr[1].ToString();
                txtApellido.Text = dr[2].ToString();
                txtPassword.Text = dr[8].ToString();

                ComboBoxItem itemRol = new ComboBoxItem();
                itemRol.Value = dr[3].ToString();
                cbRol.SelectedItem = itemRol;

                ComboBoxItem itemSucursal = new ComboBoxItem();
                itemSucursal.Value = dr[5].ToString();
                cbSucursal.SelectedItem = itemSucursal;

                esNuevo = false;
                txtLegajo.Enabled = false;
                E.cartel("Se cargaron los datos del empleado con legajo : " + legajo);
            } else if(e.ColumnIndex == dgEmpleados.Columns["Eliminar"].Index)
            {
                int legajo = (int) dt.Rows[e.RowIndex][0];
                int resultado = Emp_Controlador.Eliminar_Empleado(legajo);
                E.cartel("Se elimino al empleado con legajo : " + legajo);
                Cargar_Empleado();
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            txtLegajo.Enabled = true;
            esNuevo = true;
            Limpiar();
        }
    }
}
