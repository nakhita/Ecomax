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
        public PantallaStock()
        {
            InitializeComponent();
            PSC = new PantallaStockControlador();
            E = new Eventos(this);
        }
        private void RellenarCbArt(ComboBox cb) {
            int cant = PSC.ObtenerCantiArt(); 
            List<string> Art=new List<string>();
            Art = PSC.ObtenerArticulos();
            E.RellenarComboxST(cant, cb, Art);
            cb.SelectedIndex = 0;
        }

        //<----------------------////
        private void RellenarCbProveedor(ComboBox cb)
        {
            int cant = PSC.ObtenerCantiProv();
            List<string> Art = new List<string>();
            Art = PSC.ObtenerProveedor();
            E.RellenarComboxST(cant, cb, Art);
            cb.SelectedIndex = 0;
        }

        //<----------------------////
        private void RellenarCbPeso(ComboBox cb)
        {

            List<string> Art = new List<string>();
            Art.Add("kg");
            Art.Add("gr");
            Art.Add("cm3");
            Art.Add("lt");
            Art.Add("ml");
            int cant = Art.Count();
            E.RellenarComboxST(cant, cb, Art);
            cb.SelectedIndex = 0;
        }
       
        private void Btnhacer_pedido_Click(object sender, EventArgs e)
        {
            string Producto = cbProducto.SelectedItem.ToString();
            int Cant = Convert.ToInt32(E.obtener_datos_text(boxCant));
            string Proveedor = cbProveedor.SelectedItem.ToString();
            //Se "manda por email" Fuera del alcance del proyecto
            E.cartel("Se hizo un pedido a" + Proveedor + " Por " + Cant + " " + Producto);
            clear();
        }

        private void clear() {
            boxCant.Clear();
            boxNombre.Clear();
            boxPeso.Clear();
            cbProducto.SelectedIndex = 0;
            cbProveedor.SelectedIndex = 0;
            cbPeso.SelectedIndex = 0;
            cbProveedorNP.SelectedIndex = 0;
           
        }
        private void Btncrear_producto_Click(object sender, EventArgs e)
        {
            string Nombre = E.obtener_datos_text(boxNombre);
            string PesoST = E.obtener_datos_text(boxPeso);
            string kg = cbPeso.SelectedItem.ToString();
            string Proveedor = cbProveedorNP.SelectedItem.ToString();

            if (Nombre != vacio && PesoST != vacio && kg != vacio && Proveedor != vacio)
            {
                int Peso = Convert.ToInt32(PesoST);
                int item = cbProveedorNP.SelectedIndex;
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

        private void Key_Press(object sender, KeyPressEventArgs e)
        {

            int key = E.Key_press_global(sender, e);
            if (key == 1)
            {
                if (btnhacer_pedido.Focused)
                {
                   Btnhacer_pedido_Click(sender, e);
                }
                else if (btncrear_producto.Focused)
                {
                    Btncrear_producto_Click(sender,e);
                }
                else if (btnActualizar.Focused)
                {

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
            RellenarCbProveedor(cbProveedor);
            RellenarCbPeso(cbPeso);
            RellenarCbProveedor(cbProveedorNP);
            labelEmpleado.Text = UserGlobal.DATOS.Apellido + " " + UserGlobal.DATOS.Nombre;

        }


    }
}
