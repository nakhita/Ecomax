using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using C3_BD;

namespace C2_Controlador
{
    public class Controlador
    {
        protected Usuario_BD U_BD = new Usuario_BD();
        protected Caja_BD C_BD = new Caja_BD();
        protected Stock_BD S_BD = new Stock_BD();
        protected Empleado_BD E_BD = new Empleado_BD();
        protected Tesoreria_BD T_BD = new Tesoreria_BD();
    }
}

