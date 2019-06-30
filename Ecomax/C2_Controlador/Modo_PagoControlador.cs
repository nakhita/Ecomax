using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using C3_BD;
using C4_Class;

namespace C2_Controlador
{
    public class ModoPagoControlador : Controlador
    {
        //Modo_Pago M_Pago;
        Modo_pago_BD MP_BD = new Modo_pago_BD();
        public bool IsNumber(string num) {
            int referencia = 0;
            long referencia2 = 0;
            if (int.TryParse(num,out referencia)){
                return true;
            }
            else if (long.TryParse(num, out referencia2))
            {
                return true;
            }
            return false;
        }

        public bool InNumber(int num) {
            if (num > 0 && num <= 3) {
                return true;
            }
            return false;
        }
        public bool InNumberTar(int num) {
            if (num >= 10000000 && num <= 999999999) {
                return true;
            }
            return false;
        }

        public bool RegistrarVenta(object[] Reg_venta) {
            int ID_scr = UserGlobal.DATOS.ID_scr;
            long Ticket = Convert.ToInt64(Reg_venta[0]);
            double monto = Convert.ToDouble(Reg_venta[1]);
            int n_comp = Convert.ToInt32(Reg_venta[2]);
            int ID_mp = Convert.ToInt32(Reg_venta[3]);
            Console.WriteLine(ID_scr.ToString());
            bool ok= MP_BD.RegistrarVentaBD(Ticket,monto,n_comp,ID_mp,ID_scr);
            if (!ok) {
                return false;
            }
            return true;
        }
        public bool RegistrarDetalle(List<int> ls_DescArt, List<string> ls_Desc, List<double> ls_Pxcant, List<int> ls_DescCant, List<double> ls_Total,long ticket) {
            int largo = ls_DescArt.Count();
            int i = 0;
            bool ok = false;
            for (i = 0; i < largo; i++)
            {
                ok = MP_BD.RegistrarDetalleBD(ls_DescArt[i], ls_Desc[i], ls_Pxcant[i], ls_DescCant[i], ls_Total[i], ticket);
                if (!ok) {
                    return ok;
                }
            }
            return ok;
        }

        public bool DescontarCant(List<int> Desc_art,List<int> Desc_cant)
        {
            int ID_scr = UserGlobal.DATOS.ID_scr;
            int largo = Desc_art.Count();
            int i = 0;
            bool ok=false;
            for (i=0; i < largo; i++){
                ok = MP_BD.DescArt( Desc_art[i],Desc_cant[i],ID_scr);
                if (!ok)
                {
                    return ok;
                }
            }
            return ok;
            
        }
        /*
        public void setPantalla_ModoPago(Modo_Pago Pantalla_ModoPago)
        {
            M_Pago = Pantalla_ModoPago;
        }*/
    }
}
