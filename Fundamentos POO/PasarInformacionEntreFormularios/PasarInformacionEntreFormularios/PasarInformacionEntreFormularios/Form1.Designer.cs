namespace PasarInformacionEntreFormularios
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
            this.BtnElegirDato = new System.Windows.Forms.Button();
            this.lblDato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnElegirDato
            // 
            this.BtnElegirDato.Location = new System.Drawing.Point(106, 84);
            this.BtnElegirDato.Name = "BtnElegirDato";
            this.BtnElegirDato.Size = new System.Drawing.Size(111, 51);
            this.BtnElegirDato.TabIndex = 0;
            this.BtnElegirDato.Text = "ELEGIR DATO";
            this.BtnElegirDato.UseVisualStyleBackColor = true;
            this.BtnElegirDato.Click += new System.EventHandler(this.BtnElegirDato_Click);
            // 
            // lblDato
            // 
            this.lblDato.AutoSize = true;
            this.lblDato.Location = new System.Drawing.Point(142, 149);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(37, 13);
            this.lblDato.TabIndex = 1;
            this.lblDato.Text = "DATO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 287);
            this.Controls.Add(this.lblDato);
            this.Controls.Add(this.BtnElegirDato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnElegirDato;
        private System.Windows.Forms.Label lblDato;
    }
}

