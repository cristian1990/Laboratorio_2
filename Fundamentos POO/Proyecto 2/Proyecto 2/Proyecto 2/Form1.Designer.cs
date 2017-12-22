namespace Proyecto_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.GbEstudios = new System.Windows.Forms.GroupBox();
            this.RbPrimario = new System.Windows.Forms.RadioButton();
            this.rbSecundario = new System.Windows.Forms.RadioButton();
            this.RbUniversitario = new System.Windows.Forms.RadioButton();
            this.LbDatos = new System.Windows.Forms.ListBox();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.GbEstudios.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESO";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(165, 74);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(200, 20);
            this.DtpFecha.TabIndex = 2;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(165, 37);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(200, 20);
            this.TxtNombre.TabIndex = 3;
            // 
            // GbEstudios
            // 
            this.GbEstudios.Controls.Add(this.RbUniversitario);
            this.GbEstudios.Controls.Add(this.rbSecundario);
            this.GbEstudios.Controls.Add(this.RbPrimario);
            this.GbEstudios.Location = new System.Drawing.Point(60, 149);
            this.GbEstudios.Name = "GbEstudios";
            this.GbEstudios.Size = new System.Drawing.Size(336, 52);
            this.GbEstudios.TabIndex = 4;
            this.GbEstudios.TabStop = false;
            this.GbEstudios.Text = "Estudios";
            // 
            // RbPrimario
            // 
            this.RbPrimario.AutoSize = true;
            this.RbPrimario.Location = new System.Drawing.Point(17, 20);
            this.RbPrimario.Name = "RbPrimario";
            this.RbPrimario.Size = new System.Drawing.Size(62, 17);
            this.RbPrimario.TabIndex = 0;
            this.RbPrimario.TabStop = true;
            this.RbPrimario.Text = "Primario";
            this.RbPrimario.UseVisualStyleBackColor = true;
            // 
            // rbSecundario
            // 
            this.rbSecundario.AutoSize = true;
            this.rbSecundario.Location = new System.Drawing.Point(119, 20);
            this.rbSecundario.Name = "rbSecundario";
            this.rbSecundario.Size = new System.Drawing.Size(79, 17);
            this.rbSecundario.TabIndex = 1;
            this.rbSecundario.TabStop = true;
            this.rbSecundario.Text = "Secundario";
            this.rbSecundario.UseVisualStyleBackColor = true;
            // 
            // RbUniversitario
            // 
            this.RbUniversitario.AutoSize = true;
            this.RbUniversitario.Location = new System.Drawing.Point(231, 19);
            this.RbUniversitario.Name = "RbUniversitario";
            this.RbUniversitario.Size = new System.Drawing.Size(83, 17);
            this.RbUniversitario.TabIndex = 2;
            this.RbUniversitario.TabStop = true;
            this.RbUniversitario.Text = "Universitario";
            this.RbUniversitario.UseVisualStyleBackColor = true;
            // 
            // LbDatos
            // 
            this.LbDatos.FormattingEnabled = true;
            this.LbDatos.Location = new System.Drawing.Point(60, 226);
            this.LbDatos.Name = "LbDatos";
            this.LbDatos.Size = new System.Drawing.Size(184, 121);
            this.LbDatos.TabIndex = 5;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(280, 272);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(116, 43);
            this.BtnMostrar.TabIndex = 6;
            this.BtnMostrar.Text = "MOSTRAR";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 378);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.LbDatos);
            this.Controls.Add(this.GbEstudios);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GbEstudios.ResumeLayout(false);
            this.GbEstudios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.GroupBox GbEstudios;
        private System.Windows.Forms.RadioButton RbUniversitario;
        private System.Windows.Forms.RadioButton rbSecundario;
        private System.Windows.Forms.RadioButton RbPrimario;
        private System.Windows.Forms.ListBox LbDatos;
        private System.Windows.Forms.Button BtnMostrar;
    }
}

