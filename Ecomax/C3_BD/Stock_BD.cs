using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace C3_BD
{
    public class Stock_BD : conexion_BD
    {
        public int ObtenerCantiArtBD() {
            int canti = 0;
            try
            {
                
                if (IsConnect())
                {
                    string cadena = "Select COUNT(Cod_art) from Producto";
                    cmd = new SqlCommand(cadena, conexion);
                    canti = (int) cmd.ExecuteScalar();
                    Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }

            return canti;
        }
        public int ObtenerCantiProvBD()
        {
            int canti = 0;
            try
            {

                if (IsConnect())
                {
                    string cadena = "Select COUNT(ID_prov) from Proveedor";
                    cmd = new SqlCommand(cadena, conexion);
                    canti = (int)cmd.ExecuteScalar();
                    Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }

            return canti;
        }
        public int ObtenerCantiSucBD()
        {
            int canti = 0;
            try
            {

                if (IsConnect())
                {
                    string cadena = "Select COUNT(ID_scr) from Sucursal";
                    cmd = new SqlCommand(cadena, conexion);
                    canti = (int)cmd.ExecuteScalar();
                    Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }

            return canti;
        }
        public List<string> ObtArticulos_BD() {
            List<string> Art = new List<string>();
            try
            {
                if (IsConnect())
                {
                    string cadena = "select descripcion, peso, simbpeso from Producto;";
                    cmd = new SqlCommand(cadena, conexion);
                    dr = cmd.ExecuteReader();
                    while (dr.Read()) {
                        Art.Add(dr["descripcion"].ToString()+" "+ dr["peso"].ToString() + dr["simbpeso"].ToString());
                    }
                    dr.Close();
                    Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }

            return Art;
        }
        public List<string> ObtProveedor_BD()
        {
            List<string> Prov= new List<string>();
            try
            {
                if (IsConnect())
                {
                    string cadena = "Select nombre from Proveedor";
                    cmd = new SqlCommand(cadena, conexion);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Prov.Add(dr["nombre"].ToString());
                    }
                    dr.Close();
                    Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }

            return Prov;
        }


        public List<string> ObtSucursal_BD()
        {
            List<string> Suc = new List<string>();
            try
            {
                if (IsConnect())
                {
                    string cadena = "Select ID_scr,Nombre,Localidad from Sucursal";
                    cmd = new SqlCommand(cadena, conexion);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Suc.Add(dr["ID_scr"].ToString() + " " + dr["Nombre"].ToString() + "-" + dr["Localidad"].ToString());
                    }
                    dr.Close();
                    Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }

            return Suc;
        }
    }
}
