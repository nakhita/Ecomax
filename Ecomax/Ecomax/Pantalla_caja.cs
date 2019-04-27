using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ecomax
{
    public partial class Pantalla_caja : Form
    {
        private double Total=0;
        Eventos E;
        CajaControlador C_BD;
        int Caja;
        

        public Pantalla_caja()
        {
            InitializeComponent();
            E = new Eventos(this);
            C_BD = new CajaControlador();


        }
        private void listar(int art, string descripcion, double precio, int cant) {
            /* listBox1 = Art;
             * listBox2 = descripcion;
             * listBox3 = precio;
             * listBox4 = cantidad
             * listBox5 = precio total */
            listBox1.Items.Add(art.ToString());
            listBox2.Items.Add(descripcion);
            listBox3.Items.Add(precio.ToString());
            listBox4.Items.Add(cant.ToString());
            double T_precio = C_BD.PrecioXcant(precio,cant);
            listBox5.Items.Add(T_precio.ToString());
            Total = C_BD.Total(Total, T_precio);
            boxStotal.Text = Total.ToString();
            boxTotal.Text = Total.ToString();
        }
        private void modificar(int art, int cant) {
            /* listBox1 = Art;
             * listBox2 = descripcion;
             * listBox3 = precio;
             * listBox4 = cantidad
             * listBox5 = precio total */
            int cont = 0;
            int bandera = 0;
            while (cont < listBox1.Items.Count - 1 && bandera==0) {
                if (Convert.ToInt32(listBox1.Items[cont]) == art) {
                    bandera = 1;
                }
                cont++;
            }
            cant = cant * -1; // lo convierto en positivo
            if (bandera == 1)
            {
                if (Convert.ToInt32(listBox4.Items[cont]) >= cant)
                {
                    double n_precio = 0;
                    int n_cant = Convert.ToInt32(listBox4.Items[cont]) - cant;
                    if (n_cant != 0)
                    {
                        
                        listBox4.Items[cont] = n_cant.ToString(); //Modifico la cantidad actual
                        n_precio = Convert.ToDouble(listBox3.Items[cont]) * cant;
                        Total = Total - n_precio;
                    }
                    else if (n_cant == 0)
                    {
                        n_precio = Convert.ToDouble(listBox3.Items[cont]) * cant;
                        Total = Total - n_precio;
                        listBox1.Items.Remove(listBox1.Items[cont]);
                        listBox2.Items.Remove(listBox2.Items[cont]);
                        listBox3.Items.Remove(listBox3.Items[cont]);
                        listBox4.Items.Remove(listBox4.Items[cont]);
                        listBox5.Items.Remove(listBox5.Items[cont]);
                    }

                }
                else{
                    E.cartel("No se puede modificar una cantidad mayor a la que se marco");
                }
            }
        }
        private void articulo_click() {

            //try{
                string descripcion = "";
                double precio = 0;
                int art = int.Parse(E.obtener_datos_text(boxArt));
                int cant = int.Parse(E.obtener_datos_text(boxCant));
                if (cant > 0)
                {
                    string[] aux = C_BD.ObtenerPrecio(art, UserGlobal.DATOS.ID_scr, cant);
                    descripcion = aux[0]; // descripcion
                    precio = Convert.ToDouble(aux[1]); // precio


                    if (precio > 0)
                    {
                        E.cartel(precio.ToString());
                        listar(art, descripcion, precio, cant);
                    }
                    else if (precio <= 0)
                    {
                        E.cartel("Error: No existe articulo o no hay más stock");
                    }
                }
                else if (cant < 0) {
                    modificar(art,cant);
                }

            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex);
            //   E.cartel("Error al escribir articulo o cantidad");
                
            //}

            
            
        }
        private void Key_Press(object sender, KeyPressEventArgs e)
        {
            string vacio="";
            int key = E.Key_press_global(sender, e);
            if (key == 1)
            {
                if (boxCant.Focused)
                {
                    articulo_click();
                    E.tab(sender, e);
                    boxArt.Text = vacio;
                    boxCant.Text = "1";

                }
                else if(boxArt.Focused)
                {
                    
                    string art;
                    art= E.obtener_datos_text(boxArt);

                    if (art== vacio) {
                        boxArt.Text = "0";
                    }
                    E.tab(sender, e);
                    
                }
            }
            
        }
        public void set_caja(int n_caja) {
            Caja = n_caja;
        }
        private void Pantalla_caja_Shown(object sender, EventArgs e)
        {


            labelCaja.Text = "Caja " + Caja.ToString();
            labelEmpleado.Text = UserGlobal.DATOS.Apellido + " " +UserGlobal.DATOS.Nombre;
        }
    }
}
