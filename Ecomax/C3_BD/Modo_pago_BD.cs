﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace C3_BD
{
    public class Modo_pago_BD : conexion_BD
    {
        public bool RegistrarVentaBD(long Ticket,double monto, int n_comp, int ID_mp,int ID_scr) {
            try
            {
                if (IsConnect())
                {
                    int retorno;
                    string cadena = "insert into Venta(Ticket, monto, n_comp, ID_mp,fecha,ID_scr) values(@Ticket,@monto,@n_comp,@ID_mp,GETDATE(),@ID_scr); ";
                    cmd = new SqlCommand(cadena, conexion);
                    cmd.Parameters.AddWithValue("@Ticket", Ticket);
                    cmd.Parameters.AddWithValue("@monto", monto);
                    cmd.Parameters.AddWithValue("@n_comp", n_comp);
                    cmd.Parameters.AddWithValue("@ID_mp", ID_mp);
                    cmd.Parameters.AddWithValue("@ID_scr", ID_scr);
                    //cmd.Parameters.AddWithValue("@Getdate",texto );
                    retorno = cmd.ExecuteNonQuery();
                    Console.WriteLine("Retorno" + retorno.ToString());
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
        
        public bool RegistrarDetalleBD(int Cod_art, string descripcion, double p_unidad, int cantidad, double total, long Ticket)
        {
            try
            {
                if (IsConnect())
                {
                    int retorno;
                    string cadena = "insert into Detalle(Cod_art, descripcion, p_unidad, cantidad, total, Ticket) values(@Cod_art,@descripcion,@p_unidad,@cantidad,@total,@Ticket); ";
                    cmd = new SqlCommand(cadena, conexion);
                    cmd.Parameters.AddWithValue("@Cod_art", Cod_art);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@p_unidad", p_unidad);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@Ticket", Ticket);
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
                        cant = cant - cantidad;
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
