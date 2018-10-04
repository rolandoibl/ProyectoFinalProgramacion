namespace Materiales_NuevaGeneración
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
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbOpciones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtbDensidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMedidas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Metal",
            "Madera",
            "Plástico"});
            this.cmbCategoria.Location = new System.Drawing.Point(74, 76);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 0;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // cmbOpciones
            // 
            this.cmbOpciones.Enabled = false;
            this.cmbOpciones.FormattingEnabled = true;
            this.cmbOpciones.Location = new System.Drawing.Point(74, 128);
            this.cmbOpciones.Name = "cmbOpciones";
            this.cmbOpciones.Size = new System.Drawing.Size(121, 21);
            this.cmbOpciones.TabIndex = 0;
            this.cmbOpciones.SelectedIndexChanged += new System.EventHandler(this.cmbOpciones_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione su material:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opciones:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(102, 291);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtbDensidad
            // 
            this.txtbDensidad.Enabled = false;
            this.txtbDensidad.Location = new System.Drawing.Point(77, 186);
            this.txtbDensidad.Name = "txtbDensidad";
            this.txtbDensidad.Size = new System.Drawing.Size(100, 20);
            this.txtbDensidad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Densidad:";
            // 
            // cmbMedidas
            // 
            this.cmbMedidas.Enabled = false;
            this.cmbMedidas.FormattingEnabled = true;
            this.cmbMedidas.Location = new System.Drawing.Point(74, 236);
            this.cmbMedidas.Name = "cmbMedidas";
            this.cmbMedidas.Size = new System.Drawing.Size(121, 21);
            this.cmbMedidas.TabIndex = 0;
            this.cmbMedidas.SelectedIndexChanged += new System.EventHandler(this.cmbMedidas_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Medidas:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Materiales_NuevaGeneración.Properties.Resources.Materiales;
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 376);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 374);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbDensidad);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMedidas);
            this.Controls.Add(this.cmbOpciones);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtbDensidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMedidas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOpciones;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

