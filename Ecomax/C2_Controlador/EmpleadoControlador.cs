using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace C2_Controlador
{
    public class EmpleadoControlador : Controlador 
    {
        public DataTable Obtener_Empleados()
        {
            DataTable dt = E_BD.ObtenerEmpleado_BD();
            return dt;
        }
    }
}
