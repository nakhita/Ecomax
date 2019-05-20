namespace Ecomax
{
    partial class Num_caja
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
            this.boxCaja = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de caja";
            // 
            // boxCaja
            // 
            this.boxCaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxCaja.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCaja.ForeColor = System.Drawing.Color.Peru;
            this.boxCaja.Location = new System.Drawing.Point(84, 112);
            this.boxCaja.Multiline = true;
            this.boxCaja.Name = "boxCaja";
            this.boxCaja.Size = new System.Drawing.Size(98, 72);
            this.boxCaja.TabIndex = 1;
            this.boxCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.boxCaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            // 
            // Num_caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(164)))), ((int)(((byte)(223)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(278, 263);
            this.Controls.Add(this.boxCaja);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Num_caja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Num_caja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxCaja;
    }
}