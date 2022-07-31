namespace SGI
{
    partial class form_pagoaProveedor
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
            this.combo_proveedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.lbl_cc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_comprobante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_monto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_proveedor
            // 
            this.combo_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_proveedor.FormattingEnabled = true;
            this.combo_proveedor.Location = new System.Drawing.Point(217, 38);
            this.combo_proveedor.Name = "combo_proveedor";
            this.combo_proveedor.Size = new System.Drawing.Size(219, 28);
            this.combo_proveedor.TabIndex = 0;
            this.combo_proveedor.SelectionChangeCommitted += new System.EventHandler(this.combo_proveedor_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Indique el proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese el monto pagado";
            // 
            // btn_registrar
            // 
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.Location = new System.Drawing.Point(205, 284);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(129, 27);
            this.btn_registrar.TabIndex = 4;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // lbl_cc
            // 
            this.lbl_cc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_cc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cc.Location = new System.Drawing.Point(224, 84);
            this.lbl_cc.Name = "lbl_cc";
            this.lbl_cc.Size = new System.Drawing.Size(141, 20);
            this.lbl_cc.TabIndex = 16;
            this.lbl_cc.Text = "Cuenta Corriente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Estado de cuenta";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.Location = new System.Drawing.Point(217, 170);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(245, 26);
            this.txt_fecha.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fecha";
            // 
            // txt_comprobante
            // 
            this.txt_comprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comprobante.Location = new System.Drawing.Point(217, 215);
            this.txt_comprobante.Name = "txt_comprobante";
            this.txt_comprobante.Size = new System.Drawing.Size(158, 26);
            this.txt_comprobante.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Comprobante";
            // 
            // txt_monto
            // 
            this.txt_monto.DecimalPlaces = 2;
            this.txt_monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txt_monto.Location = new System.Drawing.Point(217, 130);
            this.txt_monto.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(120, 26);
            this.txt_monto.TabIndex = 22;
            this.txt_monto.ThousandsSeparator = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SGI.Properties.Resources._175_invoice;
            this.pictureBox1.Location = new System.Drawing.Point(484, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // form_pagoaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 357);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.txt_comprobante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_cc);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_proveedor);
            this.Name = "form_pagoaProveedor";
            this.Text = "form_pagoaProveedor";
            this.Load += new System.EventHandler(this.form_pagoaProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_monto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_proveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Label lbl_cc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txt_fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_comprobante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txt_monto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}