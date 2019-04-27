using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Ecomax
{
    class Caja_BD : conexion_BD
    {
        private int ID_scr;
        private string Nombre_empleado;
        private double precio;
        public int cs_IDsucursal(int Ausuario)
        {
            ID_scr = 0;
            try
            {
                if (IsConnect())
                {
                    cmd = new SqlCommand("select ID_scr from Empleado where legajo ='" + Ausuario + "';", conexion);
                    if (cmd.ExecuteScalar() != null)
                    {
                        ID_scr = (Int32)cmd.ExecuteScalar();
                    }
                    Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return ID_scr;
            }

            return ID_scr;
        }

        public string cs_NombreEmp(int Ausuario)
        {
            Nombre_empleado = "";
            try
            {
                if (IsConnect())
                {
                    cmd = new SqlCommand("select nombre from Empleado where legajo ='" + Ausuario + "';", conexion);
                    if (cmd.ExecuteScalar() != null)
                    {
                        Nombre_empleado = Convert.ToString(cmd.ExecuteScalar());
                    }
                    Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Nombre_empleado;
            }

            return Nombre_empleado;
        }


        public double cs_precio(int art, int ID_scr)
        {
            precio = 0;
            try
            {

                if (IsConnect())
                {
                    cmd = new SqlCommand("select PS.precio from Producto P inner join Producto_Sucursal PS on P.Cod_art = PS.Cod_art where P.Cod_art = '" + art + "' and PS.ID_scr = '" + ID_scr + "'  ;", conexion);
                    if (cmd.ExecuteScalar() != null)
                    {
                        precio = Convert.ToDouble(cmd.ExecuteScalar());
                    }

                    Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                precio = -1;
                return precio;
            }
            return precio;

        }
    }
}
