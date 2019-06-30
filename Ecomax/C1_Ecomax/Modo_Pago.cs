using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C2_Controlador;


namespace C1_Ecomax
{
    public partial class Modo_Pago : Form
    {
        Eventos E;
        CajaPantalla p_caja;
        ModoPagoControlador MP_ctrl;
        private bool error_MPago = false;
        private bool ok_R = false;
        private bool ok_D = false;
        private bool ok_Det = false;
        private object[] RegistrarVenta;
        private List<int> ls_DescCant;
        private List<int> ls_DescArt;
        private string vacio = "";
        private List<string> ls_Desc;
        private List<double> ls_Pxcant;
        private List<double> ls_Total;

        
        public Modo_Pago()
        {
            InitializeComponent();            
            E = new Eventos(this);
            MP_ctrl = new ModoPagoControlador();
        }

        public void setPantalla_caja(CajaPantalla pantalla_caja)
        {
            p_caja = pantalla_caja;
        }
        private void Validar_enter(object sender, KeyPressEventArgs e) {
            if (boxTarjVuelto.Visible == false)
            {
                Verificar_ModoPago(sender,e);
            }
            else if (boxTarjVuelto.Visible == true)
            {
                Verificar_DatosPago();


            }
        }

        private void Verificar_DatosPago() {
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
                else
                {
                    E.cartel("Agregue el Numero de comprobante de la tarjeta");
                }

            }
            else if (MP_ctrl.IsNumber(S_comtar))
            {
                int I_comtar = Convert.ToInt32(S_comtar);
                if (I_BoxMP == 1)
                {
                    Registrar_Efectivo();
                }
                else
                {
                    Registrar_Tarjeta();
                }
            }
            else
            {
                E.cartel("Se debe completar el campo con caracteres numericos");
                error_MPago = true;
                boxTarjVuelto.Clear();
            }
        }

        private void Verificar_ModoPago(object sender, KeyPressEventArgs e) {
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
            else
            {
                boxModoPago.Clear();
            }
        }

        private void Registrar_Efectivo() {
            double box = Convert.ToDouble(boxTarjVuelto.Text);
            double precio = Convert.ToDouble(labelPrecio_total.Text);
            double vuelto = box - precio;

            if (vuelto >= 0)
            {
                labelPrecio_vuelto.Visible = true;
                pago_efectivo2.Enabled = true;
                pago_efectivo2.Visible = true;
                labelPrecio_vuelto.Text = vuelto.ToString();
                RegistrarVenta[2] = 0;
                RegistrarVenta[3] = Convert.ToInt32(boxModoPago.Text);
                ok_R = MP_ctrl.RegistrarVenta(RegistrarVenta);
                ok_Det = MP_ctrl.RegistrarDetalle(ls_DescArt,ls_Desc,ls_Pxcant,ls_DescCant,ls_Total, Convert.ToInt64(RegistrarVenta[0]));
                ok_D = MP_ctrl.DescontarCant(ls_DescArt, ls_DescCant);
                if (ok_R && ok_Det && ok_D)
                {
                    E.cartel("Compra registrada.");
                    error_MPago = false;
                    Cerrar();
                }
                else
                {
                    E.cartel("Error al registrar la compra.");
                    error_MPago = true;
                    Cerrar();
                }
            }
            else
            {
                E.cartel("Error al ingregar dinero");
                error_MPago = true;
                boxTarjVuelto.Clear();
            }
        }

        private void Registrar_Tarjeta() {
            labelPago_tarjeta.Visible = true;
            string S_num = boxTarjVuelto.Text;
            if (MP_ctrl.IsNumber(S_num)) {
                int num = Convert.ToInt32(boxTarjVuelto.Text);
                if (MP_ctrl.InNumberTar(num))
                {
                    RegistrarVenta[2] = Convert.ToInt32(boxTarjVuelto.Text);
                    RegistrarVenta[3] = Convert.ToInt32(boxModoPago.Text);
                    ok_R = MP_ctrl.RegistrarVenta(RegistrarVenta);
                    ok_Det = MP_ctrl.RegistrarDetalle(ls_DescArt, ls_Desc, ls_Pxcant, ls_DescCant, ls_Total,Convert.ToInt64(RegistrarVenta[0]));
                    ok_D = MP_ctrl.DescontarCant(ls_DescArt, ls_DescCant);
                    if (ok_R && ok_Det && ok_D)
                    {
                        E.cartel("Compra registrada.");
                        error_MPago = false;
                        Cerrar();
                    }
                }
                else
                {
                    E.cartel("El numero de comprobante es invalido");
                    error_MPago = true;
                    boxTarjVuelto.Clear();
                }
            }


        }

        private void Cerrar() {
            this.Close();
        }

        private void Key_Press(object sender, KeyPressEventArgs e)
        {
            int key = E.Key_press_global(sender, e);
            if (key == 1)
            {
                Validar_enter(sender,e);
            }

        }
        
        public bool error() {
            return error_MPago;
        }

        private void Reinicio(object[] registro, List<int> lsArt_descP, List<int> lsCant_descP,List<string> lsdesP, List<double> lspxcantP, List<double> lstotalP) {
            boxModoPago.Clear();
            boxModoPago.Enabled = true;
            SendKeys.Send("{TAB}");
            boxTarjVuelto.Clear();
            boxTarjVuelto.Visible = false;
            labelPago_efectivo.Visible = false;
            labelPago_tarjeta.Visible = false;
            pago_efectivo2.Visible = false;
            labelPrecio_vuelto.Visible = false;
            error_MPago = false;
            RegistrarVenta = new object[4];
            ls_DescCant = new List<int>();
            ls_DescArt = new List<int>();
            ls_Desc = new List<string>();
            ls_Pxcant = new List<double>();
            ls_Total = new List<double>();
            ls_DescArt = lsArt_descP;
            ls_DescCant = lsCant_descP;
            ls_Desc = lsdesP;
            ls_Pxcant = lspxcantP;
            ls_Total = lstotalP;
            RegistrarVenta = registro;
            labelTicket.Text = registro[0].ToString();
            labelPrecio_total.Text = registro[1].ToString();
        }
        public void Mostrar(Form Padre,object[] registro, List<int> lsArt_desc, List<int> lsCant_desc, List<string> lsdes, List<double> lspxcant,List<double> lstotal)
        {
            Reinicio(registro, lsArt_desc, lsCant_desc, lsdes, lspxcant, lstotal);
            this.ShowDialog(Padre);
            
        }
    }
}
