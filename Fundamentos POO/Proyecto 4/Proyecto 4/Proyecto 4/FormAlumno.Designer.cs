namespace Proyecto_4
{
    partial class FormAlumno
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
            this.TxtIdAlumno = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtApellidoPat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtApellidoMat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnExaminar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.PxFotografia = new System.Windows.Forms.PictureBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DgvDatos = new System.Windows.Forms.DataGridView();
            this.TxtFotografia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PxFotografia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID ALUMNO";
            // 
            // TxtIdAlumno
            // 
            this.TxtIdAlumno.Location = new System.Drawing.Point(181, 56);
            this.TxtIdAlumno.Name = "TxtIdAlumno";
            this.TxtIdAlumno.Size = new System.Drawing.Size(133, 20);
            this.TxtIdAlumno.TabIndex = 1;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(181, 95);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(133, 20);
            this.TxtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE";
            // 
            // TxtApellidoPat
            // 
            this.TxtApellidoPat.Location = new System.Drawing.Point(181, 134);
            this.TxtApellidoPat.Name = "TxtApellidoPat";
            this.TxtApellidoPat.Size = new System.Drawing.Size(133, 20);
            this.TxtApellidoPat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "APELLIDO PAT.";
            // 
            // TxtApellidoMat
            // 
            this.TxtApellidoMat.Location = new System.Drawing.Point(181, 175);
            this.TxtApellidoMat.Name = "TxtApellidoMat";
            this.TxtApellidoMat.Size = new System.Drawing.Size(133, 20);
            this.TxtApellidoMat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "APELLIDO MAT.";
            // 
            // BtnExaminar
            // 
            this.BtnExaminar.Location = new System.Drawing.Point(337, 213);
            this.BtnExaminar.Name = "BtnExaminar";
            this.BtnExaminar.Size = new System.Drawing.Size(155, 25);
            this.BtnExaminar.TabIndex = 8;
            this.BtnExaminar.Text = "EXAMINAR";
            this.BtnExaminar.UseVisualStyleBackColor = true;
            this.BtnExaminar.Click += new System.EventHandler(this.BtnExaminar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(337, 50);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(155, 25);
            this.BtnBuscar.TabIndex = 9;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(230, 278);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(102, 25);
            this.BtnEliminar.TabIndex = 10;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(355, 278);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(102, 25);
            this.BtnActualizar.TabIndex = 11;
            this.BtnActualizar.Text = "ACTUALIZAR";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // PxFotografia
            // 
            this.PxFotografia.Location = new System.Drawing.Point(337, 81);
            this.PxFotografia.Name = "PxFotografia";
            this.PxFotografia.Size = new System.Drawing.Size(155, 126);
            this.PxFotografia.TabIndex = 12;
            this.PxFotografia.TabStop = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(104, 278);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(102, 25);
            this.BtnAgregar.TabIndex = 13;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // DgvDatos
            // 
            this.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatos.Location = new System.Drawing.Point(67, 319);
            this.DgvDatos.Name = "DgvDatos";
            this.DgvDatos.Size = new System.Drawing.Size(425, 150);
            this.DgvDatos.TabIndex = 14;
            // 
            // TxtFotografia
            // 
            this.TxtFotografia.Location = new System.Drawing.Point(181, 213);
            this.TxtFotografia.Name = "TxtFotografia";
            this.TxtFotografia.Size = new System.Drawing.Size(133, 20);
            this.TxtFotografia.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "FOTOGRAFIA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 549);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtFotografia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DgvDatos);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.PxFotografia);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnExaminar);
            this.Controls.Add(this.TxtApellidoMat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtApellidoPat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtIdAlumno);
            this.Controls.Add(this.label1);
            this.Name = "FormAlumno";
            this.Text = "ALUMNO";
            this.Load += new System.EventHandler(this.FormAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PxFotografia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIdAlumno;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtApellidoPat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtApellidoMat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnExaminar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.PictureBox PxFotografia;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView DgvDatos;
        private System.Windows.Forms.TextBox TxtFotografia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

