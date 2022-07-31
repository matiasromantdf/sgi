namespace SGI
{
    partial class form_compras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_proveedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_costo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_detalle = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_numFactura = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_iva = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_cc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_nuevoArticulo = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_agregarDetalle = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_cantidad = new System.Windows.Forms.NumericUpDown();
            this.txt_final = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_fecha
            // 
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_fecha.Location = new System.Drawing.Point(395, 15);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(106, 26);
            this.txt_fecha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(336, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha:";
            // 
            // combo_proveedor
            // 
            this.combo_proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.combo_proveedor.FormattingEnabled = true;
            this.combo_proveedor.Location = new System.Drawing.Point(103, 13);
            this.combo_proveedor.Name = "combo_proveedor";
            this.combo_proveedor.Size = new System.Drawing.Size(203, 28);
            this.combo_proveedor.TabIndex = 1;
            this.combo_proveedor.SelectedIndexChanged += new System.EventHandler(this.combo_proveedor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Proveedor:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_codigo.Location = new System.Drawing.Point(280, 58);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(174, 26);
            this.txt_codigo.TabIndex = 5;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            this.txt_codigo.Leave += new System.EventHandler(this.txt_codigo_Leave);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(547, 58);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(21, 20);
            this.lbl_nombre.TabIndex = 6;
            this.lbl_nombre.Text = "...";
            this.lbl_nombre.Click += new System.EventHandler(this.lbl_nombre_Click);
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.Location = new System.Drawing.Point(547, 129);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(21, 20);
            this.lbl_precio.TabIndex = 7;
            this.lbl_precio.Text = "...";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock.Location = new System.Drawing.Point(547, 163);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(21, 20);
            this.lbl_stock.TabIndex = 8;
            this.lbl_stock.Text = "...";
            // 
            // lbl_costo
            // 
            this.lbl_costo.AutoSize = true;
            this.lbl_costo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costo.Location = new System.Drawing.Point(547, 94);
            this.lbl_costo.Name = "lbl_costo";
            this.lbl_costo.Size = new System.Drawing.Size(21, 20);
            this.lbl_costo.TabIndex = 9;
            this.lbl_costo.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(425, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Precio actual:";
            // 
            // lbl_5
            // 
            this.lbl_5.AutoSize = true;
            this.lbl_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_5.Location = new System.Drawing.Point(422, 99);
            this.lbl_5.Name = "lbl_5";
            this.lbl_5.Size = new System.Drawing.Size(110, 20);
            this.lbl_5.TabIndex = 12;
            this.lbl_5.Text = "costo anterior:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(429, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(158, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(158, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Costo (sin iva):";
            // 
            // txt_costo
            // 
            this.txt_costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_costo.Location = new System.Drawing.Point(280, 92);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(100, 26);
            this.txt_costo.TabIndex = 6;
            this.txt_costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costo_KeyPress);
            this.txt_costo.Leave += new System.EventHandler(this.txt_costo_Leave);
            // 
            // txt_precio
            // 
            this.txt_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_precio.Location = new System.Drawing.Point(280, 127);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 26);
            this.txt_precio.TabIndex = 7;
            this.txt_precio.TextChanged += new System.EventHandler(this.txt_precio_TextChanged);
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            this.txt_precio.Leave += new System.EventHandler(this.txt_precio_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(158, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Precio de venta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(160, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Cantidad";
            // 
            // dgv_detalle
            // 
            this.dgv_detalle.AllowUserToAddRows = false;
            this.dgv_detalle.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_detalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.cantidad,
            this.costo,
            this.precio,
            this.subtotal,
            this.eliminar});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_detalle.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_detalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_detalle.Location = new System.Drawing.Point(52, 205);
            this.dgv_detalle.Name = "dgv_detalle";
            this.dgv_detalle.ReadOnly = true;
            this.dgv_detalle.RowHeadersVisible = false;
            this.dgv_detalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_detalle.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_detalle.RowTemplate.Height = 26;
            this.dgv_detalle.Size = new System.Drawing.Size(836, 187);
            this.dgv_detalle.TabIndex = 21;
            this.dgv_detalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_detalle_CellContentClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Descripción";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 300;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 75;
            // 
            // costo
            // 
            this.costo.HeaderText = "Costo";
            this.costo.Name = "costo";
            this.costo.ReadOnly = true;
            this.costo.Width = 75;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio de venta";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 105;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subt.";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Width = 105;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Image = global::SGI.Properties.Resources.borrar;
            this.eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Width = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(723, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Tpo Factura:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.comboBox1.Location = new System.Drawing.Point(825, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(38, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(531, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "N° Factura:";
            // 
            // txt_numFactura
            // 
            this.txt_numFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_numFactura.Location = new System.Drawing.Point(622, 15);
            this.txt_numFactura.Name = "txt_numFactura";
            this.txt_numFactura.Size = new System.Drawing.Size(77, 26);
            this.txt_numFactura.TabIndex = 3;
            this.txt_numFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numFactura_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(520, 403);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "IVA:";
            // 
            // txt_iva
            // 
            this.txt_iva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_iva.Enabled = false;
            this.txt_iva.Location = new System.Drawing.Point(563, 403);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.ReadOnly = true;
            this.txt_iva.Size = new System.Drawing.Size(100, 13);
            this.txt_iva.TabIndex = 28;
            this.txt_iva.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(619, 427);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "A Cuenta Corriente:";
            // 
            // txt_cc
            // 
            this.txt_cc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_cc.Location = new System.Drawing.Point(763, 426);
            this.txt_cc.Name = "txt_cc";
            this.txt_cc.Size = new System.Drawing.Size(100, 26);
            this.txt_cc.TabIndex = 30;
            this.txt_cc.Text = "0";
            this.txt_cc.TextChanged += new System.EventHandler(this.txt_cc_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(637, 401);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 17);
            this.label13.TabIndex = 33;
            this.label13.Text = "Total:";
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_total.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_total.Location = new System.Drawing.Point(762, 398);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(100, 23);
            this.txt_total.TabIndex = 32;
            this.txt_total.Text = "0";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(333, 441);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(168, 41);
            this.btn_guardar.TabIndex = 34;
            this.btn_guardar.Text = "Registrar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_nuevoArticulo
            // 
            this.btn_nuevoArticulo.Location = new System.Drawing.Point(52, 168);
            this.btn_nuevoArticulo.Name = "btn_nuevoArticulo";
            this.btn_nuevoArticulo.Size = new System.Drawing.Size(85, 30);
            this.btn_nuevoArticulo.TabIndex = 23;
            this.btn_nuevoArticulo.Text = "nuevo articulo";
            this.btn_nuevoArticulo.UseVisualStyleBackColor = true;
            this.btn_nuevoArticulo.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = global::SGI.Properties.Resources.borrar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = global::SGI.Properties.Resources._206_search;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Location = new System.Drawing.Point(52, 58);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(70, 70);
            this.btn_buscar.TabIndex = 35;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_agregarDetalle
            // 
            this.btn_agregarDetalle.BackgroundImage = global::SGI.Properties.Resources._059_trolley;
            this.btn_agregarDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregarDetalle.Location = new System.Drawing.Point(809, 121);
            this.btn_agregarDetalle.Name = "btn_agregarDetalle";
            this.btn_agregarDetalle.Size = new System.Drawing.Size(70, 70);
            this.btn_agregarDetalle.TabIndex = 9;
            this.btn_agregarDetalle.UseVisualStyleBackColor = true;
            this.btn_agregarDetalle.Click += new System.EventHandler(this.btn_agregarDetalle_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(799, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Agregar al detalle";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 50);
            this.button1.TabIndex = 37;
            this.button1.Text = "Ingresar dinero";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_cantidad.Location = new System.Drawing.Point(280, 162);
            this.txt_cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(120, 26);
            this.txt_cantidad.TabIndex = 8;
            this.txt_cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_final
            // 
            this.txt_final.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_final.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_final.Location = new System.Drawing.Point(748, 456);
            this.txt_final.Name = "txt_final";
            this.txt_final.ReadOnly = true;
            this.txt_final.Size = new System.Drawing.Size(131, 29);
            this.txt_final.TabIndex = 39;
            this.txt_final.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(618, 465);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 17);
            this.label15.TabIndex = 40;
            this.label15.Text = "TOTAL A PAGAR:";
            // 
            // form_compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 519);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_final);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_cc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_iva);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_numFactura);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_nuevoArticulo);
            this.Controls.Add(this.btn_agregarDetalle);
            this.Controls.Add(this.dgv_detalle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_costo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_costo);
            this.Controls.Add(this.lbl_stock);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_proveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_fecha);
            this.Name = "form_compras";
            this.Text = "Registrar una Compra";
            this.Load += new System.EventHandler(this.form_compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_proveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lbl_nombre;
        public System.Windows.Forms.Label lbl_precio;
        public System.Windows.Forms.Label lbl_stock;
        public System.Windows.Forms.Label lbl_costo;
        public System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_detalle;
        private System.Windows.Forms.Button btn_agregarDetalle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_numFactura;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_iva;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_cc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_nuevoArticulo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown txt_cantidad;
        private System.Windows.Forms.TextBox txt_final;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
    }
}