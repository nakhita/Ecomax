using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supermercado
{
    public partial class Pantalla_caja : Form
    {
        Eventos E;
        UsuarioControlador BD;
        public Pantalla_caja()
        {
            InitializeComponent();
            E = new Eventos(this);
            BD = new UsuarioControlador();
        }
        private void articulo_click() {
            int art = int.Parse(E.obtener_datos_text(boxArt));
            int cant = int.Parse(E.obtener_datos_text(boxCant));
            


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
