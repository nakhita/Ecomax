using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecomax
{

    class UsuarioControlador : Controlador
    {
        
        private string vacio = "";
        
        
        public int ObtenerUsuario(string usuario, string password){
            int categoria;
            
            if (usuario != vacio && password != vacio){
                categoria = U_BD.autentificacion(usuario, password);

                User_datos datos = U_BD.obtenerDatosUsuario();

                User_global.DATOS = datos;

                return categoria;
            }
            else {
                return -1;
            }
        }

        public void ObtenerDatosEmpleado(int usuario)
        {
            User_datos datos = U_BD.obtenerDatosUsuario();

            User_global.DATOS = datos;
        }


    }
}
