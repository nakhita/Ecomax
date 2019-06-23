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
            this.btnhacer_pedido = new System.Windows.Forms.Button();
            this.btncrear_producto = new System.Windows.Forms.Button();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCantidad_M = new System.Windows.Forms.Label();
            this.boxCant = new System.Windows.Forms.TextBox();
            this.labelEmpleado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.boxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPeso = new System.Windows.Forms.ComboBox();
            this.boxPeso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label8 = new System.Windows.Forms.Label();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.cbProveedorNP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhacer_pedido
            // 
            this.btnhacer_pedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(198)))));
            this.btnhacer_pedido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(198)))));
            this.btnhacer_pedido.FlatAppearance.BorderSize = 0;
            this.btnhacer_pedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(136)))), ((int)(((byte)(185)))));
            this.btnhacer_pedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(184)))), ((int)(((byte)(240)))));
            this.btnhacer_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhacer_pedido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhacer_pedido.ForeColor = System.Drawing.Color.White;
            this.btnhacer_pedido.Location = new System.Drawing.Point(92, 516);
            this.btnhacer_pedido.Name = "btnhacer_pedido";
            this.btnhacer_pedido.Size = new System.Drawing.Size(171, 40);
            this.btnhacer_pedido.TabIndex = 4;
            this.btnhacer_pedido.Text = "HACER PEDIDO";
            this.btnhacer_pedido.UseVisualStyleBackColor = false;
            this.btnhacer_pedido.Click += new System.EventHandler(this.Btnhacer_pedido_Click);
            this.btnhacer_pedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            // 
            // btncrear_producto
            // 
            this.btncrear_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(198)))));
            this.btncrear_producto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(198)))));
            this.btncrear_producto.FlatAppearance.BorderSize = 0;
            this.btncrear_producto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(136)))), ((int)(((byte)(185)))));
            this.btncrear_producto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(184)))), ((int)(((byte)(240)))));
            this.btncrear_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncrear_producto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrear_producto.ForeColor = System.Drawing.Color.White;
            this.btncrear_producto.Location = new System.Drawing.Point(473, 516);
            this.btncrear_producto.Name = "btncrear_producto";
            this.btncrear_producto.Size = new System.Drawing.Size(171, 40);
            this.btncrear_producto.TabIndex = 10;
            this.btncrear_producto.Text = "CREAR PRODUCTO";
            this.btncrear_producto.UseVisualStyleBackColor = false;
            this.btncrear_producto.Click += new System.EventHandler(this.Btncrear_producto_Click);
            this.btncrear_producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(40, 274);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(309, 21);
            this.cbProducto.TabIndex = 1;
            this.cbProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelCantidad_M
            // 
            this.labelCantidad_M.AutoSize = true;
            this.labelCantidad_M.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad_M.ForeColor = System.Drawing.Color.White;
            this.labelCantidad_M.Location = new System.Drawing.Point(35, 343);
            this.labelCantidad_M.Name = "labelCantidad_M";
            this.labelCantidad_M.Size = new System.Drawing.Size(123, 27);
            this.labelCantidad_M.TabIndex = 0;
            this.labelCantidad_M.Text = "CANTIDAD";
            // 
            // boxCant
            // 
            this.boxCant.Font = new System.Drawing.Font("Segoe MDL2 Assets", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCant.ForeColor = System.Drawing.Color.Peru;
            this.boxCant.Location = new System.Drawing.Point(241, 327);
            this.boxCant.Multiline = true;
            this.boxCant.Name = "boxCant";
            this.boxCant.Size = new System.Drawing.Size(91, 56);
            this.boxCant.TabIndex = 2;
            this.boxCant.Text = "1";
            this.boxCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.boxCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            // 
            // labelEmpleado
            // 
            this.labelEmpleado.AutoSize = true;
            this.labelEmpleado.Font = new System.Drawing.Font("Century Gothic", 20.15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpleado.ForeColor = System.Drawing.Color.White;
            this.labelEmpleado.Location = new System.Drawing.Point(451, 75);
            this.labelEmpleado.Name = "labelEmpleado";
            this.labelEmpleado.Size = new System.Drawing.Size(258, 32);
            this.labelEmpleado.TabIndex = 0;
            this.labelEmpleado.Text = "No me pierdo mas";
            this.labelEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCTO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(786, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 456);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(388, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "NOMBRE";
            // 
            // boxNombre
            // 
            this.boxNombre.Location = new System.Drawing.Point(521, 309);
            this.boxNombre.Name = "boxNombre";
            this.boxNombre.Size = new System.Drawing.Size(240, 20);
            this.boxNombre.TabIndex = 5;
            this.boxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(400, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "PESO";
            // 
            // cbPeso
            // 
            this.cbPeso.FormattingEnabled = true;
            this.cbPeso.Location = new System.Drawing.Point(640, 376);
            this.cbPeso.Name = "cbPeso";
            this.cbPeso.Size = new System.Drawing.Size(121, 21);
            this.cbPeso.TabIndex = 7;
            this.cbPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            // 
            // boxPeso
            // 
            this.boxPeso.Location = new System.Drawing.Point(521, 376);
            this.boxPeso.Name = "boxPeso";
            this.boxPeso.Size = new System.Drawing.Size(113, 20);
            this.boxPeso.TabIndex = 6;
            this.boxPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(452, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "NUEVO PRODUCTO";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(198)))));
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(198)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(136)))), ((int)(((byte)(185)))));
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(184)))), ((int)(((byte)(240)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(909, 516);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(171, 40);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1166, 568);
            this.shapeContainer1.TabIndex = 27;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 355;
            this.lineShape1.X2 = 355;
            this.lineShape1.Y1 = 247;
            this.lineShape1.Y2 = 525;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(114, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 27);
            this.label8.TabIndex = 0;
            this.label8.Text = "PROVEEDOR";
            // 
            // cbProveedor
            // 
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(40, 450);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(309, 21);
            this.cbProveedor.TabIndex = 3;
            this.cbProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            // 
            // cbProveedorNP
            // 
            this.cbProveedorNP.FormattingEnabled = true;
            this.cbProveedorNP.Location = new System.Drawing.Point(521, 450);
            this.cbProveedorNP.Name = "cbProveedorNP";
            this.cbProveedorNP.Size = new System.Drawing.Size(240, 21);
            this.cbProveedorNP.TabIndex = 9;
            this.cbProveedorNP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(369, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 27);
            this.label4.TabIndex = 28;
            this.label4.Text = "PROVEEDOR";
            // 
            // PantallaStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(164)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1166, 568);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbProveedorNP);
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boxPeso);
            this.Controls.Add(this.cbPeso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncrear_producto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnhacer_pedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEmpleado);
            this.Controls.Add(this.boxCant);
            this.Controls.Add(this.labelCantidad_M);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaStock";
            this.Load += new System.EventHandler(this.PantallaStock_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCantidad_M;
        private System.Windows.Forms.TextBox boxCant;
        private System.Windows.Forms.Label labelEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnhacer_pedido;
        private System.Windows.Forms.Button btncrear_producto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPeso;
        private System.Windows.Forms.TextBox boxPeso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnActualizar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.ComboBox cbProveedorNP;
        private System.Windows.Forms.Label label4;
    }
}