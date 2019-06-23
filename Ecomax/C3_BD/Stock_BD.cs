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
        List<int> IDProv = new List<int>();

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
                    int ID;
                    string cadena = "Select ID_prov,nombre from Proveedor";
                    cmd = new SqlCommand(cadena, conexion);
                    dr = cmd.ExecuteReader();
                    
                    while (dr.Read())
                    {
                        ID = (int)dr["ID_prov"];
                        Prov.Add(dr["nombre"].ToString());
                        IDProv.Add(ID);
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

        public int CrearProducto_BD(string Nombre, int Peso, string kg, int Proveedor) {
            int ok = 0;
                try
                {
                    if (IsConnect())
                    {
                        int retorno;
                        string cadena = "insert into Producto(descripcion, peso, simbpeso, ID_prov) values(@descripcion,@peso,@simbpeso,@ID_prov); ";
                        cmd = new SqlCommand(cadena, conexion);
                        cmd.Parameters.AddWithValue("@descripcion", Nombre);
                        cmd.Parameters.AddWithValue("@peso", Peso);
                        cmd.Parameters.AddWithValue("@simbpeso", kg);
                        cmd.Parameters.AddWithValue("@ID_prov", Proveedor);
                        retorno = cmd.ExecuteNonQuery();
                        Console.WriteLine("Retorno" + retorno.ToString());
                        ok = 1;
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return ok;
                }
             
            return ok;
        }
        public List<int> ObtIDProv_BD() {
            return IDProv;     
        }
    }
}
