namespace SGI
{
    partial class form_editarProveedor
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
            this.cmb_proveedores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_telefono = new System.Windows.Forms.MaskedTextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_cuit = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // cmb_proveedores
            // 
            this.cmb_proveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_proveedores.FormattingEnabled = true;
            this.cmb_proveedores.Location = new System.Drawing.Point(32, 45);
            this.cmb_proveedores.Name = "cmb_proveedores";
            this.cmb_proveedores.Size = new System.Drawing.Size(272, 21);
            this.cmb_proveedores.TabIndex = 0;
            this.cmb_proveedores.SelectionChangeCommitted += new System.EventHandler(this.cmb_proveedores_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciones Proveedor a editar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "CUIT:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Actualizar Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(120, 173);
            this.txt_telefono.Mask = "(9999)00-0000";
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(224, 20);
            this.txt_telefono.TabIndex = 6;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(120, 114);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(224, 20);
            this.txt_nombre.TabIndex = 7;
            // 
            // txt_cuit
            // 
            this.txt_cuit.Location = new System.Drawing.Point(120, 215);
            this.txt_cuit.Mask = "00-00000000-0";
            this.txt_cuit.Name = "txt_cuit";
            this.txt_cuit.Size = new System.Drawing.Size(206, 20);
            this.txt_cuit.TabIndex = 8;
            // 
            // form_editarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 360);
            this.Controls.Add(this.txt_cuit);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_proveedores);
            this.Name = "form_editarProveedor";
            this.Text = "Editar Proveedor";
            this.Load += new System.EventHandler(this.form_editarProveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_proveedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.MaskedTextBox txt_cuit;
    }
}