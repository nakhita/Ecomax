using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using C3_BD;
using C4_Class;

namespace C2_Controlador
{

    public class UsuarioControlador : Controlador
    {
        
        private string vacio = "";


        public int ObtenerUsuario(string usuario, string password)
        {
            try
            {
                if (usuario != vacio && password != vacio)
                {
                    UserDatos datos = U_BD.autentificacion(usuario, password);
                    if (datos != null)
                    {
                        UserGlobal.DATOS = datos;
                        return 1;
                    }
                    else if (datos == null) {
                        return -1;
                    } 
                }

                
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                UserGlobal.DATOS.Categoria = 9999;
                
            }
            return 0;
        }       
    }
}
