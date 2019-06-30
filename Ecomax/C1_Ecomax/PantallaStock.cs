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
    public partial class PantallaStock : Form
    {
        PantallaStockControlador PSC;
        Eventos E;
        string vacio = "";
        DataTable Tabla;
        public PantallaStock()
        {
            InitializeComponent();
            PSC = new PantallaStockControlador();
            E = new Eventos(this);
            Tabla = new DataTable();
        }
        private void RellenarCbArt(ComboBox cb) {
            int cant = PSC.ObtenerCantiArt(); 
            List<string> Art=new List<string>();
            Art = PSC.ObtenerArticulos();
            E.RellenarComboxST(cant, cb, Art);
            cb.SelectedIndex = 0;
        }

        private void RellenarCbProveedor(ComboBox cb)
        {
            int cant = PSC.ObtenerCantiProv();
            List<string> Prov = new List<string>();
            Prov = PSC.ObtenerProveedor();
            E.RellenarComboxST(cant, cb, Prov);
            cb.SelectedIndex = 0;
        }

        private void RellenarCbPeso(ComboBox cb)
        {

            List<string> Peso = new List<string>();
            Peso.Add("kg");
            Peso.Add("gr");
            Peso.Add("cm3");
            Peso.Add("lt");
            Peso.Add("ml");
            Peso.Add("u");
            int cant = Peso.Count();
            E.RellenarComboxST(cant, cb, Peso);
            cb.SelectedIndex = 0;
        }
        private void RellenarCbSucursal(ComboBox cb)
        {
            int cant = PSC.ObtenerCantiSuc();
            List<string> Suc = new List<string>();
            Suc = PSC.ObtSucursal();
            E.RellenarComboxST(cant, cb, Suc);
            cb.SelectedIndex = 0;
        }


        private void Btnagregar_producto_Click(object sender, EventArgs e)
        {
            string ProductoST = cbProducto.SelectedItem.ToString();
            string CantST = E.obtener_datos_text(boxCant);
            string SucursalST = cbSucursal.SelectedItem.ToString();
            string PrecioST = E.obtener_datos_text(boxPrecio);
            if (ProductoST != vacio && CantST != vacio && SucursalST != vacio)
            {
                double precio;
                if (PrecioST == vacio)
                {
                    precio = 0;
                }
                else {
                    precio = Convert.ToDouble(PrecioST);
                }
                int cant = Convert.ToInt32(CantST);
                int itemP = cbProducto.SelectedIndex;
                int itemS = cbSucursal.SelectedIndex;
                List<int> IDSuc = new List<int>();
                List<int> IDArt = new List<int>();
                IDSuc = PSC.ObtIDSucr();
                IDArt = PSC.ObtIDArt();
                Console.WriteLine("Precio:" + precio.ToString());
                Console.WriteLine("itemP:" + itemP.ToString());
                Console.WriteLine("itemS:" + itemS.ToString());
                Console.WriteLine("IDSuc:" + IDSuc[itemS].ToString());
                Console.WriteLine("IDArt:" + IDArt[itemP].ToString());

                bool ok = PSC.AgregarArt(IDArt[itemP], cant, precio, IDSuc[itemS]);
                if (ok)
                {
                    E.cartel("Se actualizó la cantidad");
                    clear();
                }
                else
                {
                    E.cartel("ERROR");
                    clear();
                }
            }
            clear();
        }

        private void clear() {
            boxCant.Clear();
            boxNombre.Clear();
            boxPeso.Clear();
            boxPrecio.Clear();
            cbProducto.SelectedIndex = 0;
            cbSucursal.SelectedIndex = 0;
            cbPeso.SelectedIndex = 0;
            cbProveedor.SelectedIndex = 0;
           
        }
        private void Btncrear_producto_Click(object sender, EventArgs e)
        {
            string Nombre = E.obtener_datos_text(boxNombre);
            string PesoST = E.obtener_datos_text(boxPeso);
            string kg = cbPeso.SelectedItem.ToString();
            string Proveedor = cbProveedor.SelectedItem.ToString();

            if (Nombre != vacio && PesoST != vacio && kg != vacio && Proveedor != vacio)
            {
                int Peso = Convert.ToInt32(PesoST);
                int item = cbProveedor.SelectedIndex;
                List<int> IDProv = new List<int>();
                IDProv = PSC.ObtIDProv();
                Console.WriteLine(IDProv[item].ToString());

                int ok = PSC.CrearProducto(Nombre, Peso, kg, IDProv[item]);

                if (ok == 1)
                {
                    E.cartel("Se creo nuevo Producto");
                    cbProducto.Items.Clear();
                    RellenarCbArt(cbProducto);
                    clear();
                }
                else {
                    E.cartel("ERROR");
                    clear();
                }
            }
            else {
                E.cartel("Complete Todos los datos");
                clear();
            }
        }

        private void Actualizar()
        {
            Tabla.Rows.Clear();
            dgProductos.Refresh();
            Tabla = PSC.ObtenerProductoDT();
            dgProductos.DataSource = Tabla;
            dgProductos.Columns[0].HeaderText = "N° Articulo";
            dgProductos.Columns[0].Visible = true;

            dgProductos.Columns[1].HeaderText = "Nombre";
            dgProductos.Columns[1].Visible = true;

            dgProductos.Columns[2].HeaderText = "Peso";
            dgProductos.Columns[2].Visible = true;

            dgProductos.Columns[3].HeaderText = "Medida";
            dgProductos.Columns[3].Visible = true;

            dgProductos.Columns[4].HeaderText = "Cantidad";
            dgProductos.Columns[4].Visible = true;

            dgProductos.Columns[5].HeaderText = "ID_Sucursal";
            dgProductos.Columns[5].Visible = true;


            dgProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
        private void Key_Press(object sender, KeyPressEventArgs e)
        {

            int key = E.Key_press_global(sender, e);
            if (key == 1)
            {
                if (btnagregar_producto.Focused)
                {
                   Btnagregar_producto_Click(sender, e);
                }
                else if (btncrear_producto.Focused)
                {
                    Btncrear_producto_Click(sender,e);
                }
                else if (btnActualizar.Focused)
                {
                    BtnActualizar_Click(sender, e);
                }
                else {
                    E.tab(sender, e);
                }
                
            }

        }


        private void Mover(object sender, MouseEventArgs e)
        {
            E.Mover_pantalla(sender, e);
        }


        private void PantallaStock_Load(object sender, EventArgs e)
        {
            RellenarCbArt(cbProducto);
            RellenarCbSucursal(cbSucursal);
            RellenarCbPeso(cbPeso);
            RellenarCbProveedor(cbProveedor);
            Actualizar();
            labelEmpleado.Text = UserGlobal.DATOS.Apellido + " " + UserGlobal.DATOS.Nombre;

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            E.CerrarSesion(sender, e);
        }
    }
}
