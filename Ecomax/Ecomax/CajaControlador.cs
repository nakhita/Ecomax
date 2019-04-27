using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecomax
{
    class CajaControlador : Controlador
    {


        
        public string[] ObtenerPrecio(int art,int ID_scr,int cant)
        {
            string[] datos_vector = null;
            if (art != 0)
            {
                datos_vector = new string[2];
                datos_vector = C_BD.cs_precio(art,ID_scr);
            }
            return datos_vector;
        }
        public double PrecioXcant(double precio, int cant) {
            double T_precio= precio * cant;
            return T_precio;
        }

        public double Total(double suma, double item) {
            suma = suma + item;
            return suma;
        }

    }
}
