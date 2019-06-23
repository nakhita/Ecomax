using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using C2_Controlador;

namespace C2_Controlador
{
    public class PantallaStockControlador
    {
        public string[] RellenarComboBox() {
            int canti = ObtenerCanti();
            string[] ComboBox = new string[canti];
            return ComboBox;
        }
        public int ObtenerCanti() {
            int canti = 0; //ObtenerCantiBD();
            return canti;
        }
    }
}
