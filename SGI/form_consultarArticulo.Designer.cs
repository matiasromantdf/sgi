namespace SGI
{
    partial class form_consultarArticulo
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.combo_prov = new System.Windows.Forms.ComboBox();
            this.lbl_costo = new System.Windows.Forms.Label();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txt_stock = new System.Windows.Forms.NumericUpDown();
            this.txt_precio = new System.Windows.Forms.NumericUpDown();
            this.txt_costo = new System.Windows.Forms.NumericUpDown();
            this.txt_iva = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_minimo = new System.Windows.Forms.NumericUpDown();
            this.btn_retirar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txt_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_costo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_iva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_minimo)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(396, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Buscar código por nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(41, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Código";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_codigo.Location = new System.Drawing.Point(120, 62);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(253, 23);
            this.txt_codigo.TabIndex = 10;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            this.txt_codigo.Leave += new System.EventHandler(this.txt_codigo_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(32, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(32, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(32, 250);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Stock";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(356, 245);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "IVA %";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(32, 307);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Proveedor";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SGI.Properties.Resources._206_search;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(433, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 86);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_nombre.Location = new System.Drawing.Point(128, 142);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(320, 23);
            this.txt_nombre.TabIndex = 25;
            // 
            // combo_prov
            // 
            this.combo_prov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_prov.Enabled = false;
            this.combo_prov.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.combo_prov.FormattingEnabled = true;
            this.combo_prov.Location = new System.Drawing.Point(128, 307);
            this.combo_prov.Margin = new System.Windows.Forms.Padding(4);
            this.combo_prov.Name = "combo_prov";
            this.combo_prov.Size = new System.Drawing.Size(245, 24);
            this.combo_prov.TabIndex = 29;
            // 
            // lbl_costo
            // 
            this.lbl_costo.AutoSize = true;
            this.lbl_costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_costo.Location = new System.Drawing.Point(356, 201);
            this.lbl_costo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_costo.Name = "lbl_costo";
            this.lbl_costo.Size = new System.Drawing.Size(44, 17);
            this.lbl_costo.TabIndex = 31;
            this.lbl_costo.Text = "Costo";
            // 
            // btn_editar
            // 
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_editar.Location = new System.Drawing.Point(128, 409);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(167, 50);
            this.btn_editar.TabIndex = 32;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_guardar.Location = new System.Drawing.Point(379, 409);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(167, 50);
            this.btn_guardar.TabIndex = 33;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txt_stock
            // 
            this.txt_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_stock.Location = new System.Drawing.Point(128, 248);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(120, 26);
            this.txt_stock.TabIndex = 34;
            // 
            // txt_precio
            // 
            this.txt_precio.DecimalPlaces = 2;
            this.txt_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_precio.Location = new System.Drawing.Point(128, 196);
            this.txt_precio.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(120, 26);
            this.txt_precio.TabIndex = 35;
            // 
            // txt_costo
            // 
            this.txt_costo.DecimalPlaces = 2;
            this.txt_costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_costo.Location = new System.Drawing.Point(426, 196);
            this.txt_costo.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(120, 26);
            this.txt_costo.TabIndex = 36;
            // 
            // txt_iva
            // 
            this.txt_iva.DecimalPlaces = 2;
            this.txt_iva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_iva.Location = new System.Drawing.Point(426, 240);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.Size = new System.Drawing.Size(72, 26);
            this.txt_iva.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(23, 359);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Stock mínimo";
            // 
            // txt_minimo
            // 
            this.txt_minimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_minimo.Location = new System.Drawing.Point(128, 359);
            this.txt_minimo.Name = "txt_minimo";
            this.txt_minimo.Size = new System.Drawing.Size(120, 26);
            this.txt_minimo.TabIndex = 39;
            // 
            // btn_retirar
            // 
            this.btn_retirar.Location = new System.Drawing.Point(460, 131);
            this.btn_retirar.Name = "btn_retirar";
            this.btn_retirar.Size = new System.Drawing.Size(126, 45);
            this.btn_retirar.TabIndex = 40;
            this.btn_retirar.Text = "Retirar de Stock";
            this.btn_retirar.UseVisualStyleBackColor = true;
            this.btn_retirar.Click += new System.EventHandler(this.button2_Click);
            // 
            // form_consultarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 478);
            this.Controls.Add(this.btn_retirar);
            this.Controls.Add(this.txt_minimo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_iva);
            this.Controls.Add(this.txt_costo);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.lbl_costo);
            this.Controls.Add(this.combo_prov);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_codigo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_consultarArticulo";
            this.Text = "Consultar o Editar artículo";
            this.Load += new System.EventHandler(this.form_consultarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_costo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_iva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_minimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.ComboBox combo_prov;
        private System.Windows.Forms.Label lbl_costo;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.NumericUpDown txt_stock;
        private System.Windows.Forms.NumericUpDown txt_precio;
        private System.Windows.Forms.NumericUpDown txt_costo;
        private System.Windows.Forms.NumericUpDown txt_iva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txt_minimo;
        private System.Windows.Forms.Button btn_retirar;
    }
}