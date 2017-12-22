namespace PasarInformacionEntreFormularios
{
    partial class Form2
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
            this.BtnPasarDatos = new System.Windows.Forms.Button();
            this.TxtDato = new System.Windows.Forms.TextBox();
            this.lblDato2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnPasarDatos
            // 
            this.BtnPasarDatos.Location = new System.Drawing.Point(62, 134);
            this.BtnPasarDatos.Name = "BtnPasarDatos";
            this.BtnPasarDatos.Size = new System.Drawing.Size(133, 33);
            this.BtnPasarDatos.TabIndex = 5;
            this.BtnPasarDatos.Text = "PASAR DATO";
            this.BtnPasarDatos.UseVisualStyleBackColor = true;
            this.BtnPasarDatos.Click += new System.EventHandler(this.BtnPasarDatos_Click);
            // 
            // TxtDato
            // 
            this.TxtDato.Location = new System.Drawing.Point(82, 97);
            this.TxtDato.Name = "TxtDato";
            this.TxtDato.Size = new System.Drawing.Size(100, 20);
            this.TxtDato.TabIndex = 4;
            // 
            // lblDato2
            // 
            this.lblDato2.AutoSize = true;
            this.lblDato2.Location = new System.Drawing.Point(116, 65);
            this.lblDato2.Name = "lblDato2";
            this.lblDato2.Size = new System.Drawing.Size(37, 13);
            this.lblDato2.TabIndex = 3;
            this.lblDato2.Text = "DATO";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnPasarDatos);
            this.Controls.Add(this.TxtDato);
            this.Controls.Add(this.lblDato2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPasarDatos;
        private System.Windows.Forms.TextBox TxtDato;
        private System.Windows.Forms.Label lblDato2;
    }
}