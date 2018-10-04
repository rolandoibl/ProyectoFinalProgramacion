namespace Materiales_NuevaGeneración
{
    partial class Proveedores
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
            this.components = new System.ComponentModel.Container();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbPrecio = new System.Windows.Forms.TextBox();
            this.txtbExistencia = new System.Windows.Forms.TextBox();
            this.rdbEfectivo = new System.Windows.Forms.RadioButton();
            this.rdbTarjeta = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbEfectivo = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtbCantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbUnidades = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbProveedor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbPago = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(44, 53);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(121, 21);
            this.cmbProveedor.TabIndex = 0;
            this.cmbProveedor.SelectedIndexChanged += new System.EventHandler(this.cmbProveedor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proveedores:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "En stock:";
            // 
            // txtbPrecio
            // 
            this.txtbPrecio.Enabled = false;
            this.txtbPrecio.Location = new System.Drawing.Point(227, 53);
            this.txtbPrecio.Name = "txtbPrecio";
            this.txtbPrecio.Size = new System.Drawing.Size(49, 20);
            this.txtbPrecio.TabIndex = 3;
            // 
            // txtbExistencia
            // 
            this.txtbExistencia.Enabled = false;
            this.txtbExistencia.Location = new System.Drawing.Point(352, 54);
            this.txtbExistencia.Name = "txtbExistencia";
            this.txtbExistencia.Size = new System.Drawing.Size(49, 20);
            this.txtbExistencia.TabIndex = 3;
            // 
            // rdbEfectivo
            // 
            this.rdbEfectivo.AutoSize = true;
            this.rdbEfectivo.Location = new System.Drawing.Point(44, 225);
            this.rdbEfectivo.Name = "rdbEfectivo";
            this.rdbEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rdbEfectivo.TabIndex = 4;
            this.rdbEfectivo.TabStop = true;
            this.rdbEfectivo.Text = "Efectivo";
            this.rdbEfectivo.UseVisualStyleBackColor = true;
            this.rdbEfectivo.CheckedChanged += new System.EventHandler(this.rdbEfectivo_CheckedChanged_1);
            // 
            // rdbTarjeta
            // 
            this.rdbTarjeta.AutoSize = true;
            this.rdbTarjeta.Location = new System.Drawing.Point(44, 248);
            this.rdbTarjeta.Name = "rdbTarjeta";
            this.rdbTarjeta.Size = new System.Drawing.Size(108, 17);
            this.rdbTarjeta.TabIndex = 4;
            this.rdbTarjeta.TabStop = true;
            this.rdbTarjeta.Text = "Tarjeta de crédito";
            this.rdbTarjeta.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Forma de pago:";
            // 
            // txtbEfectivo
            // 
            this.txtbEfectivo.Location = new System.Drawing.Point(114, 225);
            this.txtbEfectivo.Name = "txtbEfectivo";
            this.txtbEfectivo.Size = new System.Drawing.Size(58, 20);
            this.txtbEfectivo.TabIndex = 6;
            this.txtbEfectivo.Visible = false;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(44, 308);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 7;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(44, 144);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cantidad:";
            // 
            // txtbCantidad
            // 
            this.txtbCantidad.Location = new System.Drawing.Point(102, 99);
            this.txtbCantidad.Name = "txtbCantidad";
            this.txtbCantidad.Size = new System.Drawing.Size(50, 20);
            this.txtbCantidad.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(226, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Unidades";
            // 
            // lbUnidades
            // 
            this.lbUnidades.AutoSize = true;
            this.lbUnidades.Location = new System.Drawing.Point(334, 229);
            this.lbUnidades.Name = "lbUnidades";
            this.lbUnidades.Size = new System.Drawing.Size(61, 13);
            this.lbUnidades.TabIndex = 12;
            this.lbUnidades.Text = "Resultado3";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(334, 252);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(61, 13);
            this.lbTotal.TabIndex = 13;
            this.lbTotal.Text = "Resultado4";
            // 
            // lbProveedor
            // 
            this.lbProveedor.AutoSize = true;
            this.lbProveedor.Location = new System.Drawing.Point(334, 200);
            this.lbProveedor.Name = "lbProveedor";
            this.lbProveedor.Size = new System.Drawing.Size(61, 13);
            this.lbProveedor.TabIndex = 14;
            this.lbProveedor.Text = "Resultado2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total";
            // 
            // lbPago
            // 
            this.lbPago.AutoSize = true;
            this.lbPago.Location = new System.Drawing.Point(334, 174);
            this.lbPago.Name = "lbPago";
            this.lbPago.Size = new System.Drawing.Size(61, 13);
            this.lbPago.TabIndex = 16;
            this.lbPago.Text = "Resultado1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Datos:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(224, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Método de pago";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(226, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Proveedor";
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 380);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbUnidades);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbProveedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbPago);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtbCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtbEfectivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdbTarjeta);
            this.Controls.Add(this.rdbEfectivo);
            this.Controls.Add(this.txtbExistencia);
            this.Controls.Add(this.txtbPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProveedor);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbPrecio;
        private System.Windows.Forms.TextBox txtbExistencia;
        private System.Windows.Forms.RadioButton rdbEfectivo;
        private System.Windows.Forms.RadioButton rdbTarjeta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbEfectivo;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ErrorProvider errorProv;
        private System.Windows.Forms.TextBox txtbCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbUnidades;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbProveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbPago;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
    }
}