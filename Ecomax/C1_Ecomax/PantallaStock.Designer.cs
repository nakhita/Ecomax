namespace C1_Ecomax
{
    partial class PantallaStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaStock));
            System.Windows.Forms.Button boton_entrar;
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCantidad_M = new System.Windows.Forms.Label();
            this.boxCant = new System.Windows.Forms.TextBox();
            this.labelEmpleado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            boton_entrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(40, 299);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(309, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelCantidad_M
            // 
            this.labelCantidad_M.AutoSize = true;
            this.labelCantidad_M.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad_M.ForeColor = System.Drawing.Color.White;
            this.labelCantidad_M.Location = new System.Drawing.Point(35, 392);
            this.labelCantidad_M.Name = "labelCantidad_M";
            this.labelCantidad_M.Size = new System.Drawing.Size(123, 27);
            this.labelCantidad_M.TabIndex = 4;
            this.labelCantidad_M.Text = "CANTIDAD";
            // 
            // boxCant
            // 
            this.boxCant.Font = new System.Drawing.Font("Segoe MDL2 Assets", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCant.ForeColor = System.Drawing.Color.Peru;
            this.boxCant.Location = new System.Drawing.Point(222, 376);
            this.boxCant.Multiline = true;
            this.boxCant.Name = "boxCant";
            this.boxCant.Size = new System.Drawing.Size(127, 55);
            this.boxCant.TabIndex = 5;
            this.boxCant.Text = "1";
            this.boxCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelEmpleado
            // 
            this.labelEmpleado.AutoSize = true;
            this.labelEmpleado.Font = new System.Drawing.Font("Century Gothic", 25.15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpleado.ForeColor = System.Drawing.Color.White;
            this.labelEmpleado.Location = new System.Drawing.Point(57, 175);
            this.labelEmpleado.Name = "labelEmpleado";
            this.labelEmpleado.Size = new System.Drawing.Size(324, 40);
            this.labelEmpleado.TabIndex = 7;
            this.labelEmpleado.Text = "No me pierdo mas";
            this.labelEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "PRODUCTO";
            // 
            // boton_entrar
            // 
            boton_entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(198)))));
            boton_entrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(198)))));
            boton_entrar.FlatAppearance.BorderSize = 0;
            boton_entrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(136)))), ((int)(((byte)(185)))));
            boton_entrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(184)))), ((int)(((byte)(240)))));
            boton_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            boton_entrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            boton_entrar.ForeColor = System.Drawing.Color.White;
            boton_entrar.Location = new System.Drawing.Point(72, 497);
            boton_entrar.Name = "boton_entrar";
            boton_entrar.Size = new System.Drawing.Size(200, 40);
            boton_entrar.TabIndex = 9;
            boton_entrar.Text = "HACER PEDIDO";
            boton_entrar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(387, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(325, 362);
            this.dataGridView1.TabIndex = 10;
            // 
            // PantallaStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(164)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(734, 568);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(boton_entrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEmpleado);
            this.Controls.Add(this.boxCant);
            this.Controls.Add(this.labelCantidad_M);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaStock";
            this.Text = "PantallaStock";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCantidad_M;
        private System.Windows.Forms.TextBox boxCant;
        private System.Windows.Forms.Label labelEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}