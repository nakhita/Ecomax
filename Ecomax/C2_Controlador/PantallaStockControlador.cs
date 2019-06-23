using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace C2_Controlador
{
    public class PantallaStockControlador : Controlador
    {

        public List<string> ObtenerArticulos() {
            List<string> ComboBox = new List<string>();
            ComboBox = S_BD.ObtArticulos_BD();
            return ComboBox;
        }
        public List<string> ObtenerProveedor()
        {
            List<string> ComboBox = new List<string>();
            ComboBox = S_BD.ObtProveedor_BD();
            return ComboBox;
        }
        public List<string> ObtSucursal()
        {
            List<string> ComboBox = new List<string>();
            ComboBox = S_BD.ObtSucursal_BD();
            return ComboBox;
        }
        
        public int ObtenerCantiArt() {
            int canti = S_BD.ObtenerCantiArtBD();
            return canti;
        }

        public int ObtenerCantiProv()
        {
            int canti = S_BD.ObtenerCantiProvBD();
            return canti;
        }


        public int ObtenerCantiSuc(){
            int canti = S_BD.ObtenerCantiSucBD();
            return canti;
        }

    }
}
