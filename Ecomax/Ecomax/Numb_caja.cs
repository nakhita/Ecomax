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
    public partial class Numb_caja : Form
    {
        public int n_caja;
        Pantalla_caja pj;
        Eventos E;
        public Numb_caja()
        {
            InitializeComponent();
            E = new Eventos(this);
            pj = new Pantalla_caja();
        }

        private void Key_Press(object sender, KeyPressEventArgs e)
        {
            int key = E.Key_press_global(sender, e);
            if (key == 1)
            {
                string vacio = "";
                string caja = E.obtener_datos_text(boxCaja);

                if (caja!= vacio) {
                    try
                    {
                        n_caja = Convert.ToInt32(caja);
                        if (n_caja <= 0)
                        {
                            boxCaja.Text = "";
                        }
                        else
                        {
                            pj.set_caja(n_caja);
                            E.Abrir_otroForm(sender, e, pj);
                        }
                    }
                    catch (Exception ex) {
                        Console.WriteLine(ex);
                        boxCaja.Text = "";
                    }
                }
            }
        }
        
    }
}
