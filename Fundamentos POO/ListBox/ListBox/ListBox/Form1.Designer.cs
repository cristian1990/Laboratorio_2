namespace ListBox
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
            this.LstFrutas = new System.Windows.Forms.ListBox();
            this.TxtFruta = new System.Windows.Forms.TextBox();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.lblFrutas = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstFrutas
            // 
            this.LstFrutas.FormattingEnabled = true;
            this.LstFrutas.Items.AddRange(new object[] {
            "Pera",
            "manzana"});
            this.LstFrutas.Location = new System.Drawing.Point(30, 115);
            this.LstFrutas.Name = "LstFrutas";
            this.LstFrutas.Size = new System.Drawing.Size(120, 134);
            this.LstFrutas.TabIndex = 1;
            this.LstFrutas.SelectedIndexChanged += new System.EventHandler(this.LstFrutas_SelectedIndexChanged);
            // 
            // TxtFruta
            // 
            this.TxtFruta.Location = new System.Drawing.Point(30, 39);
            this.TxtFruta.Name = "TxtFruta";
            this.TxtFruta.Size = new System.Drawing.Size(100, 20);
            this.TxtFruta.TabIndex = 2;
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Location = new System.Drawing.Point(181, 33);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(75, 30);
            this.BtnAdicionar.TabIndex = 3;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // lblFrutas
            // 
            this.lblFrutas.AutoSize = true;
            this.lblFrutas.Location = new System.Drawing.Point(64, 89);
            this.lblFrutas.Name = "lblFrutas";
            this.lblFrutas.Size = new System.Drawing.Size(0, 13);
            this.lblFrutas.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(181, 74);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(74, 28);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblFrutas);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.TxtFruta);
            this.Controls.Add(this.LstFrutas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox LstFrutas;
        private System.Windows.Forms.TextBox TxtFruta;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Label lblFrutas;
        private System.Windows.Forms.Button btnEliminar;
    }
}

