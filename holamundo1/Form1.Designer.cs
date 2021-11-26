namespace holamundo1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblsaludo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 205);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(189, 70);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Saludar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(12, 12);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(189, 20);
            this.txtnombre.TabIndex = 2;
            // 
            // lblsaludo
            // 
            this.lblsaludo.AutoSize = true;
            this.lblsaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblsaludo.Location = new System.Drawing.Point(12, 47);
            this.lblsaludo.Name = "lblsaludo";
            this.lblsaludo.Size = new System.Drawing.Size(0, 36);
            this.lblsaludo.TabIndex = 3;
            this.lblsaludo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 301);
            this.Controls.Add(this.lblsaludo);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblsaludo;
    }
}

