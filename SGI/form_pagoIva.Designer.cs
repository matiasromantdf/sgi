namespace SGI
{
    partial class form_pagoIva
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_monto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txt_monto)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(330, 26);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(63, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(63, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto Iva acumulado:";
            // 
            // lbl_monto
            // 
            this.lbl_monto.AutoSize = true;
            this.lbl_monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_monto.Location = new System.Drawing.Point(249, 89);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(21, 20);
            this.lbl_monto.TabIndex = 3;
            this.lbl_monto.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(63, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese monto a pagar:";
            // 
            // txt_monto
            // 
            this.txt_monto.DecimalPlaces = 2;
            this.txt_monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_monto.Location = new System.Drawing.Point(275, 184);
            this.txt_monto.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(120, 26);
            this.txt_monto.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Registrar Pago";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_pagoIva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_monto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "form_pagoIva";
            this.Text = "Pago IVA";
            this.Load += new System.EventHandler(this.form_pagoIva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_monto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_monto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txt_monto;
        private System.Windows.Forms.Button button1;
    }
}