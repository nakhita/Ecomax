using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecomax
{
    class CajaControlador : Controlador
    {
        
        //private string vacio = "";
        private double precio;
        private string Nombre_Empleado = "";
        int ID_scr;
        public double ObtenerPrecio(int art,int ID_scr)
        {

            if (art != 0)
            {
                precio = C_BD.cs_precio(art,ID_scr);
            }
            return precio;
        }
        public int ObtenerSucursal(int usuario)
        {
            ID_scr = C_BD.cs_IDsucursal(usuario);
            return ID_scr;
        }

        public string ObtenerNombre_Empleado(int usuario)
        {
            Nombre_Empleado = C_BD.cs_NombreEmp(usuario);
            return Nombre_Empleado;
        }

    }
}
