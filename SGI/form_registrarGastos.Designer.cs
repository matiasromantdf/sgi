namespace SGI
{
    partial class form_registrarGastos
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
            this.txt_fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_detalle = new System.Windows.Forms.TextBox();
            this.radio_retiro = new System.Windows.Forms.RadioButton();
            this.radio_gasto = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_monto = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txt_monto)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_fecha
            // 
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_fecha.Location = new System.Drawing.Point(94, 30);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(255, 23);
            this.txt_fecha.TabIndex = 0;
            // 
            // txt_detalle
            // 
            this.txt_detalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_detalle.Location = new System.Drawing.Point(94, 155);
            this.txt_detalle.Multiline = true;
            this.txt_detalle.Name = "txt_detalle";
            this.txt_detalle.Size = new System.Drawing.Size(255, 115);
            this.txt_detalle.TabIndex = 2;
            // 
            // radio_retiro
            // 
            this.radio_retiro.AutoSize = true;
            this.radio_retiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radio_retiro.Location = new System.Drawing.Point(94, 111);
            this.radio_retiro.Name = "radio_retiro";
            this.radio_retiro.Size = new System.Drawing.Size(64, 21);
            this.radio_retiro.TabIndex = 3;
            this.radio_retiro.TabStop = true;
            this.radio_retiro.Text = "Retiro";
            this.radio_retiro.UseVisualStyleBackColor = true;
            // 
            // radio_gasto
            // 
            this.radio_gasto.AutoSize = true;
            this.radio_gasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radio_gasto.Location = new System.Drawing.Point(196, 109);
            this.radio_gasto.Name = "radio_gasto";
            this.radio_gasto.Size = new System.Drawing.Size(64, 21);
            this.radio_gasto.TabIndex = 4;
            this.radio_gasto.TabStop = true;
            this.radio_gasto.Text = "Gasto";
            this.radio_gasto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(26, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Monto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(26, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(26, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Detalle";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_monto
            // 
            this.txt_monto.DecimalPlaces = 2;
            this.txt_monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_monto.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txt_monto.Location = new System.Drawing.Point(94, 73);
            this.txt_monto.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(120, 23);
            this.txt_monto.TabIndex = 23;
            this.txt_monto.ThousandsSeparator = true;
            // 
            // form_registrarGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 362);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radio_gasto);
            this.Controls.Add(this.radio_retiro);
            this.Controls.Add(this.txt_detalle);
            this.Controls.Add(this.txt_fecha);
            this.Name = "form_registrarGastos";
            this.Text = "Registrar Gastos o Retiros";
            this.Load += new System.EventHandler(this.form_registrarGastos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_monto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txt_fecha;
        private System.Windows.Forms.TextBox txt_detalle;
        private System.Windows.Forms.RadioButton radio_retiro;
        private System.Windows.Forms.RadioButton radio_gasto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown txt_monto;
    }
}