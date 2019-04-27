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
        CajaControlador BD;
        
        public Pantalla_caja()
        {
            InitializeComponent();
            E = new Eventos(this);
            BD = new CajaControlador();
        }
        private void articulo_click() {
            int art = int.Parse(E.obtener_datos_text(boxArt));
            int cant = int.Parse(E.obtener_datos_text(boxCant));
            double precio= BD.ObtenerPrecio(art, User_global.DATOS.ID_scr);

            E.cartel(precio.ToString());

        }
        private void Key_Press(object sender, KeyPressEventArgs e)
        {
            int key = E.Key_press_global(sender, e);

            if (key == 1)
            {
                if (boxCant.Focused)
                {
                    articulo_click();
                    E.tab(sender, e);
                }
                else {
                    E.tab(sender, e);
                }
            }
        }
    }
}
