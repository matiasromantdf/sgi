namespace SGI
{
    partial class form_ReporteReposicion
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ReposicionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BaseDeDatosDataSet = new SGI.BaseDeDatosDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboProveedor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ReposicionTableAdapter = new SGI.BaseDeDatosDataSetTableAdapters.ReposicionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReposicionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDeDatosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ReposicionBindingSource
            // 
            this.ReposicionBindingSource.DataMember = "Reposicion";
            this.ReposicionBindingSource.DataSource = this.BaseDeDatosDataSet;
            // 
            // BaseDeDatosDataSet
            // 
            this.BaseDeDatosDataSet.DataSetName = "BaseDeDatosDataSet";
            this.BaseDeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReposicionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGI.ReportReposicion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-3, 56);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(847, 394);
            this.reportViewer1.TabIndex = 0;
            // 
            // comboProveedor
            // 
            this.comboProveedor.FormattingEnabled = true;
            this.comboProveedor.Location = new System.Drawing.Point(237, 12);
            this.comboProveedor.Name = "comboProveedor";
            this.comboProveedor.Size = new System.Drawing.Size(121, 21);
            this.comboProveedor.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Proveedor:";
            // 
            // ReposicionTableAdapter
            // 
            this.ReposicionTableAdapter.ClearBeforeFill = true;
            // 
            // form_ReporteReposicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboProveedor);
            this.Controls.Add(this.reportViewer1);
            this.Name = "form_ReporteReposicion";
            this.Text = "Reporte para Reposición";
            this.Load += new System.EventHandler(this.form_ReporteReposicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReposicionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDeDatosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox comboProveedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource ReposicionBindingSource;
        private BaseDeDatosDataSet BaseDeDatosDataSet;
        private BaseDeDatosDataSetTableAdapters.ReposicionTableAdapter ReposicionTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}