using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Ecomax
{
    class Usuario_BD : conexion_BD
    {
        private int categoria;
        public int autentificacion(string Ausuario, string Apass)
        {
            categoria = 0;
            try
            {
                if (IsConnect())
                {
                    cmd = new SqlCommand("Select E.ID_ct from Usuario as U inner join Empleado as E on U.ID_user = E.Legajo where ID_user = '" + Ausuario + "' and Pass = '" + Apass + "';", conexion);
                    if (cmd.ExecuteScalar() != null)
                    {
                        categoria = (Int32)cmd.ExecuteScalar();
                    }
                    Close();
                }
            }
            catch
            {
                categoria = 9999;
                return categoria;
            }
            return categoria;
        }
        private void datos_empleado(object sender, EventArgs e)
        {
            
            try
            {
                if (IsConnect())
                {
                    string cadena = "select descripcion, precio from articulos where codigo=" + cod;
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    SqlDataReader registro = comando.ExecuteReader();
                    User_datos datos = new User_datos();
                    if (registro.Read())
                    {
                        datos.ID_scr = Convert.ToInt32(registro["ID_scr"]);
                        datos.Nombre = registro["Nombre"].ToString();
                        datos.Apellido = registro["Apellido"].ToString();
                        datos.categoria = Convert.ToInt32(registro["Categoria"]);
                    }
                    Close();
                    return datos;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }
        
        public User_datos obtenerDatosUsuario()
        {
            User_datos datos = new User_datos();
            return datos;
        }
    }
}
