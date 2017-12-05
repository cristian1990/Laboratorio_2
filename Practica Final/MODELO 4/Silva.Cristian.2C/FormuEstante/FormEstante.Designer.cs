namespace FormuEstante
{
    partial class FormEstante
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
            this.BtnOrdenar = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.rtxtSalida = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BtnOrdenar
            // 
            this.BtnOrdenar.Location = new System.Drawing.Point(412, 37);
            this.BtnOrdenar.Name = "BtnOrdenar";
            this.BtnOrdenar.Size = new System.Drawing.Size(217, 47);
            this.BtnOrdenar.TabIndex = 5;
            this.BtnOrdenar.Text = "Ordenar";
            this.BtnOrdenar.UseVisualStyleBackColor = true;
            this.BtnOrdenar.Click += new System.EventHandler(this.BtnOrdenar_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(151, 37);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(217, 47);
            this.BtnMostrar.TabIndex = 4;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // rtxtSalida
            // 
            this.rtxtSalida.Location = new System.Drawing.Point(151, 123);
            this.rtxtSalida.Name = "rtxtSalida";
            this.rtxtSalida.Size = new System.Drawing.Size(478, 529);
            this.rtxtSalida.TabIndex = 3;
            this.rtxtSalida.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 688);
            this.Controls.Add(this.BtnOrdenar);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.rtxtSalida);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOrdenar;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.RichTextBox rtxtSalida;
    }
}

