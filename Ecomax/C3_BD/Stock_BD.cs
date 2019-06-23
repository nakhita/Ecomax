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
        public int ObtenerCantiBD() {
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

        public List<string> ObtArticulos_BD() {
            List<string> Art = new List<string>();
            int canti = 0;
            try
            {
                if (IsConnect())
                {
                    string cadena = "Select descripcion from Producto";
                    cmd = new SqlCommand(cadena, conexion);
                    dr = cmd.ExecuteReader();
                    while (dr.Read()) {
                        Art.Add(dr["descripcion"].ToString());
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
    }
}
