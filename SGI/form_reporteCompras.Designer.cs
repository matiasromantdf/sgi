namespace SGI
{
    partial class form_reporteCompras
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
            this.reporComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BaseDeDatosDataSet = new SGI.BaseDeDatosDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.fecha1 = new System.Windows.Forms.DateTimePicker();
            this.fecha2 = new System.Windows.Forms.DateTimePicker();
            this.reporComprasTableAdapter = new SGI.BaseDeDatosDataSetTableAdapters.reporComprasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporComprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDeDatosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reporComprasBindingSource
            // 
            this.reporComprasBindingSource.DataMember = "reporCompras";
            this.reporComprasBindingSource.DataSource = this.BaseDeDatosDataSet;
            // 
            // BaseDeDatosDataSet
            // 
            this.BaseDeDatosDataSet.DataSetName = "BaseDeDatosDataSet";
            this.BaseDeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporComprasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGI.Report_compras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(43, 58);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(719, 364);
            this.reportViewer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "ver datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fecha1
            // 
            this.fecha1.Location = new System.Drawing.Point(104, 21);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(200, 20);
            this.fecha1.TabIndex = 2;
            // 
            // fecha2
            // 
            this.fecha2.Location = new System.Drawing.Point(364, 21);
            this.fecha2.Name = "fecha2";
            this.fecha2.Size = new System.Drawing.Size(200, 20);
            this.fecha2.TabIndex = 3;
            // 
            // reporComprasTableAdapter
            // 
            this.reporComprasTableAdapter.ClearBeforeFill = true;
            // 
            // form_reporteCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fecha2);
            this.Controls.Add(this.fecha1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "form_reporteCompras";
            this.Text = "Reporte de Compras";
            this.Load += new System.EventHandler(this.form_reporteCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporComprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDeDatosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporComprasBindingSource;
        private BaseDeDatosDataSet BaseDeDatosDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker fecha1;
        private System.Windows.Forms.DateTimePicker fecha2;
        private BaseDeDatosDataSetTableAdapters.reporComprasTableAdapter reporComprasTableAdapter;
    }
}