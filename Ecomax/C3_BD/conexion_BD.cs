using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace C3_BD
{
    public class conexion_BD
    {
        protected SqlConnection conexion = null;
        protected SqlCommand cmd;
        /*protected SqlDataReader dr;*/
        
        protected bool IsConnect(){
            try{
                if (conexion==null){

                    //conexion = new SqlConnection("Data Source=BABYDADA\\SQLEXPRESS;Initial Catalog=marketBD;User ID=market;Password=admin123");
                    conexion = new SqlConnection("Data Source=marketbd.mssql.somee.com;Initial Catalog=marketbd;User ID=ecomax;Password=P@ssw0rd1");
                }
                conexion.Open();
                
            }
            catch{

                return false;
            }
            return true;
        }

        protected void Close(){
            conexion.Close();
        }

       
        
        /*public string CrearEmpleado(int legajo, string nombre, string apellido, int ID_ct, int ID_scr ) {
            if (IsConnect()){
                cmd = new SqlCommand("Insert into Empleado (Legajo,Nombre,Apellido,ID_ct,ID_scr) values (" + legajo + ",'" + nombre + "','" + apellido + "'," + ID_ct + "," + ID_scr + ")",conexion);
                Close();
            }
            
        }*/
    }
}
