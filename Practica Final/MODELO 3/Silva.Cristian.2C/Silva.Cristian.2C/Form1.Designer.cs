namespace Silva.Cristian._2C
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
            this.BtnPrueba = new System.Windows.Forms.Button();
            this.BtnSalidaPantalla = new System.Windows.Forms.Button();
            this.RtbSalida = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BtnPrueba
            // 
            this.BtnPrueba.Location = new System.Drawing.Point(35, 41);
            this.BtnPrueba.Name = "BtnPrueba";
            this.BtnPrueba.Size = new System.Drawing.Size(467, 65);
            this.BtnPrueba.TabIndex = 0;
            this.BtnPrueba.Text = "Prueba Clases";
            this.BtnPrueba.UseVisualStyleBackColor = true;
            this.BtnPrueba.Click += new System.EventHandler(this.BtnPrueba_Click);
            // 
            // BtnSalidaPantalla
            // 
            this.BtnSalidaPantalla.Location = new System.Drawing.Point(35, 112);
            this.BtnSalidaPantalla.Name = "BtnSalidaPantalla";
            this.BtnSalidaPantalla.Size = new System.Drawing.Size(467, 65);
            this.BtnSalidaPantalla.TabIndex = 1;
            this.BtnSalidaPantalla.Text = "Mostrar Salida Por Pantalla";
            this.BtnSalidaPantalla.UseVisualStyleBackColor = true;
            this.BtnSalidaPantalla.Click += new System.EventHandler(this.BtnSalidaPantalla_Click);
            // 
            // RtbSalida
            // 
            this.RtbSalida.Location = new System.Drawing.Point(35, 184);
            this.RtbSalida.Name = "RtbSalida";
            this.RtbSalida.Size = new System.Drawing.Size(467, 322);
            this.RtbSalida.TabIndex = 2;
            this.RtbSalida.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 537);
            this.Controls.Add(this.RtbSalida);
            this.Controls.Add(this.BtnSalidaPantalla);
            this.Controls.Add(this.BtnPrueba);
            this.Name = "Form1";
            this.Text = "RPP";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPrueba;
        private System.Windows.Forms.Button BtnSalidaPantalla;
        private System.Windows.Forms.RichTextBox RtbSalida;
    }
}

