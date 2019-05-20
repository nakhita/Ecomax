using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using C4_Class;

namespace C3_BD
{
    public class Usuario_BD : conexion_BD
    {
        ///Autentificacion y extracion de datos
        public UserDatos autentificacion(string Ausuario, string Apass)
        {
            UserDatos datos = null;
            try
            {
                if (IsConnect())
                {
                    string cadena = "select E.ID_ct,E.Nombre,E.Apellido,E.ID_scr from Usuario as U inner join Empleado as E on U.ID_user = E.Legajo  where ID_user = '" + Ausuario + "' and Pass = '" + Apass + "'; ";
                    cmd = new SqlCommand(cadena, conexion);
                    SqlDataReader registro = cmd.ExecuteReader();
                    
                    if (registro.Read())
                    {
                        datos = new UserDatos();
                        datos.ID_scr = Convert.ToInt32(registro["ID_scr"]);
                        datos.Nombre = registro["Nombre"].ToString();
                        datos.Apellido = registro["Apellido"].ToString();
                        datos.Categoria = Convert.ToInt32(registro["ID_ct"]);
                    }
                    Close();
                    return datos;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                
            }
            return datos;
        }
    }
}
