using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace C2_Controlador
{
    public class PantallaStockControlador : Controlador
    {

        public List<string> ObtenerArticulos() {

            List<string> ComboBox = new List<string>();
            ComboBox = S_BD.ObtArticulos_BD();
            return ComboBox;
        }
        public int ObtenerCanti() {
            int canti = S_BD.ObtenerCantiBD();
            return canti;
        }
    }
}
