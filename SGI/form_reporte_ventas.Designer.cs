namespace SGI
{
    partial class form_reporte_ventas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ventaporfechasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BaseDeDatosDataSet = new SGI.BaseDeDatosDataSet();
            this.fecha_desde = new System.Windows.Forms.DateTimePicker();
            this.fecha_hasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ventaporfechasTableAdapter = new SGI.BaseDeDatosDataSetTableAdapters.ventaporfechasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ventaporfechasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDeDatosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ventaporfechasBindingSource
            // 
            this.ventaporfechasBindingSource.DataMember = "ventaporfechas";
            this.ventaporfechasBindingSource.DataSource = this.BaseDeDatosDataSet;
            // 
            // BaseDeDatosDataSet
            // 
            this.BaseDeDatosDataSet.DataSetName = "BaseDeDatosDataSet";
            this.BaseDeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fecha_desde
            // 
            this.fecha_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_desde.Location = new System.Drawing.Point(79, 12);
            this.fecha_desde.Name = "fecha_desde";
            this.fecha_desde.Size = new System.Drawing.Size(200, 26);
            this.fecha_desde.TabIndex = 0;
            // 
            // fecha_hasta
            // 
            this.fecha_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fecha_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_hasta.Location = new System.Drawing.Point(405, 12);
            this.fecha_hasta.Name = "fecha_hasta";
            this.fecha_hasta.Size = new System.Drawing.Size(200, 26);
            this.fecha_hasta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desde:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(655, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(341, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta:";
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ventaporfechasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGI.reporte_venta_fechas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 49);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 358);
            this.reportViewer1.TabIndex = 5;
            // 
            // ventaporfechasTableAdapter
            // 
            this.ventaporfechasTableAdapter.ClearBeforeFill = true;
            // 
            // form_reporte_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 449);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fecha_hasta);
            this.Controls.Add(this.fecha_desde);
            this.Name = "form_reporte_ventas";
            this.Text = "Reporte de Ventas";
            this.Load += new System.EventHandler(this.form_reporte_ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventaporfechasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDeDatosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fecha_desde;
        private System.Windows.Forms.DateTimePicker fecha_hasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ventaporfechasBindingSource;
        private BaseDeDatosDataSet BaseDeDatosDataSet;
        private BaseDeDatosDataSetTableAdapters.ventaporfechasTableAdapter ventaporfechasTableAdapter;
    }
}