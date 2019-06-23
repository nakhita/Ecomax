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
        private void RellenarCbSucursal(ComboBox cb)
        {
            int cant = PSC.ObtenerCantiSuc();
            List<string> Art = new List<string>();
            Art = PSC.ObtSucursal();
            E.RellenarComboxST(cant, cb, Art);
            cb.SelectedIndex = 0;
        }
        
        private void Key_Press(object sender, KeyPressEventArgs e)
        {
            string vacio = "";
            int key = E.Key_press_global(sender, e);
            if (key == 1)
            {
                if (btnhacer_pedido.Focused)
                {

                }
                else if (btncrear_producto.Focused)
                {

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
            RellenarCbSucursal(cbSucursal);
            labelEmpleado.Text = UserGlobal.DATOS.Apellido + " " + UserGlobal.DATOS.Nombre;

        }
    }
}
