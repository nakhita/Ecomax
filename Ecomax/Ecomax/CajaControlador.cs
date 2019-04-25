using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Supermercado
{
    class CajaControlador : Controlador
    {
        
        private string vacio = "";
        private string datos;
        public string ObtenerArticulo(int art)
        {

            if (art != 0)
            {
                datos = conexion.stock(art);
            }
            return datos;
        }
    }
}
