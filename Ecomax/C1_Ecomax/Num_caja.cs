using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C2_Controlador;

namespace Ecomax
{
    public partial class Num_caja : Form
    {
        public int n_caja;
        CajaPantalla pj;
        Num_cajaControlador Num_ctrl = new Num_cajaControlador();
        Eventos E;
        public Num_caja()
        {
            InitializeComponent();
            E = new Eventos(this);
            pj = new CajaPantalla();
        }

        private void Key_Press(object sender, KeyPressEventArgs e)
        {
            int key = E.Key_press_global(sender, e);
            if (key == 1)
            {
                Validar_enter(sender, e);
            }
        }
        private void Validar_enter(object sender, KeyPressEventArgs e){
            string vacio = "";
            string caja = E.obtener_datos_text(boxCaja);
            if (caja != vacio){
                try{
                    if (Num_ctrl.IsNumber(caja))
                    {
                        n_caja = Convert.ToInt32(caja);
                        if (Num_ctrl.InNumber(n_caja))
                        {
                            pj.set_caja(n_caja);
                            E.Abrir_otroForm(sender, e, pj);
                        }
                        else
                        {
                            boxCaja.Clear();
                        }
                    }
                    else
                    {
                        boxCaja.Clear();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }
        }
    }
}
