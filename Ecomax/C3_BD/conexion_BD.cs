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
        protected SqlDataReader dr;
        protected SqlDataAdapter adapt;
        protected DataTable dt;


        protected bool IsConnect(){
            try{
                if (conexion==null){

                    conexion = new SqlConnection("Data Source=BABYDADA\\SQLEXPRESS;Initial Catalog=marketBD;User ID=market;Password=admin123");
                    //conexion = new SqlConnection("Data Source=marketbd.mssql.somee.com;Initial Catalog=marketbd;User ID=ecomax;Password=P@ssw0rd1");
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


    }
}
