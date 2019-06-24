using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; 


namespace C2_Controlador
{
    public class TesoreriaControlador: Controlador
    {
        
        public DataTable ObtenerReporteDT()
        {
            DataTable dt = T_BD.ObtenerReporte_BD();
            return dt;
        }
    }
}
