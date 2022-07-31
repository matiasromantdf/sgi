namespace SGI
{
    partial class form_bajaArticulo
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
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_motivo = new System.Windows.Forms.TextBox();
            this.lbl_NombreDeArt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_codigo.Location = new System.Drawing.Point(127, 39);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(191, 26);
            this.txt_codigo.TabIndex = 0;
            this.txt_codigo.Leave += new System.EventHandler(this.txt_codigo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // txt_motivo
            // 
            this.txt_motivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_motivo.Location = new System.Drawing.Point(117, 171);
            this.txt_motivo.Multiline = true;
            this.txt_motivo.Name = "txt_motivo";
            this.txt_motivo.Size = new System.Drawing.Size(270, 66);
            this.txt_motivo.TabIndex = 2;
            // 
            // lbl_NombreDeArt
            // 
            this.lbl_NombreDeArt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_NombreDeArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreDeArt.Location = new System.Drawing.Point(22, 120);
            this.lbl_NombreDeArt.Name = "lbl_NombreDeArt";
            this.lbl_NombreDeArt.Size = new System.Drawing.Size(365, 20);
            this.lbl_NombreDeArt.TabIndex = 7;
            this.lbl_NombreDeArt.Text = "Nombre del Artículo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(23, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "Motivo de \r\nla baja";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Buscar código por nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(23, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(23, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 40);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha de \r\nregistro";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_fecha.Location = new System.Drawing.Point(117, 310);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(316, 26);
            this.txt_fecha.TabIndex = 4;
            // 
            // lbl_stock
            // 
            this.lbl_stock.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock.Location = new System.Drawing.Point(438, 119);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(139, 21);
            this.lbl_stock.TabIndex = 15;
            this.lbl_stock.Text = "Stock";
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(182, 354);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(185, 30);
            this.btn_registrar.TabIndex = 5;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SGI.Properties.Resources._206_search;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(363, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Descripción";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Stock";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_cantidad.Location = new System.Drawing.Point(117, 261);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(120, 26);
            this.txt_cantidad.TabIndex = 18;
            // 
            // form_bajaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 411);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.lbl_stock);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_NombreDeArt);
            this.Controls.Add(this.txt_motivo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_codigo);
            this.Name = "form_bajaArticulo";
            this.Text = "Baja / Perdida de artículo";
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txt_codigo;
        public System.Windows.Forms.TextBox txt_motivo;
        private System.Windows.Forms.Label lbl_NombreDeArt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txt_fecha;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txt_cantidad;
    }
}