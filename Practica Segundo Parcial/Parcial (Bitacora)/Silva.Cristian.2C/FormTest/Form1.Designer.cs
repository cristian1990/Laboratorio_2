namespace FormTest
{
    partial class FrmPpal
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
            this.BtnLanzar = new System.Windows.Forms.Button();
            this.BtnBitacora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLanzar
            // 
            this.BtnLanzar.Location = new System.Drawing.Point(46, 31);
            this.BtnLanzar.Name = "BtnLanzar";
            this.BtnLanzar.Size = new System.Drawing.Size(379, 144);
            this.BtnLanzar.TabIndex = 0;
            this.BtnLanzar.Text = "Lanzar";
            this.BtnLanzar.UseVisualStyleBackColor = true;
            this.BtnLanzar.Click += new System.EventHandler(this.BtnLanzar_Click);
            // 
            // BtnBitacora
            // 
            this.BtnBitacora.Location = new System.Drawing.Point(46, 204);
            this.BtnBitacora.Name = "BtnBitacora";
            this.BtnBitacora.Size = new System.Drawing.Size(379, 76);
            this.BtnBitacora.TabIndex = 1;
            this.BtnBitacora.Text = "Bitacora";
            this.BtnBitacora.UseVisualStyleBackColor = true;
            this.BtnBitacora.Click += new System.EventHandler(this.BtnBitacora_Click);
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 308);
            this.Controls.Add(this.BtnBitacora);
            this.Controls.Add(this.BtnLanzar);
            this.Name = "FrmPpal";
            this.Text = "Segundo Parcial";
            this.Load += new System.EventHandler(this.FrmPpal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLanzar;
        private System.Windows.Forms.Button BtnBitacora;
    }
}

