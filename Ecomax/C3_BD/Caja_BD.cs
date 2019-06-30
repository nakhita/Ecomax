using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace C3_BD
{
    public class Caja_BD : conexion_BD
    {
        public string[] cs_precio(int art, int ID_scr)
        {
            string[] datos_vector=null;
            try
            {
                if (IsConnect())
                {
                    datos_vector = new string[2];
                    string cadena = "select P.descripcion,P.peso,P.simbpeso, PS.precio from Producto P inner join Producto_Sucursal PS on P.Cod_art = PS.Cod_art where P.Cod_art = '" + art + "' and PS.ID_scr = '" + ID_scr + "'; ";
                    cmd = new SqlCommand(cadena, conexion);
                    SqlDataReader registro = cmd.ExecuteReader();
                    if (registro.Read())
                    {
                        datos_vector[0] = registro["descripcion"].ToString()+" "+ registro["peso"].ToString()+ registro["simbpeso"].ToString();
                        datos_vector[1] = registro["precio"].ToString();
                    }
                    Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                
                return datos_vector;
            }
            return datos_vector;

        }
    }
}
