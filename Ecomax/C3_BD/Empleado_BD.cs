using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using C4_Class;

namespace C3_BD
{
    public class Empleado_BD : conexion_BD
    {
        public DataTable Obtener_Empleados()
        {
            DataTable dt = new DataTable();
            if (IsConnect())
            {
                SqlDataAdapter adapt = new SqlDataAdapter("select E.Legajo, E.Nombre, E.Apellido, C.ID_ct, C.Nombre AS 'NombreCategoria', S.ID_scr, S.Nombre AS 'NombreSucursal', S.Localidad AS 'LocalidadSucursal', U.Pass FROM Empleado E INNER JOIN Categoria C ON E.ID_ct = C.ID_ct INNER JOIN Sucursal S ON E.ID_scr = S.ID_scr INNER JOIN Usuario U ON E.Legajo=U.ID_user", conexion);
                adapt.Fill(dt);
                Close();
            }
            return dt;
        }

        public bool Buscar_Existe_Empleado(string Legajo)
        {
            int canti = 0;
            if (IsConnect())
            {
                string cadena = "SELECT COUNT(Legajo) from Empleado WHERE Legajo = @Legajo";
                cmd = new SqlCommand(cadena, conexion);
                cmd.Parameters.AddWithValue("@Legajo", Legajo);
                canti = (int)cmd.ExecuteScalar();
                Close();
            }
            return canti > 0;
        }

        public int Insertar_Empleados(Empleado Emp)
        {
            int retorno = 0;
            if (IsConnect())
            {
                string cadena = "INSERT INTO Empleado(Legajo,Nombre,Apellido,ID_ct,ID_scr) values (@Legajo,@Nombre,@Apellido,@ID_ct,@ID_scr)";
                cmd = new SqlCommand(cadena, conexion);
                cmd.Parameters.AddWithValue("@Legajo", Emp.Legajo);
                cmd.Parameters.AddWithValue("@Nombre", Emp.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", Emp.Apellido);
                cmd.Parameters.AddWithValue("@ID_ct", Emp.ID_Categoria);
                cmd.Parameters.AddWithValue("@ID_scr", Emp.ID_Sucursal);
                retorno = cmd.ExecuteNonQuery();

                if(retorno == 1)
                {
                    cadena = "INSERT INTO Usuario(ID_user,Pass) values (@User, @Pass)";
                    cmd = new SqlCommand(cadena, conexion);
                    cmd.Parameters.AddWithValue("@User", Emp.Legajo);
                    cmd.Parameters.AddWithValue("@Pass", Emp.Password);
                    retorno = cmd.ExecuteNonQuery();
                }

                Close();
            }
            return retorno;
        }

        public int Eliminar_Empleado(int Legajo)
        {
            int retorno = 0;
            if (IsConnect())
            {
                string cadena = "DELETE FROM Usuario WHERE ID_user = @Legajo";
                cmd = new SqlCommand(cadena, conexion);
                cmd.Parameters.AddWithValue("@Legajo", Legajo);
                retorno = cmd.ExecuteNonQuery();
                cadena = "DELETE FROM Empleado WHERE LEGAJO = @Legajo";
                cmd = new SqlCommand(cadena, conexion);
                cmd.Parameters.AddWithValue("@Legajo", Legajo);
                retorno = cmd.ExecuteNonQuery();
                
                Close();
            }
            return retorno;
        }

        public int Actualizar_Empleado(Empleado Emp)
        {
            int retorno = 0;
            if (IsConnect())
            {
                string cadena = "UPDATE Empleado SET Nombre = @Nombre, Apellido = @Apellido, ID_ct = @Categoria, ID_scr = @Sucursal WHERE Legajo = @Legajo";
                cmd = new SqlCommand(cadena, conexion);
                cmd.Parameters.AddWithValue("@Legajo", Emp.Legajo);
                cmd.Parameters.AddWithValue("@Nombre", Emp.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", Emp.Apellido);
                cmd.Parameters.AddWithValue("@Categoria", Emp.ID_Categoria);
                cmd.Parameters.AddWithValue("@Sucursal", Emp.ID_Sucursal);
                retorno = cmd.ExecuteNonQuery();

                if (retorno == 1)
                {
                    cadena = "UPDATE Usuario SET Pass = @Pass WHERE ID_user = @Legajo";
                    cmd = new SqlCommand(cadena, conexion);
                    cmd.Parameters.AddWithValue("@Legajo", Emp.Legajo);
                    cmd.Parameters.AddWithValue("@Pass", Emp.Password);
                    retorno = cmd.ExecuteNonQuery();
                }
                Close();
            }
            return retorno;
        }

        public DataTable Obtener_Categorias()
        {
            DataTable dt = new DataTable();
            if (IsConnect())
            {
                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Categoria", conexion);
                adapt.Fill(dt);
                Close();
            }
            return dt;
        }

        public DataTable Obtener_Sucursales()
        {
            DataTable dt = new DataTable();
            if (IsConnect())
            {
                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Sucursal", conexion);
                adapt.Fill(dt);
                Close();
            }
            return dt;
        }
    }
}
