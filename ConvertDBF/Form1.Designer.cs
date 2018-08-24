namespace ConvertDBF
{
    partial class MAICO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAICO));
            this.consultar = new System.Windows.Forms.Button();
            this.abrirPrueba = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.documento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // consultar
            // 
            this.consultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultar.Location = new System.Drawing.Point(197, 166);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(164, 45);
            this.consultar.TabIndex = 0;
            this.consultar.Text = "Consultar";
            this.consultar.UseVisualStyleBackColor = false;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // abrirPrueba
            // 
            this.abrirPrueba.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.abrirPrueba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abrirPrueba.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrirPrueba.Location = new System.Drawing.Point(12, 166);
            this.abrirPrueba.Name = "abrirPrueba";
            this.abrirPrueba.Size = new System.Drawing.Size(164, 45);
            this.abrirPrueba.TabIndex = 1;
            this.abrirPrueba.Text = "Abrir prueba";
            this.abrirPrueba.UseVisualStyleBackColor = false;
            this.abrirPrueba.Click += new System.EventHandler(this.abrirPrueba_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(95, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.documento);
            this.groupBox1.Controls.Add(this.apellido);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 60);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paciente";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(7, 22);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 22);
            this.nombre.TabIndex = 0;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(124, 22);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(100, 22);
            this.apellido.TabIndex = 1;
            // 
            // documento
            // 
            this.documento.Location = new System.Drawing.Point(243, 22);
            this.documento.Name = "documento";
            this.documento.Size = new System.Drawing.Size(100, 22);
            this.documento.TabIndex = 2;
            // 
            // MAICO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 236);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.abrirPrueba);
            this.Controls.Add(this.consultar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MAICO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pruebas Audiometria MAICO";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Button abrirPrueba;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox documento;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox nombre;
    }
}

