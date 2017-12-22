namespace RichTextBox_2
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
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.BtnGuadar = new System.Windows.Forms.Button();
            this.rtbEscribir = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.Location = new System.Drawing.Point(119, 275);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(90, 35);
            this.BtnAbrir.TabIndex = 0;
            this.BtnAbrir.Text = "Abrir";
            this.BtnAbrir.UseVisualStyleBackColor = true;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // BtnGuadar
            // 
            this.BtnGuadar.Location = new System.Drawing.Point(12, 275);
            this.BtnGuadar.Name = "BtnGuadar";
            this.BtnGuadar.Size = new System.Drawing.Size(90, 35);
            this.BtnGuadar.TabIndex = 1;
            this.BtnGuadar.Text = "Guardar";
            this.BtnGuadar.UseVisualStyleBackColor = true;
            this.BtnGuadar.Click += new System.EventHandler(this.BtnGuadar_Click);
            // 
            // rtbEscribir
            // 
            this.rtbEscribir.HideSelection = false;
            this.rtbEscribir.Location = new System.Drawing.Point(2, 3);
            this.rtbEscribir.Name = "rtbEscribir";
            this.rtbEscribir.Size = new System.Drawing.Size(467, 266);
            this.rtbEscribir.TabIndex = 2;
            this.rtbEscribir.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 322);
            this.Controls.Add(this.rtbEscribir);
            this.Controls.Add(this.BtnGuadar);
            this.Controls.Add(this.BtnAbrir);
            this.Name = "Form1";
            this.Text = "Rich Text Box";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAbrir;
        private System.Windows.Forms.Button BtnGuadar;
        private System.Windows.Forms.RichTextBox rtbEscribir;
    }
}

