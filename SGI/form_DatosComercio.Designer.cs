namespace SGI
{
    partial class form_DatosComercio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_DatosComercio));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cuit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ptoventa = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_codfact = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_iibb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_pag = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ptoventa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codfact)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(72, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Comercio: ";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_nombre.Location = new System.Drawing.Point(273, 37);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(283, 26);
            this.txt_nombre.TabIndex = 1;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_direccion.Location = new System.Drawing.Point(273, 78);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(283, 26);
            this.txt_direccion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(72, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(75, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "CUIT:";
            // 
            // txt_cuit
            // 
            this.txt_cuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_cuit.Location = new System.Drawing.Point(273, 126);
            this.txt_cuit.Name = "txt_cuit";
            this.txt_cuit.Size = new System.Drawing.Size(210, 26);
            this.txt_cuit.TabIndex = 5;
            this.txt_cuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "sin espacios ni guiones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(72, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Num. de Punto de Venta:";
            // 
            // txt_ptoventa
            // 
            this.txt_ptoventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_ptoventa.Location = new System.Drawing.Point(273, 174);
            this.txt_ptoventa.Name = "txt_ptoventa";
            this.txt_ptoventa.Size = new System.Drawing.Size(82, 26);
            this.txt_ptoventa.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Debe coincidir con el creado para la factura electrónica";
            // 
            // txt_codfact
            // 
            this.txt_codfact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_codfact.Location = new System.Drawing.Point(273, 215);
            this.txt_codfact.Name = "txt_codfact";
            this.txt_codfact.Size = new System.Drawing.Size(82, 26);
            this.txt_codfact.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(72, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cód. tipo Factura:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Según tablas AFIP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(75, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Ingresos Brutos:";
            // 
            // txt_iibb
            // 
            this.txt_iibb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_iibb.Location = new System.Drawing.Point(273, 262);
            this.txt_iibb.Name = "txt_iibb";
            this.txt_iibb.Size = new System.Drawing.Size(210, 26);
            this.txt_iibb.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(76, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Teléfono:";
            // 
            // txt_tel
            // 
            this.txt_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_tel.Location = new System.Drawing.Point(273, 319);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(165, 26);
            this.txt_tel.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SGI.Properties.Resources.disquete_de_computadora;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(370, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 73);
            this.button1.TabIndex = 17;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(313, 443);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Guardar las Modificaciones";
            // 
            // txt_pag
            // 
            this.txt_pag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_pag.Location = new System.Drawing.Point(542, 319);
            this.txt_pag.Name = "txt_pag";
            this.txt_pag.Size = new System.Drawing.Size(205, 26);
            this.txt_pag.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(474, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Web:";
            // 
            // form_DatosComercio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.txt_pag);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_iibb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_codfact);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ptoventa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_cuit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_DatosComercio";
            this.Text = "Datos del Comercio";
            this.Load += new System.EventHandler(this.form_DatosComercio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_ptoventa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codfact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cuit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txt_ptoventa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txt_codfact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_iibb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_pag;
        private System.Windows.Forms.Label label12;
    }
}