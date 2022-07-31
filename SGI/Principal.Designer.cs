namespace SGI
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevoProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevoArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTodosLosArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoParaReposicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarArtiuculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeStockValuadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarBajaperdidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarGastoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPagoAProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeCuentasCorrientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeGstosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarInversionParaCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeComprasEntreFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPagoIVAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDelComercioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuarioVENDEDORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClaveADMINISTRADORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_vercaja = new System.Windows.Forms.Button();
            this.btn_repos = new System.Windows.Forms.Button();
            this.btn_compras = new System.Windows.Forms.Button();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imprimirComprobanteFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasToolStripMenuItem,
            this.artículosToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.cajaToolStripMenuItem,
            this.administraciónToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevoProveedorToolStripMenuItem,
            this.editarProveedorToolStripMenuItem,
            this.registrarCompraToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(97, 23);
            this.comprasToolStripMenuItem.Text = "Proveedores";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // registrarNuevoProveedorToolStripMenuItem
            // 
            this.registrarNuevoProveedorToolStripMenuItem.Name = "registrarNuevoProveedorToolStripMenuItem";
            this.registrarNuevoProveedorToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.registrarNuevoProveedorToolStripMenuItem.Text = "Registrar nuevo Proveedor";
            this.registrarNuevoProveedorToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevoProveedorToolStripMenuItem_Click);
            // 
            // editarProveedorToolStripMenuItem
            // 
            this.editarProveedorToolStripMenuItem.Name = "editarProveedorToolStripMenuItem";
            this.editarProveedorToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.editarProveedorToolStripMenuItem.Text = "Editar Proveedor";
            this.editarProveedorToolStripMenuItem.Click += new System.EventHandler(this.editarProveedorToolStripMenuItem_Click);
            // 
            // registrarCompraToolStripMenuItem
            // 
            this.registrarCompraToolStripMenuItem.Image = global::SGI.Properties.Resources.comprar;
            this.registrarCompraToolStripMenuItem.Name = "registrarCompraToolStripMenuItem";
            this.registrarCompraToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.registrarCompraToolStripMenuItem.Text = "Registrar compra";
            this.registrarCompraToolStripMenuItem.Click += new System.EventHandler(this.registrarCompraToolStripMenuItem_Click);
            // 
            // artículosToolStripMenuItem
            // 
            this.artículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevoArticuloToolStripMenuItem,
            this.listarTodosLosArticulosToolStripMenuItem,
            this.listadoParaReposicionToolStripMenuItem,
            this.consultarArtiuculoToolStripMenuItem,
            this.reporteDeStockValuadoToolStripMenuItem,
            this.registrarBajaperdidaToolStripMenuItem});
            this.artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
            this.artículosToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.artículosToolStripMenuItem.Text = "Artículos";
            // 
            // registrarNuevoArticuloToolStripMenuItem
            // 
            this.registrarNuevoArticuloToolStripMenuItem.Name = "registrarNuevoArticuloToolStripMenuItem";
            this.registrarNuevoArticuloToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.registrarNuevoArticuloToolStripMenuItem.Text = "Registrar nuevo articulo";
            this.registrarNuevoArticuloToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevoArticuloToolStripMenuItem_Click_1);
            // 
            // listarTodosLosArticulosToolStripMenuItem
            // 
            this.listarTodosLosArticulosToolStripMenuItem.Name = "listarTodosLosArticulosToolStripMenuItem";
            this.listarTodosLosArticulosToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.listarTodosLosArticulosToolStripMenuItem.Text = "Listar todos los articulos";
            this.listarTodosLosArticulosToolStripMenuItem.Click += new System.EventHandler(this.listarTodosLosArticulosToolStripMenuItem_Click);
            // 
            // listadoParaReposicionToolStripMenuItem
            // 
            this.listadoParaReposicionToolStripMenuItem.Name = "listadoParaReposicionToolStripMenuItem";
            this.listadoParaReposicionToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.listadoParaReposicionToolStripMenuItem.Text = "Listado para reposición";
            this.listadoParaReposicionToolStripMenuItem.Click += new System.EventHandler(this.listadoParaReposicionToolStripMenuItem_Click);
            // 
            // consultarArtiuculoToolStripMenuItem
            // 
            this.consultarArtiuculoToolStripMenuItem.Name = "consultarArtiuculoToolStripMenuItem";
            this.consultarArtiuculoToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.consultarArtiuculoToolStripMenuItem.Text = "Consultar o Editar articulo";
            this.consultarArtiuculoToolStripMenuItem.Click += new System.EventHandler(this.consultarArtiuculoToolStripMenuItem_Click);
            // 
            // reporteDeStockValuadoToolStripMenuItem
            // 
            this.reporteDeStockValuadoToolStripMenuItem.Name = "reporteDeStockValuadoToolStripMenuItem";
            this.reporteDeStockValuadoToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.reporteDeStockValuadoToolStripMenuItem.Text = "Reporte de stock valuado";
            this.reporteDeStockValuadoToolStripMenuItem.Click += new System.EventHandler(this.reporteDeStockValuadoToolStripMenuItem_Click);
            // 
            // registrarBajaperdidaToolStripMenuItem
            // 
            this.registrarBajaperdidaToolStripMenuItem.Name = "registrarBajaperdidaToolStripMenuItem";
            this.registrarBajaperdidaToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.registrarBajaperdidaToolStripMenuItem.Text = "Registrar Baja/perdida";
            this.registrarBajaperdidaToolStripMenuItem.Click += new System.EventHandler(this.registrarBajaperdidaToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVentaToolStripMenuItem,
            this.reporteDeVentasToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(62, 23);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // registrarVentaToolStripMenuItem
            // 
            this.registrarVentaToolStripMenuItem.Image = global::SGI.Properties.Resources.vender;
            this.registrarVentaToolStripMenuItem.Name = "registrarVentaToolStripMenuItem";
            this.registrarVentaToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.registrarVentaToolStripMenuItem.Text = "Registrar venta";
            this.registrarVentaToolStripMenuItem.Click += new System.EventHandler(this.registrarVentaToolStripMenuItem_Click);
            // 
            // reporteDeVentasToolStripMenuItem
            // 
            this.reporteDeVentasToolStripMenuItem.Name = "reporteDeVentasToolStripMenuItem";
            this.reporteDeVentasToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.reporteDeVentasToolStripMenuItem.Text = "Reporte de Ventas";
            this.reporteDeVentasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVentasToolStripMenuItem_Click);
            // 
            // cajaToolStripMenuItem
            // 
            this.cajaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verCajaToolStripMenuItem});
            this.cajaToolStripMenuItem.Name = "cajaToolStripMenuItem";
            this.cajaToolStripMenuItem.Size = new System.Drawing.Size(48, 23);
            this.cajaToolStripMenuItem.Text = "Caja";
            // 
            // verCajaToolStripMenuItem
            // 
            this.verCajaToolStripMenuItem.Name = "verCajaToolStripMenuItem";
            this.verCajaToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.verCajaToolStripMenuItem.Text = "Ver caja";
            this.verCajaToolStripMenuItem.Click += new System.EventHandler(this.verCajaToolStripMenuItem_Click);
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarGastoToolStripMenuItem,
            this.registrarPagoAProveedorToolStripMenuItem,
            this.reporteDeCuentasCorrientesToolStripMenuItem,
            this.reporteDeGstosToolStripMenuItem,
            this.ingresarInversionParaCompraToolStripMenuItem,
            this.reporteDeComprasEntreFechasToolStripMenuItem,
            this.registrarPagoIVAToolStripMenuItem,
            this.datosDelComercioToolStripMenuItem,
            this.imprimirComprobanteFiscalToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(116, 23);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // registrarGastoToolStripMenuItem
            // 
            this.registrarGastoToolStripMenuItem.Name = "registrarGastoToolStripMenuItem";
            this.registrarGastoToolStripMenuItem.Size = new System.Drawing.Size(287, 24);
            this.registrarGastoToolStripMenuItem.Text = "Registrar gasto o retiro";
            this.registrarGastoToolStripMenuItem.Click += new System.EventHandler(this.registrarGastoToolStripMenuItem_Click);
            // 
            // registrarPagoAProveedorToolStripMenuItem
            // 
            this.registrarPagoAProveedorToolStripMenuItem.Name = "registrarPagoAProveedorToolStripMenuItem";
            this.registrarPagoAProveedorToolStripMenuItem.Size = new System.Drawing.Size(287, 24);
            this.registrarPagoAProveedorToolStripMenuItem.Text = "Registrar Pago a Proveedor";
            this.registrarPagoAProveedorToolStripMenuItem.Click += new System.EventHandler(this.registrarPagoAProveedorToolStripMenuItem_Click);
            // 
            // reporteDeCuentasCorrientesToolStripMenuItem
            // 
            this.reporteDeCuentasCorrientesToolStripMenuItem.Name = "reporteDeCuentasCorrientesToolStripMenuItem";
            this.reporteDeCuentasCorrientesToolStripMenuItem.Size = new System.Drawing.Size(287, 24);
            this.reporteDeCuentasCorrientesToolStripMenuItem.Text = "Reporte de Cuentas Corrientes";
            this.reporteDeCuentasCorrientesToolStripMenuItem.Click += new System.EventHandler(this.reporteDeCuentasCorrientesToolStripMenuItem_Click);
            // 
            // reporteDeGstosToolStripMenuItem
            // 
            this.reporteDeGstosToolStripMenuItem.Name = "reporteDeGstosToolStripMenuItem";
            this.reporteDeGstosToolStripMenuItem.Size = new System.Drawing.Size(287, 24);
            this.reporteDeGstosToolStripMenuItem.Text = "Reporte de Gastos";
            this.reporteDeGstosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeGstosToolStripMenuItem_Click);
            // 
            // ingresarInversionParaCompraToolStripMenuItem
            // 
            this.ingresarInversionParaCompraToolStripMenuItem.Image = global::SGI.Properties.Resources.ingreso;
            this.ingresarInversionParaCompraToolStripMenuItem.Name = "ingresarInversionParaCompraToolStripMenuItem";
            this.ingresarInversionParaCompraToolStripMenuItem.Size = new System.Drawing.Size(287, 24);
            this.ingresarInversionParaCompraToolStripMenuItem.Text = "ingresar inversion para compra";
            this.ingresarInversionParaCompraToolStripMenuItem.Click += new System.EventHandler(this.ingresarInversionParaCompraToolStripMenuItem_Click_1);
            // 
            // reporteDeComprasEntreFechasToolStripMenuItem
            // 
            this.reporteDeComprasEntreFechasToolStripMenuItem.Name = "reporteDeComprasEntreFechasToolStripMenuItem";
            this.reporteDeComprasEntreFechasToolStripMenuItem.Size = new System.Drawing.Size(287, 24);
            this.reporteDeComprasEntreFechasToolStripMenuItem.Text = "Reporte de Compras entre Fechas";
            this.reporteDeComprasEntreFechasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeComprasEntreFechasToolStripMenuItem_Click);
            // 
            // registrarPagoIVAToolStripMenuItem
            // 
            this.registrarPagoIVAToolStripMenuItem.Name = "registrarPagoIVAToolStripMenuItem";
            this.registrarPagoIVAToolStripMenuItem.Size = new System.Drawing.Size(287, 24);
            this.registrarPagoIVAToolStripMenuItem.Text = "Registrar pago IVA";
            this.registrarPagoIVAToolStripMenuItem.Click += new System.EventHandler(this.registrarPagoIVAToolStripMenuItem_Click);
            // 
            // datosDelComercioToolStripMenuItem
            // 
            this.datosDelComercioToolStripMenuItem.Name = "datosDelComercioToolStripMenuItem";
            this.datosDelComercioToolStripMenuItem.Size = new System.Drawing.Size(287, 24);
            this.datosDelComercioToolStripMenuItem.Text = "Datos del Comercio...";
            this.datosDelComercioToolStripMenuItem.Click += new System.EventHandler(this.datosDelComercioToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuarioVENDEDORToolStripMenuItem,
            this.modificarClaveADMINISTRADORToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // crearUsuarioVENDEDORToolStripMenuItem
            // 
            this.crearUsuarioVENDEDORToolStripMenuItem.Image = global::SGI.Properties.Resources.agregarVendedor;
            this.crearUsuarioVENDEDORToolStripMenuItem.Name = "crearUsuarioVENDEDORToolStripMenuItem";
            this.crearUsuarioVENDEDORToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.crearUsuarioVENDEDORToolStripMenuItem.Text = "Crear usuario VENDEDOR";
            this.crearUsuarioVENDEDORToolStripMenuItem.Click += new System.EventHandler(this.crearUsuarioVENDEDORToolStripMenuItem_Click);
            // 
            // modificarClaveADMINISTRADORToolStripMenuItem
            // 
            this.modificarClaveADMINISTRADORToolStripMenuItem.Name = "modificarClaveADMINISTRADORToolStripMenuItem";
            this.modificarClaveADMINISTRADORToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.modificarClaveADMINISTRADORToolStripMenuItem.Text = "Cambiar Claves";
            this.modificarClaveADMINISTRADORToolStripMenuItem.Click += new System.EventHandler(this.modificarClaveADMINISTRADORToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem1});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(114, 24);
            this.salirToolStripMenuItem1.Text = "Salir...";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // btn_vercaja
            // 
            this.btn_vercaja.BackColor = System.Drawing.Color.Transparent;
            this.btn_vercaja.FlatAppearance.BorderSize = 0;
            this.btn_vercaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vercaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_vercaja.Image = global::SGI.Properties.Resources._071_wallet;
            this.btn_vercaja.Location = new System.Drawing.Point(31, 219);
            this.btn_vercaja.Name = "btn_vercaja";
            this.btn_vercaja.Size = new System.Drawing.Size(165, 134);
            this.btn_vercaja.TabIndex = 8;
            this.btn_vercaja.Text = "\r\nVer Caja";
            this.btn_vercaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_vercaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_vercaja.UseCompatibleTextRendering = true;
            this.btn_vercaja.UseVisualStyleBackColor = false;
            this.btn_vercaja.Click += new System.EventHandler(this.btn_vercaja_Click);
            // 
            // btn_repos
            // 
            this.btn_repos.BackColor = System.Drawing.Color.Transparent;
            this.btn_repos.FlatAppearance.BorderSize = 0;
            this.btn_repos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_repos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_repos.Image = global::SGI.Properties.Resources._065_standard_shipping;
            this.btn_repos.Location = new System.Drawing.Point(31, 59);
            this.btn_repos.Name = "btn_repos";
            this.btn_repos.Size = new System.Drawing.Size(165, 134);
            this.btn_repos.TabIndex = 7;
            this.btn_repos.Text = "\r\nReporte para Reposición";
            this.btn_repos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_repos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_repos.UseCompatibleTextRendering = true;
            this.btn_repos.UseVisualStyleBackColor = false;
            this.btn_repos.Click += new System.EventHandler(this.btn_repos_Click);
            // 
            // btn_compras
            // 
            this.btn_compras.BackColor = System.Drawing.Color.Transparent;
            this.btn_compras.FlatAppearance.BorderSize = 0;
            this.btn_compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_compras.Image = global::SGI.Properties.Resources._005_bill;
            this.btn_compras.Location = new System.Drawing.Point(583, 219);
            this.btn_compras.Name = "btn_compras";
            this.btn_compras.Size = new System.Drawing.Size(153, 134);
            this.btn_compras.TabIndex = 6;
            this.btn_compras.Text = "\r\nRegistrar Compras";
            this.btn_compras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_compras.UseCompatibleTextRendering = true;
            this.btn_compras.UseVisualStyleBackColor = false;
            this.btn_compras.Click += new System.EventHandler(this.btn_compras_Click);
            // 
            // btn_ventas
            // 
            this.btn_ventas.BackColor = System.Drawing.Color.Transparent;
            this.btn_ventas.FlatAppearance.BorderSize = 0;
            this.btn_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_ventas.Image = global::SGI.Properties.Resources._013_checkout1;
            this.btn_ventas.Location = new System.Drawing.Point(577, 60);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(153, 134);
            this.btn_ventas.TabIndex = 2;
            this.btn_ventas.Text = "\r\nRegistrar Ventas";
            this.btn_ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ventas.UseCompatibleTextRendering = true;
            this.btn_ventas.UseVisualStyleBackColor = false;
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SGI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(296, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // imprimirComprobanteFiscalToolStripMenuItem
            // 
            this.imprimirComprobanteFiscalToolStripMenuItem.Name = "imprimirComprobanteFiscalToolStripMenuItem";
            this.imprimirComprobanteFiscalToolStripMenuItem.Size = new System.Drawing.Size(287, 24);
            this.imprimirComprobanteFiscalToolStripMenuItem.Text = "Imprimir comprobante fiscal";
            this.imprimirComprobanteFiscalToolStripMenuItem.Click += new System.EventHandler(this.imprimirComprobanteFiscalToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.ControlBox = false;
            this.Controls.Add(this.btn_vercaja);
            this.Controls.Add(this.btn_repos);
            this.Controls.Add(this.btn_compras);
            this.Controls.Add(this.btn_ventas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevoProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUsuarioVENDEDORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarClaveADMINISTRADORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevoArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarTodosLosArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarArtiuculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarGastoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoParaReposicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeStockValuadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarBajaperdidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPagoAProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeCuentasCorrientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeGstosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarInversionParaCompraToolStripMenuItem;
        private System.Windows.Forms.Button btn_ventas;
        private System.Windows.Forms.Button btn_compras;
        private System.Windows.Forms.Button btn_repos;
        private System.Windows.Forms.Button btn_vercaja;
        private System.Windows.Forms.ToolStripMenuItem reporteDeComprasEntreFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPagoIVAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDelComercioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirComprobanteFiscalToolStripMenuItem;
    }
}