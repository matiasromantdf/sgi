namespace SGI
{
    partial class form_resporCC
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.reportCCproveedor1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BaseDeDatosDataSet = new SGI.BaseDeDatosDataSet();
            this.reportCCproveedor1TableAdapter = new SGI.BaseDeDatosDataSetTableAdapters.reportCCproveedor1TableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.listarDeudaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listarDeudaTableAdapter = new SGI.BaseDeDatosDataSetTableAdapters.listarDeudaTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportCCproveedor1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDeDatosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarDeudaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 419);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ver Pagos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 15;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.reportCCproveedor1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGI.Report_CCproveedores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(18, 62);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(725, 303);
            this.reportViewer1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(386, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "estado de CC";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Indique el Proveedor para ver Historial de pagos";
            // 
            // reportCCproveedor1BindingSource
            // 
            this.reportCCproveedor1BindingSource.DataMember = "reportCCproveedor1";
            this.reportCCproveedor1BindingSource.DataSource = this.BaseDeDatosDataSet;
            // 
            // BaseDeDatosDataSet
            // 
            this.BaseDeDatosDataSet.DataSetName = "BaseDeDatosDataSet";
            this.BaseDeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportCCproveedor1TableAdapter
            // 
            this.reportCCproveedor1TableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.listarDeudaBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "SGI.Report_deuda.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(6, 25);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(729, 285);
            this.reportViewer2.TabIndex = 0;
            // 
            // listarDeudaBindingSource
            // 
            this.listarDeudaBindingSource.DataMember = "listarDeuda";
            this.listarDeudaBindingSource.DataSource = this.BaseDeDatosDataSet;
            // 
            // listarDeudaTableAdapter
            // 
            this.listarDeudaTableAdapter.ClearBeforeFill = true;
            // 
            // form_resporCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "form_resporCC";
            this.Text = "Reportes  de cuentas corrientes";
            this.Load += new System.EventHandler(this.form_resporCC_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportCCproveedor1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDeDatosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarDeudaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource reportCCproveedor1BindingSource;
        private BaseDeDatosDataSet BaseDeDatosDataSet;
        private BaseDeDatosDataSetTableAdapters.reportCCproveedor1TableAdapter reportCCproveedor1TableAdapter;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource listarDeudaBindingSource;
        private BaseDeDatosDataSetTableAdapters.listarDeudaTableAdapter listarDeudaTableAdapter;
    }
}