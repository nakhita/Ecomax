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
        Pantalla_caja p_caja;
        ModoPagoControlador M_pago;
        private object[] RegistrarVenta;
        private object[] DescuentaCantidad;
        
        public Modo_Pago()
        {
            InitializeComponent();
            E = new Eventos(this);
            M_pago = new ModoPagoControlador();
        }

        public void setPantalla_caja(Pantalla_caja pantalla_caja)
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
                    if (S_pago == vacio)
                    {
                        E.cartel("Agregue un modo de pago");
                    }

                    else if (M_pago.IsNumber(S_pago))
                    {
                        int I_pago = Convert.ToInt32(S_pago);
                        if (M_pago.InNumber(I_pago))
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
                    }
                }
                else if (boxTarjVuelto.Visible == true) {
                    string S_comtar = "";
                    S_comtar = boxTarjVuelto.Text;
                    if (S_comtar == vacio)
                    {
                        E.cartel("Agregue un modo de pago");
                    }
                    else if (M_pago.IsNumber(S_comtar))
                    {
                        int I_comtar = Convert.ToInt32(S_comtar);
                        if (M_pago.InNumber(I_comtar))
                        {
                            if (Convert.ToInt32(boxModoPago.Text) == 1)
                            {
                                boxModoPago.Enabled = true;
                                labelPrecio_vuelto.Visible = true;
                                double vuelto = Convert.ToDouble(boxTarjVuelto.Text) - Convert.ToDouble(labelPrecio_total.Text);
                                if (vuelto >= 0)
                                {
                                    labelPrecio_vuelto.Text = vuelto.ToString();
                                    //cargar_BD(object[] RegistrarVenta, object[] DescuentaCantidad);
                                    E.cartel("Compra registrada");
                                }
                                else if (vuelto < 0) {
                                    E.cartel("Error al ingregar dinero");

                                }
                            }
                            else
                            {
                                labelPago_tarjeta.Visible = true;
                                //cargar_BD(object[] RegistrarVenta, object[] DescuentaCantidad);
                                E.cartel("Compra registrada");
                            }
                            E.Abrir_otroForm(sender, e, p_caja);
                        }
                    }
                }


            }

        }

        private void Modo_Pago_Shown(object sender, EventArgs e)
        {
            /* DescuentaCantidad
             * 0toN = (int)cant_descontar;  */
            /* RegistrarVenta
             * 0 = (long)Ticket;
             * 1 = (double) Total;
             * 2toN = (int)n_art ; */
            int cant = p_caja.set_cant();
            RegistrarVenta = new object[cant+2];
            DescuentaCantidad = new object[cant - 2];
            RegistrarVenta = p_caja.Ob_registrarVenta();
            DescuentaCantidad = p_caja.Ob_DescuentaCantidad();
            labelPrecio_total.Text = RegistrarVenta[1].ToString();
            labelTicket.Text = RegistrarVenta[0].ToString();


        }
    }
}
