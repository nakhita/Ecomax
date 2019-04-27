using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace Ecomax
{
    class Eventos
    {
        //int num;
        public int xClick = 0, yClick = 0;
        private Form form;
        private int key;

        public Eventos(Form form)
        {
            this.form = form;
        }
        

        public string obtener_datos_text(System.Windows.Forms.TextBox box)
        {
            String texto = box.Text;
            return texto;
        }
       

        public void cartel(string palabra)
        {
            MessageBox.Show(palabra);
        }

        public void entrar(TextBox textbox, string placeholder)
        {
            entrar(textbox, placeholder, false);
        }

        public void entrar(TextBox textbox, string placeholder, Boolean password)
        {
            if (textbox.Text == placeholder)
            {
                textbox.Text = "";
                if (password)
                {
                    textbox.PasswordChar = '●';
                }
            }
        }

        public void salir(TextBox textbox, string placeholder)
        {
            salir(textbox, placeholder, false);
        }

        public void salir(TextBox textbox, string placeholder, Boolean password)
        {
            if (textbox.Text == "")
            {
                textbox.Text = placeholder;
                if (password)
                {
                    textbox.PasswordChar = (char)0;
                }
            }
        }

        public void Mover_pantalla(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                xClick = e.X;
                yClick = e.Y;
            }
            else
            {
                form.Left = form.Left + (e.X - xClick);
                form.Top = form.Top + (e.Y - yClick);
            }
        }
        public void Abrir_otroForm(object sender, EventArgs e, Form F_hijo)
        {

            form.Hide();
            F_hijo.Show();

        }
        /**/
        public int Key_press_global(object sender, KeyPressEventArgs e) {
            key = 0;
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                key = 1;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                form.Close();

            }
            return key;
        }

        public void tab(object sender, KeyPressEventArgs e) {
            e.Handled = true;
            SendKeys.Send("{TAB}");
        }
        
    }
}
