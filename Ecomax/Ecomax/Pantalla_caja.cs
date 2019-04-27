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
        List<int> lista = new List<int>();


        public Pantalla_caja()
        {
            InitializeComponent();
            E = new Eventos(this);
            C_BD = new CajaControlador();


        }
        private void Agregar(int art, string descripcion, double precio, int cant) {
            /* listBox1 = Art;
             * listBox2 = descripcion;
             * listBox3 = precio;
             * listBox4 = cantidad
             * listBox5 = precio total */
            int pos = C_BD.Encontro(art,lista);
            E.cartel(pos.ToString());
            double n_precio=0;
            if (pos >= 0)
            {

                n_precio = C_BD.PrecioXcant(Convert.ToDouble(listBox3.Items[pos]), Convert.ToInt32(listBox4.Items[pos]));
                listBox4.Items[pos]= Convert.ToInt32(listBox4.Items[pos]) + cant;
                Total = C_BD.TotalResta(Total, n_precio);
                n_precio = C_BD.PrecioXcant(Convert.ToDouble(listBox3.Items[pos]), Convert.ToInt32(listBox4.Items[pos]));
                listBox5.Items[pos] = n_precio.ToString();
                Total = C_BD.TotalSuma(Total, n_precio);
            }
            else if (pos == -1) {
                listBox1.Items.Add(art.ToString());
                listBox2.Items.Add(descripcion);
                listBox3.Items.Add(precio.ToString());
                listBox4.Items.Add(cant.ToString());
                n_precio = C_BD.PrecioXcant(precio, cant);
                listBox5.Items.Add(n_precio.ToString());
                Total = C_BD.TotalSuma(Total, n_precio);
                lista.Add(art);
            }
            boxStotal.Text = Total.ToString();
            boxTotal.Text = Total.ToString();
        }
        private void borrar(int cont) {
            listBox1.Items.Remove(listBox1.Items[cont]);
            listBox2.Items.Remove(listBox2.Items[cont]);
            listBox3.Items.Remove(listBox3.Items[cont]);
            listBox4.Items.Remove(listBox4.Items[cont]);
            listBox5.Items.Remove(listBox5.Items[cont]);
        }
        private void modificar(int art, int cant) {
            /* listBox1 = Art;
             * listBox2 = descripcion;
             * listBox3 = precio;
             * listBox4 = cantidad
             * listBox5 = precio total */
            int pos = C_BD.Encontro(art, lista); 
            cant = C_BD.Positivo(cant);
            if (pos >= 0)
            {
                if (Convert.ToInt32(listBox4.Items[pos]) >= cant)
                {
                    double n_precio = 0;
                    int n_cant = C_BD.RestarCant( Convert.ToInt32(listBox4.Items[pos]), cant);
                    if (n_cant != 0)
                    {
                        listBox4.Items[pos] = n_cant; //Modifico la cantidad actual
                        n_precio = C_BD.PrecioXcant(Convert.ToDouble(listBox3.Items[pos]), cant);
                        listBox5.Items[pos] = C_BD.TotalResta(Convert.ToDouble(listBox5.Items[pos]),n_precio);
                        Total = C_BD.TotalResta(Total , n_precio);
                    }
                    else if (n_cant == 0)
                    {
                        n_precio = C_BD.PrecioXcant(Convert.ToDouble(listBox3.Items[pos]),cant);
                        borrar(pos);
                        lista.RemoveAt(pos);
                        Total = C_BD.TotalResta(Total, n_precio);
                    }
                    boxStotal.Text = Total.ToString();
                    boxTotal.Text = Total.ToString();

                }
                else{
                    E.cartel("No se puede modificar una cantidad mayor a la que se marco");
                }
            }
            else if (pos == -1)
            {
                E.cartel("No se encuentra articulo para modificar");
            }

        }
        private void articulo_click() {

            try { 
                
                string descripcion = "";
                double precio = 0;
                int art = int.Parse(E.obtener_datos_text(boxArt));
                int cant = int.Parse(E.obtener_datos_text(boxCant));
                int pos = C_BD.Encontro(art, lista);
                if (cant != 0)
                {
                    if (cant > 0)
                    {
                        string[] aux = C_BD.ObtenerPrecio(art, UserGlobal.DATOS.ID_scr, cant);
                        descripcion = aux[0]; // descripcion
                        precio = Convert.ToDouble(aux[1]); // precio

                        if (precio <= 0)
                        {
                            E.cartel("Error: No existe articulo");
                        }
                        else if (precio > 0)
                        {
                            Agregar(art, descripcion, precio, cant);
                        }

                    }
                    else if (cant < 0)
                    {
                        modificar(art, cant);
                    }
                }
                else {
                    if (cant == 0) {
                       E.cartel("Error: Cantidad no puede ser 0");
                    }
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
               E.cartel("Error al escribir articulo o cantidad");
                
            }

            
            
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
