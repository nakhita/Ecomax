using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace C3_BD
{
    public class Empleado_BD : conexion_BD
    {
        public DataTable ObtenerEmpleado_BD()
        {
            dt = new DataTable();
            if (IsConnect())
            {
                string cadena = "select E.Legajo, E.Nombre, E.Apellido, C.ID_ct, C.Nombre AS 'NombreCategoria', S.ID_scr, S.Nombre AS 'NombreSucursal', S.Localidad AS 'LocalidadSucursal' from Empleado E INNER JOIN Categoria C ON E.ID_ct = C.ID_ct INNER JOIN Sucursal S ON E.ID_scr = S.ID_scr";
                adapt = new SqlDataAdapter(cadena, conexion);
                adapt.Fill(dt);
                Close();
            }
            return dt;
        }

    }
}
