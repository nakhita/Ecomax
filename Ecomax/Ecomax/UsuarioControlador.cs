using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Supermercado
{
    class UsuarioControlador: Controlador
    {
        
        private string vacio = "";
        private string datos;
        public int ObtenerUsuario(string usuario, string password){
            int categoria;
            
            if (usuario != vacio && password != vacio){
                categoria = conexion.autentificacion(usuario, password);

                return categoria;
            }
            else {
                return -1;
            }
        }

        
    }
}
