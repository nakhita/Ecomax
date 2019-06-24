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
        List<int> IDProv = new List<int>();
        List<int> IDArt = new List<int>();
        List<int> IDSucr = new List<int>();

        public int ObtenerCantiArtBD() {
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
        public int ObtenerCantiProvBD()
        {
            int canti = 0;
            try
            {

                if (IsConnect())
                {
                    string cadena = "Select COUNT(ID_prov) from Proveedor";
                    cmd = new SqlCommand(cadena, conexion);
                    canti = (int)cmd.ExecuteScalar();
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
            try
            {
                if (IsConnect())
                {
                    int c_art;
                    string cadena = "select Cod_art,descripcion, peso, simbpeso from Producto;";
                    cmd = new SqlCommand(cadena, conexion);
                    dr = cmd.ExecuteReader();
                    IDArt.Clear();
                    while (dr.Read()) {
                        c_art = (int) dr["Cod_art"];
                        Console.WriteLine("COdigo de ART: "+ c_art.ToString());
                        Art.Add(dr["descripcion"].ToString()+" "+ dr["peso"].ToString() + dr["simbpeso"].ToString());
                        IDArt.Add(c_art);
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
        public List<string> ObtProveedor_BD()
        {
            List<string> Prov= new List<string>();
            try
            {
                if (IsConnect())
                {
                    int ID;
                    string cadena = "Select ID_prov,nombre from Proveedor";
                    cmd = new SqlCommand(cadena, conexion);
                    dr = cmd.ExecuteReader();
                    IDProv.Clear();
                    while (dr.Read())
                    {
                        ID = (int)dr["ID_prov"];
                        Prov.Add(dr["nombre"].ToString());
                        IDProv.Add(ID);
                    }

                    dr.Close();
                    Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }

            return Prov;
        }
        public List<string> ObtSucursal_BD()
        {
            List<string> Suc = new List<string>();
            try
            {
                if (IsConnect())
                {
                    int ID;
                    string cadena = "Select ID_scr,Nombre,Localidad from Sucursal";
                    cmd = new SqlCommand(cadena, conexion);
                    dr = cmd.ExecuteReader();
                    IDSucr.Clear();
                    while (dr.Read())
                    {
                        ID = (int) dr["ID_scr"];
                        Suc.Add(ID.ToString() + " " + dr["Nombre"].ToString() + "-" + dr["Localidad"].ToString());
                        IDSucr.Add(ID);
                    }
                    dr.Close();
                    Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }

            return Suc;
        }

        public int CrearProducto_BD(string Nombre, int Peso, string kg, int Proveedor) {
            int ok = 0;
                try
                {
                    if (IsConnect())
                    {
                        int retorno;
                        string cadena = "insert into Producto(descripcion, peso, simbpeso, ID_prov) values(@descripcion,@peso,@simbpeso,@ID_prov); ";
                        cmd = new SqlCommand(cadena, conexion);
                        cmd.Parameters.AddWithValue("@descripcion", Nombre);
                        cmd.Parameters.AddWithValue("@peso", Peso);
                        cmd.Parameters.AddWithValue("@simbpeso", kg);
                        cmd.Parameters.AddWithValue("@ID_prov", Proveedor);
                        retorno = cmd.ExecuteNonQuery();
                        Console.WriteLine("Retorno" + retorno.ToString());
                        ok = 1;
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return ok;
                }
             
            return ok;
        }
        public List<int> ObtIDProv_BD() {
            return IDProv;     
        }
        public List<int> ObtIDArt_BD()
        {
            return IDArt;
        }
        public List<int> ObtIDSucr_BD()
        {
            return IDSucr;
        }
        public int ObtenerCantiSucBD()
        {
            int canti = 0;
            try
            {

                if (IsConnect())
                {
                    string cadena = "Select COUNT(ID_scr) from Sucursal";
                    cmd = new SqlCommand(cadena, conexion);
                    canti = (int)cmd.ExecuteScalar();
                    Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }

            return canti;
        }
        public DataTable ObtenerProducto_BD()
        {
            dt = new DataTable();
            if (IsConnect())
            {
                string cadena = "select P.Cod_art, P.descripcion, P.peso,P.simbpeso,PS.cantidad,PS.ID_scr from Producto P INNER JOIN Producto_Sucursal PS ON P.Cod_art = PS.Cod_art";
                adapt = new SqlDataAdapter(cadena, conexion);
                adapt.Fill(dt);
                Close();
            }
            return dt;
        }
        public bool AgregarArt_BD(int Cod_art, int cantidad, double precio,int ID_scr)
        {
            try
            {
                if (IsConnect())
                {
                    int retorno;

                    string cadena = "update Producto_Sucursal set cantidad=cantidad +'" + cantidad + "' where ID_scr = '" + ID_scr + "' and Cod_art= '" + Cod_art + "';";
                    cmd = new SqlCommand(cadena, conexion);
                    retorno = cmd.ExecuteNonQuery();
                    Console.WriteLine("Retorno precio = 0 " + retorno);
                    if (retorno == 0)
                    {
                        if (precio == 0)
                        {
                            Console.WriteLine("Error");
                            Close();
                            return false;
                        }
                        else
                        {
                            cadena = "insert into Producto_Sucursal(Cod_art, ID_scr, cantidad, precio) values(@Cod_art,@ID_scr,@cantidad,@precio); ";
                            cmd = new SqlCommand(cadena, conexion);
                            cmd.Parameters.AddWithValue("@Cod_art", Cod_art);
                            cmd.Parameters.AddWithValue("@ID_scr", ID_scr);
                            cmd.Parameters.AddWithValue("@cantidad", cantidad);
                            cmd.Parameters.AddWithValue("@precio", precio);
                            retorno = cmd.ExecuteNonQuery();
                            if (retorno == 0)
                            {
                                Close();
                                return false;
                            }
                        }
                    }    
                    if (precio != 0){
                        cadena = "update Producto_Sucursal set precio='" + precio + "' where ID_scr = '" + ID_scr + "' and Cod_art= '" + Cod_art + "';";
                        cmd = new SqlCommand(cadena, conexion);
                        retorno = cmd.ExecuteNonQuery();
                        if (retorno == 0)
                        {
                            Close();
                            return false;
                        }
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
