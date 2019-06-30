using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace C3_BD
{
    public class Tesoreria_BD: conexion_BD
    {
 
        public DataTable ObtenerReporte_BD()
        {
            dt = new DataTable();
            if (IsConnect())
            {
                string cadena = "select V.Ticket,V.monto,V.n_comp,MP.nombre,V.fecha from Venta as V INNER JOIN ModoPago MP ON V.ID_mp=MP.ID_mp";
                adapt = new SqlDataAdapter(cadena, conexion);
                adapt.Fill(dt);
                Close();
            }
            return dt;
        }
        public DataTable ObtenerDetalle_BD(long ticket)
        {
            dt = new DataTable();
            if (IsConnect())
            {
                Console.WriteLine(ticket.ToString());
                string cadena = "select Cod_art,descripcion,p_unidad,cantidad,total from Detalle where Ticket= '" + ticket + "';";
                adapt = new SqlDataAdapter(cadena, conexion);
                adapt.Fill(dt);
                Close();
            }
            return dt;
        }
    }
}
