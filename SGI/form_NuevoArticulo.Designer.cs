namespace SGI
{
    partial class form_NuevoArticulo
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
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_costo = new System.Windows.Forms.NumericUpDown();
            this.txt_precio = new System.Windows.Forms.NumericUpDown();
            this.txt_iva = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_minimo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_costo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_iva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_minimo)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_proveedor
            // 
            this.combo_proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.combo_proveedor.FormattingEnabled = true;
            this.combo_proveedor.Location = new System.Drawing.Point(126, 72);
            this.combo_proveedor.Name = "combo_proveedor";
            this.combo_proveedor.Size = new System.Drawing.Size(194, 28);
            this.combo_proveedor.TabIndex = 2;
            this.combo_proveedor.Enter += new System.EventHandler(this.combo_proveedor_Enter);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_guardar.Location = new System.Drawing.Point(211, 264);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(139, 40);
            this.btn_guardar.TabIndex = 8;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(437, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "iva %";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(254, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(26, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "costo:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_descripcion.Location = new System.Drawing.Point(126, 117);
            this.txt_descripcion.MaxLength = 49;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(426, 26);
            this.txt_descripcion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(26, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(26, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "proveedor";
            // 
            // txt_cod
            // 
            this.txt_cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_cod.Location = new System.Drawing.Point(125, 30);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(170, 26);
            this.txt_cod.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(26, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Codigo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SGI.Properties.Resources._060_package;
            this.pictureBox1.Location = new System.Drawing.Point(432, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(327, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 28);
            this.button1.TabIndex = 35;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_costo
            // 
            this.txt_costo.DecimalPlaces = 2;
            this.txt_costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_costo.Location = new System.Drawing.Point(126, 167);
            this.txt_costo.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(100, 26);
            this.txt_costo.TabIndex = 4;
            this.txt_costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costo_KeyPress);
            // 
            // txt_precio
            // 
            this.txt_precio.DecimalPlaces = 2;
            this.txt_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_precio.Location = new System.Drawing.Point(316, 167);
            this.txt_precio.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 26);
            this.txt_precio.TabIndex = 5;
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            // 
            // txt_iva
            // 
            this.txt_iva.DecimalPlaces = 2;
            this.txt_iva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_iva.Location = new System.Drawing.Point(489, 167);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.Size = new System.Drawing.Size(62, 26);
            this.txt_iva.TabIndex = 6;
            this.txt_iva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_iva_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(26, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 40);
            this.label7.TabIndex = 39;
            this.label7.Text = "Stock \r\nminimo:";
            // 
            // txt_minimo
            // 
            this.txt_minimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_minimo.Location = new System.Drawing.Point(126, 218);
            this.txt_minimo.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txt_minimo.Name = "txt_minimo";
            this.txt_minimo.Size = new System.Drawing.Size(100, 26);
            this.txt_minimo.TabIndex = 7;
            // 
            // form_NuevoArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 328);
            this.Controls.Add(this.txt_minimo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_iva);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_costo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.combo_proveedor);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.label2);
            this.Name = "form_NuevoArticulo";
            this.Text = "Registrar nuevo artículo";
            this.Load += new System.EventHandler(this.form_NuevoArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_costo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_iva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_minimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_proveedor;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown txt_costo;
        private System.Windows.Forms.NumericUpDown txt_precio;
        private System.Windows.Forms.NumericUpDown txt_iva;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txt_minimo;
    }
}