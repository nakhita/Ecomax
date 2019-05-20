using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C2_Controlador;
using C4_Class;

namespace Ecomax
{
    public partial class Login : Form
    {
        Eventos E;
        UsuarioControlador BD;
        
        Num_caja Caja;
        private string us = "USUARIO";
        private string ps = "CONTRASEÑA";
        CajaControlador C_BD;

        public Login()
        {
            InitializeComponent();
            E = new Eventos(this);
            BD = new UsuarioControlador();
            C_BD = new CajaControlador();
            Caja = new Num_caja();
            
        }

        private void boton_entrar_click(object sender, EventArgs e)
        {
            
            string usuario = E.obtener_datos_text(boxUsuario);
            string password = E.obtener_datos_text(boxPass);
            int ok = BD.ObtenerUsuario(usuario, password);
            if (ok==1)
            {
                int categoria = UserGlobal.DATOS.Categoria;
                switch (categoria)
                {
                    case 1: E.Abrir_otroForm(sender, e, Caja); break;
                    case 2: E.cartel("Ser abriría la pantalla de la Categoria 2"); break;
                    case 3: E.cartel("Ser abriría la pantalla de la Categoria 3"); break;
                    case 4: E.cartel("Ser abriría la pantalla de la Categoria 4"); break;
                    case 9999: E.cartel("Sucedió un error, Lo sentimos :("); break;
                }

            }
            else
            {
                if (ok==-1) {
                    E.cartel("No se encontro usuario. \n Puede que el usuario o contraseña esten mal escritos");
                }
                else {
                    E.cartel("Deben rellenarse todos los datos");
                }
                
            }
            
            
        }
        private void Key_Press(object sender, KeyPressEventArgs e)
        {
            int key = E.Key_press_global(sender, e);
            if (key == 1){
                boton_entrar_click(sender, e);
            }
        }

        private void BoxUsuario_Enter(object sender, EventArgs e){
            E.entrar(boxUsuario, us);
        }
        
        private void BoxUsuario_Leave(object sender, EventArgs e){
            E.salir(boxUsuario, us);
        }

        private void BoxPass_Enter(object sender, EventArgs e)
        {
            E.entrar(boxPass, ps, true);
        }
        private void BoxPass_Leave(object sender, EventArgs e)
        {
            E.salir(boxPass, ps, true);
        }

        private void Cerrar_click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Mini_click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;

        }
        private void Mover(object sender, MouseEventArgs e)
        {
            E.Mover_pantalla(sender, e);
        }

        
    }
}
