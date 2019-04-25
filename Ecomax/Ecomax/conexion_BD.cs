using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Supermercado
{
    class conexion_BD
    {
        SqlConnection conexion = null;
        SqlCommand cmd;
        /*SqlDataReader dr;*/
        private string datos;
        
        private bool IsConnect(){
            try{
                if (conexion==null){
                conexion = new SqlConnection("Data Source=BABYDADA\\SQLEXPRESS;Initial Catalog=marketBD;User ID=market;Password=admin123");
                 }
                conexion.Open();
                
            }
            catch (Exception ex){

                return false;
            }
            return true;
        }

        private void Close(){
            conexion.Close();
        }

        public int autentificacion(string Ausuario, string Apass) {
            int categoria=0;
            try{
                if (IsConnect())
                {
                    cmd = new SqlCommand("Select E.ID_ct from Usuario as U inner join Empleado as E on U.ID_user = E.Legajo where ID_user = '" + Ausuario + "' and Pass = '" + Apass + "';", conexion);
                    if (cmd.ExecuteScalar() != null)
                    {
                        categoria = (Int32)cmd.ExecuteScalar();
                    }
                    Close();
                }
                else if (!IsConnect()) {
                    categoria = 999;
                }
            }
            catch{
                return categoria;
            }
            return categoria;
        }

        public string stock(int art) {
            return datos;
        }

        /*public string CrearEmpleado(int legajo, string nombre, string apellido, int ID_ct, int ID_scr ) {
            if (IsConnect()){
                cmd = new SqlCommand("Insert into Empleado (Legajo,Nombre,Apellido,ID_ct,ID_scr) values (" + legajo + ",'" + nombre + "','" + apellido + "'," + ID_ct + "," + ID_scr + ")",conexion);
                Close();
            }
            
        }*/
    }
}
