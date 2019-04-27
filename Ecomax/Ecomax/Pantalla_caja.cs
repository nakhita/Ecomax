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
    public partial class Pantalla_caja : Form
    {
        Eventos E;
        CajaControlador C_BD;
        int Caja;
        

        public Pantalla_caja()
        {
            InitializeComponent();
            E = new Eventos(this);
            C_BD = new CajaControlador();


        }
        private void listar() {

        }
        private void articulo_click() {

            try{
                int art = int.Parse(E.obtener_datos_text(boxArt));
                int cant = int.Parse(E.obtener_datos_text(boxCant));
                double precio = C_BD.ObtenerPrecio(art, UserGlobal.DATOS.ID_scr);
                if (precio > 0)
                {
                    E.cartel(precio.ToString());
                    //listar();
                }
                else if (precio <= 0) {
                    E.cartel("Error: No existe articulo o no hay más stock");
                }
                
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                E.cartel("Error al escribir articulo o cantidad");
                
            }

            
            
        }
        private void Key_Press(object sender, KeyPressEventArgs e)
        {
            string vacio="";
            int key = E.Key_press_global(sender, e);
            if (key == 1)
            {
                if (boxCant.Focused)
                {
                    articulo_click();
                    E.tab(sender, e);
                    boxArt.Text = vacio;
                    boxCant.Text = "1";

                }
                else if(boxArt.Focused)
                {
                    
                    string art;
                    art= E.obtener_datos_text(boxArt);

                    if (art== vacio) {
                        boxArt.Text = "0";
                    }
                    E.tab(sender, e);
                    
                }
            }
            
        }
        public void set_caja(int n_caja) {
            Caja = n_caja;
        }
        private void Pantalla_caja_Shown(object sender, EventArgs e)
        {


            labelCaja.Text = "Caja " + Caja.ToString();
            labelEmpleado.Text = UserGlobal.DATOS.Apellido + " " +UserGlobal.DATOS.Nombre;
        }
    }
}
