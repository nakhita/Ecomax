using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


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
        public int ObtenerCantiSuc()
        {
            int canti = S_BD.ObtenerCantiSucBD();
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
        public List<int> ObtIDArt()
        {
            List<int> IDArt = new List<int>();
            IDArt = S_BD.ObtIDArt_BD();
            return IDArt;
        }
        public List<int> ObtIDSucr()
        {
            List<int> IDSuc = new List<int>();
            IDSuc = S_BD.ObtIDSucr_BD();
            return IDSuc;
        }
        public DataTable ObtenerProductoDT()
        {
            DataTable dt = S_BD.ObtenerProducto_BD();
            return dt;
        }
        public bool AgregarArt(int art,int canti, double precio, int src)
        {
            bool ok= S_BD.AgregarArt_BD(art,canti,precio,src);
            return ok;
        }

    }
}
