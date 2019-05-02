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
    public partial class Modo_Pago : Form
    {
        Eventos E;
        CajaPantalla p_caja;
        ModoPagoControlador MP_ctrl;
        private bool error_MPago = false;
        private bool ok_R = false;
        private bool ok_D = false;
        private object[] RegistrarVenta;
        private List<int> ls_DescCant;
        private List<int> ls_DescArt;
        
        public Modo_Pago()
        {
            InitializeComponent();            
            E = new Eventos(this);
            MP_ctrl = new ModoPagoControlador();
            MP_ctrl.setPantalla_ModoPago(this);
            
        }

        public void setPantalla_caja(CajaPantalla pantalla_caja)
        {
            p_caja = pantalla_caja;
        }
        private void Key_Press(object sender, KeyPressEventArgs e)
        {
            string vacio = "";

            int key = E.Key_press_global(sender, e);
            if (key == 1)
            {
                if (boxTarjVuelto.Visible == false)
                {

                    string S_pago = "";
                    S_pago = boxModoPago.Text;
                    S_pago = S_pago.Trim();

                    if (S_pago == vacio)
                    {
                        E.cartel("Agregue un modo de pago");
                    }

                    else if (MP_ctrl.IsNumber(S_pago))
                    {
                        int I_pago = Convert.ToInt32(S_pago);
                        bool InNumber = MP_ctrl.InNumber(I_pago);
                        if (InNumber)
                        {
                            if (I_pago == 1)
                            {
                                labelPago_efectivo.Visible = true;
                            }
                            else
                            {
                                labelPago_tarjeta.Visible = true;
                            }

                            boxTarjVuelto.Enabled = true;
                            boxTarjVuelto.Visible = true;
                            boxModoPago.Enabled = false;
                            E.tab(sender, e);
                        }
                        else
                        {
                            boxModoPago.Clear();
                        }

                    }
                }
                else if (boxTarjVuelto.Visible == true) {

                    string S_comtar = "";
                    S_comtar = boxTarjVuelto.Text;
                    int I_pago = Convert.ToInt32(boxModoPago.Text);
                    int I_BoxMP = Convert.ToInt32(boxModoPago.Text);
                    if (S_comtar == vacio)
                    {
                        if (I_pago == 1)
                        {
                            E.cartel("Agregue con que monto paga");
                        }
                        else {
                            E.cartel("Agregue el Numero de comprobante de la tarjeta");
                        }

                    }
                    else if (MP_ctrl.IsNumber(S_comtar))
                    {
                        int I_comtar = Convert.ToInt32(S_comtar);
                        if (I_BoxMP == 1)
                        {
                            double box = Convert.ToDouble(boxTarjVuelto.Text);
                            double precio = Convert.ToDouble(labelPrecio_total.Text);
                            double vuelto = box - precio;

                            if (vuelto >= 0)
                            {
                                labelPrecio_vuelto.Visible = true;
                                pago_efectivo2.Enabled = true;
                                pago_efectivo2.Visible = true;
                                labelPrecio_vuelto.Text = vuelto.ToString();
                                RegistrarVenta[2] = Convert.ToInt32(boxModoPago.Text);
                                RegistrarVenta[3] = 0;
                                E.cartel(ls_DescArt.ToString());
                                E.cartel(ls_DescCant.ToString());
                                ok_R = MP_ctrl.RegistrarVenta(RegistrarVenta);
                                ok_D = MP_ctrl.DescontarCant(ls_DescArt,ls_DescCant);
                                E.cartel(ok_R.ToString());
                                E.cartel(ok_D.ToString());
                                if (ok_R && ok_D){
                                    E.cartel("Compra registrada.");
                                    
                                }
                                else {
                                    E.cartel("Error al registrar la compra.");
                                    error_MPago = true;
                                    reinicio();
                                    this.Hide();
                                }
                            }
                            else if (vuelto < 0)
                            {
                            E.cartel("Error al ingregar dinero");
                            error_MPago = true;
                            }
                        }
                        else
                        {
                            labelPago_tarjeta.Visible = true;
                            RegistrarVenta[2] = Convert.ToInt32(boxModoPago.Text);
                            RegistrarVenta[3] = Convert.ToInt32(boxTarjVuelto.Text);
                            ok_R = MP_ctrl.RegistrarVenta(RegistrarVenta);
                            ok_D = MP_ctrl.DescontarCant(ls_DescArt, ls_DescCant);
                            E.cartel(ok_R.ToString());
                            E.cartel(ok_D.ToString());
                            if (ok_R && ok_D)
                            {
                                E.cartel("Compra registrada.");
                                reinicio();
                                this.Hide();
                            }
                            else{
                                E.cartel("Error al registrar la compra.");
                                error_MPago = true;
                                reinicio();
                                this.Hide();
                            }
                        }
                    }
                }


            }

        }
        
        public bool error() {
            return error_MPago;
        }

        private void reinicio() {
            boxModoPago.Clear();
            boxModoPago.Enabled = true;
            boxTarjVuelto.Clear();
            boxTarjVuelto.Visible = false;
            labelPago_efectivo.Visible = false;
            labelPago_tarjeta.Visible = false;
            pago_efectivo2.Visible = false;
            labelPrecio_vuelto.Visible = false;
            error_MPago = false;
            ls_DescCant.Clear();
            ls_DescArt.Clear();

        }

        private void Modo_Pago_Shown(object sender, EventArgs e)
        {
            RegistrarVenta = new object[4];
            ls_DescCant = new List<int>();
            ls_DescArt = new List<int>();
            RegistrarVenta = p_caja.Ob_registrarVenta();
            ls_DescArt = p_caja.lsArt_desc;
            ls_DescCant = p_caja.lsCant_desc;
            labelTicket.Text = RegistrarVenta[0].ToString();
            labelPrecio_total.Text = RegistrarVenta[1].ToString();
        }
    }
}
