namespace Ecomax
{
    partial class Modo_Pago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxModoPago = new System.Windows.Forms.TextBox();
            this.labelPago_tarjeta = new System.Windows.Forms.Label();
            this.boxTarjVuelto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPrecio_total = new System.Windows.Forms.Label();
            this.labelPago_efectivo = new System.Windows.Forms.Label();
            this.pago_efectivo2 = new System.Windows.Forms.Label();
            this.labelPrecio_vuelto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTicket = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modo de pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "1. Efectivo ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(207, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "2. Tarjeta Credito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(435, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "3. Tarjeta Debito";
            // 
            // boxModoPago
            // 
            this.boxModoPago.Location = new System.Drawing.Point(246, 225);
            this.boxModoPago.Multiline = true;
            this.boxModoPago.Name = "boxModoPago";
            this.boxModoPago.Size = new System.Drawing.Size(117, 45);
            this.boxModoPago.TabIndex = 4;
            // 
            // labelPago_tarjeta
            // 
            this.labelPago_tarjeta.AutoSize = true;
            this.labelPago_tarjeta.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPago_tarjeta.ForeColor = System.Drawing.Color.White;
            this.labelPago_tarjeta.Location = new System.Drawing.Point(32, 303);
            this.labelPago_tarjeta.Name = "labelPago_tarjeta";
            this.labelPago_tarjeta.Size = new System.Drawing.Size(311, 23);
            this.labelPago_tarjeta.TabIndex = 7;
            this.labelPago_tarjeta.Text = "Ingrese N° de comprobante";
            this.labelPago_tarjeta.Visible = false;
            // 
            // boxTarjVuelto
            // 
            this.boxTarjVuelto.Location = new System.Drawing.Point(367, 285);
            this.boxTarjVuelto.Multiline = true;
            this.boxTarjVuelto.Name = "boxTarjVuelto";
            this.boxTarjVuelto.Size = new System.Drawing.Size(233, 43);
            this.boxTarjVuelto.TabIndex = 8;
            this.boxTarjVuelto.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(180, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 33);
            this.label5.TabIndex = 9;
            this.label5.Text = "TOTAL $";
            // 
            // labelPrecio_total
            // 
            this.labelPrecio_total.AutoSize = true;
            this.labelPrecio_total.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio_total.ForeColor = System.Drawing.Color.Black;
            this.labelPrecio_total.Location = new System.Drawing.Point(327, 92);
            this.labelPrecio_total.Name = "labelPrecio_total";
            this.labelPrecio_total.Size = new System.Drawing.Size(118, 33);
            this.labelPrecio_total.TabIndex = 10;
            this.labelPrecio_total.Text = "PRECIO";
            // 
            // labelPago_efectivo
            // 
            this.labelPago_efectivo.AutoSize = true;
            this.labelPago_efectivo.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPago_efectivo.ForeColor = System.Drawing.Color.White;
            this.labelPago_efectivo.Location = new System.Drawing.Point(32, 285);
            this.labelPago_efectivo.Name = "labelPago_efectivo";
            this.labelPago_efectivo.Size = new System.Drawing.Size(304, 46);
            this.labelPago_efectivo.TabIndex = 11;
            this.labelPago_efectivo.Text = "Ingrese con cuanto paga $\r\n\r\n";
            this.labelPago_efectivo.Visible = false;
            // 
            // pago_efectivo2
            // 
            this.pago_efectivo2.AutoSize = true;
            this.pago_efectivo2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pago_efectivo2.ForeColor = System.Drawing.Color.Black;
            this.pago_efectivo2.Location = new System.Drawing.Point(159, 366);
            this.pago_efectivo2.Name = "pago_efectivo2";
            this.pago_efectivo2.Size = new System.Drawing.Size(141, 33);
            this.pago_efectivo2.TabIndex = 12;
            this.pago_efectivo2.Text = "VUELTO $";
            this.pago_efectivo2.Visible = false;
            // 
            // labelPrecio_vuelto
            // 
            this.labelPrecio_vuelto.AutoSize = true;
            this.labelPrecio_vuelto.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio_vuelto.ForeColor = System.Drawing.Color.Black;
            this.labelPrecio_vuelto.Location = new System.Drawing.Point(318, 366);
            this.labelPrecio_vuelto.Name = "labelPrecio_vuelto";
            this.labelPrecio_vuelto.Size = new System.Drawing.Size(125, 33);
            this.labelPrecio_vuelto.TabIndex = 13;
            this.labelPrecio_vuelto.Text = "VUELTO ";
            this.labelPrecio_vuelto.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(196, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ticket";
            // 
            // labelTicket
            // 
            this.labelTicket.AutoSize = true;
            this.labelTicket.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicket.ForeColor = System.Drawing.Color.Black;
            this.labelTicket.Location = new System.Drawing.Point(272, 134);
            this.labelTicket.Name = "labelTicket";
            this.labelTicket.Size = new System.Drawing.Size(154, 23);
            this.labelTicket.TabIndex = 15;
            this.labelTicket.Text = "000000000000";
            // 
            // Modo_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(164)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.labelTicket);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelPrecio_vuelto);
            this.Controls.Add(this.pago_efectivo2);
            this.Controls.Add(this.labelPago_efectivo);
            this.Controls.Add(this.labelPrecio_total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxTarjVuelto);
            this.Controls.Add(this.labelPago_tarjeta);
            this.Controls.Add(this.boxModoPago);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modo_Pago";
            this.Text = "Modo_Pago";
            this.Shown += new System.EventHandler(this.Modo_Pago_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxModoPago;
        private System.Windows.Forms.Label labelPago_tarjeta;
        private System.Windows.Forms.TextBox boxTarjVuelto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelPrecio_total;
        private System.Windows.Forms.Label labelPago_efectivo;
        private System.Windows.Forms.Label pago_efectivo2;
        private System.Windows.Forms.Label labelPrecio_vuelto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTicket;
    }
}