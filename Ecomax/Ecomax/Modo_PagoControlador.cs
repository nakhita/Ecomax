using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecomax
{
    class ModoPagoControlador : Controlador
    {
        Modo_Pago M_Pago;
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

        public bool RegistrarVenta(object[] Reg_venta) {
            long Ticket = Convert.ToInt64(Reg_venta[0]);
            double monto = Convert.ToDouble(Reg_venta[1]);
            int n_comp = Convert.ToInt32(Reg_venta[2]);
            int ID_mp = Convert.ToInt32(Reg_venta[3]);
            bool ok= MP_BD.RegistrarVentaBD(Ticket,monto,n_comp,ID_mp);
            if (!ok) {
                return false;
            }
            return true;
        }

        public bool DescontarCant(List<int> Desc_art,List<int> Desc_cant)
        {
            int ID_scr = UserGlobal.DATOS.ID_scr;
            int largo = Desc_art.Count();
            Console.WriteLine("Largo "+largo.ToString());
            int i = 0;
            bool ok=false;
            for (i=0; i < largo; i++){
                ok = MP_BD.DescArt( Desc_art[i],Desc_cant[i],ID_scr);
                Console.WriteLine("descart " + Desc_art[i].ToString());
                Console.WriteLine("descant " + Desc_cant[i].ToString());
            }
            return ok;
            
        }
        public void setPantalla_ModoPago(Modo_Pago Pantalla_ModoPago)
        {
            M_Pago = Pantalla_ModoPago;
        }
    }
}
