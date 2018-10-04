namespace Materiales_NuevaGeneración
{
    partial class Tarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tarjeta));
            this.btnFinalizarTransaccion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbVencimiento = new System.Windows.Forms.MaskedTextBox();
            this.mtbCvv = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotalPagar = new System.Windows.Forms.Label();
            this.mtbNumeroTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinalizarTransaccion
            // 
            this.btnFinalizarTransaccion.Location = new System.Drawing.Point(35, 149);
            this.btnFinalizarTransaccion.Name = "btnFinalizarTransaccion";
            this.btnFinalizarTransaccion.Size = new System.Drawing.Size(113, 52);
            this.btnFinalizarTransaccion.TabIndex = 15;
            this.btnFinalizarTransaccion.Text = "Finalizar Transacción";
            this.btnFinalizarTransaccion.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fecha de vencimiento (mes/año)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "CVV";
            // 
            // mtbVencimiento
            // 
            this.mtbVencimiento.Location = new System.Drawing.Point(287, 94);
            this.mtbVencimiento.Mask = "00/00";
            this.mtbVencimiento.Name = "mtbVencimiento";
            this.mtbVencimiento.Size = new System.Drawing.Size(40, 20);
            this.mtbVencimiento.TabIndex = 11;
            // 
            // mtbCvv
            // 
            this.mtbCvv.Location = new System.Drawing.Point(191, 94);
            this.mtbCvv.Mask = "000";
            this.mtbCvv.Name = "mtbCvv";
            this.mtbCvv.Size = new System.Drawing.Size(28, 20);
            this.mtbCvv.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Número Tarjeta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total a pagar: $";
            // 
            // lbTotalPagar
            // 
            this.lbTotalPagar.AutoSize = true;
            this.lbTotalPagar.Location = new System.Drawing.Point(123, 31);
            this.lbTotalPagar.Name = "lbTotalPagar";
            this.lbTotalPagar.Size = new System.Drawing.Size(0, 13);
            this.lbTotalPagar.TabIndex = 10;
            // 
            // mtbNumeroTarjeta
            // 
            this.mtbNumeroTarjeta.Location = new System.Drawing.Point(38, 94);
            this.mtbNumeroTarjeta.Mask = "0000-0000-0000-0000";
            this.mtbNumeroTarjeta.Name = "mtbNumeroTarjeta";
            this.mtbNumeroTarjeta.Size = new System.Drawing.Size(113, 20);
            this.mtbNumeroTarjeta.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(287, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Tarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 283);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFinalizarTransaccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtbVencimiento);
            this.Controls.Add(this.mtbCvv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTotalPagar);
            this.Controls.Add(this.mtbNumeroTarjeta);
            this.Name = "Tarjeta";
            this.Text = "Tarjeta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFinalizarTransaccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbVencimiento;
        private System.Windows.Forms.MaskedTextBox mtbCvv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotalPagar;
        private System.Windows.Forms.MaskedTextBox mtbNumeroTarjeta;
    }
}