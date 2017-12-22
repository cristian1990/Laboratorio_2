namespace Formulario2
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
            this.lblDato2 = new System.Windows.Forms.Label();
            this.TxtDato = new System.Windows.Forms.TextBox();
            this.BtnPasarDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDato2
            // 
            this.lblDato2.AutoSize = true;
            this.lblDato2.Location = new System.Drawing.Point(130, 80);
            this.lblDato2.Name = "lblDato2";
            this.lblDato2.Size = new System.Drawing.Size(37, 13);
            this.lblDato2.TabIndex = 0;
            this.lblDato2.Text = "DATO";
            // 
            // TxtDato
            // 
            this.TxtDato.Location = new System.Drawing.Point(96, 112);
            this.TxtDato.Name = "TxtDato";
            this.TxtDato.Size = new System.Drawing.Size(100, 20);
            this.TxtDato.TabIndex = 1;
            // 
            // BtnPasarDatos
            // 
            this.BtnPasarDatos.Location = new System.Drawing.Point(76, 159);
            this.BtnPasarDatos.Name = "BtnPasarDatos";
            this.BtnPasarDatos.Size = new System.Drawing.Size(133, 23);
            this.BtnPasarDatos.TabIndex = 2;
            this.BtnPasarDatos.Text = "PASAR DATO";
            this.BtnPasarDatos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 279);
            this.Controls.Add(this.BtnPasarDatos);
            this.Controls.Add(this.TxtDato);
            this.Controls.Add(this.lblDato2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDato2;
        private System.Windows.Forms.TextBox TxtDato;
        private System.Windows.Forms.Button BtnPasarDatos;
    }
}

