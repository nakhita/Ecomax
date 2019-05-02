using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Ecomax
{
    class Modo_pago_BD : conexion_BD
    {
        public bool RegistrarVentaBD(long Ticket,double monto, int n_comp, int ID_mp) {
            try
            {
                if (IsConnect())
                {
                    int retorno;
                    //insert into Venta(Ticket, monto, n_comp, ID_mp) values(12345678901234,10005.50,12345678,1);
                    string cadena = "insert into Venta(Ticket, monto, n_comp, ID_mp) values(@Ticket,@monto,@n_comp,@ID_mp); ";
                    cmd = new SqlCommand(cadena, conexion);
                    cmd.Parameters.AddWithValue("@Ticket",Ticket);
                    cmd.Parameters.AddWithValue("@monto",monto);
                    cmd.Parameters.AddWithValue("@n_comp",n_comp);
                    cmd.Parameters.AddWithValue("@ID_mp",ID_mp);
                    retorno = cmd.ExecuteNonQuery();
                    Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                return false;
            }
            return true;
        }
        public bool DescArt(int Cod_art, int cantidad, int ID_scr)
        {
            try
            {
                if (IsConnect())
                {
                    int cant = 0;
                    //insert into Venta(Ticket, monto, n_comp, ID_mp) values(12345678901234,10005.50,12345678,1);
                    string cadena = "select PS.cantidad from Producto P inner join Producto_Sucursal PS on P.Cod_art = PS.Cod_art where P.Cod_art = '" + Cod_art + "' and PS.ID_scr ='" + ID_scr + "'; ";
                    cmd = new SqlCommand(cadena, conexion);
                    if (cmd.ExecuteScalar() != null)
                    {
                        int retorno;
                        cant = (Int32)cmd.ExecuteScalar();
                        cant = cantidad - cant;
                        Console.WriteLine(cant.ToString());
                        cadena = "update Producto_Sucursal set cantidad='" + cant + "' where ID_scr = '" + ID_scr + "' and Cod_art= '" + Cod_art + "';";
                        cmd = new SqlCommand(cadena, conexion);
                        retorno = cmd.ExecuteNonQuery();
                    }
                    Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                return false;
            }
            return true;
        }

    }
}
