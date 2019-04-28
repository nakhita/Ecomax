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

        public double TotalSuma(double suma, double item) {
            suma = suma + item;
            return suma;
        }
        public double TotalResta(double resta, double item)
        {
            resta = resta - item;
            return resta;
        }
        public int RestarCant(int resta, int num) {
            resta = resta - num;
            return resta;
        }
        public int Positivo(int num) {
            num = num * -1; // lo convierto en Positivo
            return num;
        }
        public int Encontro(int num, List<int> lista ) {
            int pos ;
            
            pos = lista.IndexOf(num);
            return pos;
        }
        public bool CompararLetra(string letra) {
            string punto = ".";
            if (letra == punto) {
                return true;
            }
            return false;

        }
    }
}
