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
        
        public int ObtenerCantiArt() {
            int canti = S_BD.ObtenerCantiArtBD();
            return canti;
        }

        public int ObtenerCantiProv()
        {
            int canti = S_BD.ObtenerCantiProvBD();
            return canti;
        }


        public int CrearProducto(string Nombre, int Peso, string kg,int Proveedor) {
            int ok = 0;
            ok = S_BD.CrearProducto_BD(Nombre, Peso, kg, Proveedor);
            return ok;
        }
        public List<int> ObtIDProv()
        {
            List <int> IDProv = new List<int>();
            IDProv = S_BD.ObtIDProv_BD();
            return IDProv;
        }

    }
}
