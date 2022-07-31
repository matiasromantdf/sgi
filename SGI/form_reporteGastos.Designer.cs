namespace SGI
{
    partial class form_reporteGastos
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
            this.proc_gastosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BaseDeDatosDataSet = new SGI.BaseDeDatosDataSet();
            this.combo_tipo = new System.Windows.Forms.ComboBox();
            this.txt_fecha2 = new System.Windows.Forms.DateTimePicker();
            this.txt_fecha1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.proc_gastosTableAdapter = new SGI.BaseDeDatosDataSetTableAdapters.proc_gastosTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proc_gastosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDeDatosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // proc_gastosBindingSource
            // 
            this.proc_gastosBindingSource.DataMember = "proc_gastos";
            this.proc_gastosBindingSource.DataSource = this.BaseDeDatosDataSet;
            // 
            // BaseDeDatosDataSet
            // 
            this.BaseDeDatosDataSet.DataSetName = "BaseDeDatosDataSet";
            this.BaseDeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combo_tipo
            // 
            this.combo_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_tipo.FormattingEnabled = true;
            this.combo_tipo.Items.AddRange(new object[] {
            "Gasto",
            "Retiro"});
            this.combo_tipo.Location = new System.Drawing.Point(523, 39);
            this.combo_tipo.Name = "combo_tipo";
            this.combo_tipo.Size = new System.Drawing.Size(130, 28);
            this.combo_tipo.TabIndex = 0;
            // 
            // txt_fecha2
            // 
            this.txt_fecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha2.Location = new System.Drawing.Point(264, 41);
            this.txt_fecha2.Name = "txt_fecha2";
            this.txt_fecha2.Size = new System.Drawing.Size(218, 26);
            this.txt_fecha2.TabIndex = 1;
            // 
            // txt_fecha1
            // 
            this.txt_fecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha1.Location = new System.Drawing.Point(30, 41);
            this.txt_fecha1.Name = "txt_fecha1";
            this.txt_fecha1.Size = new System.Drawing.Size(200, 26);
            this.txt_fecha1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(683, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.proc_gastosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGI.Report_gastos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(24, 101);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(749, 305);
            this.reportViewer1.TabIndex = 4;
            // 
            // proc_gastosTableAdapter
            // 
            this.proc_gastosTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hasta:";
            // 
            // form_reporteGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_fecha1);
            this.Controls.Add(this.txt_fecha2);
            this.Controls.Add(this.combo_tipo);
            this.Name = "form_reporteGastos";
            this.Text = "Reporte de Gastos ";
            this.Load += new System.EventHandler(this.form_reporteGastos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proc_gastosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDeDatosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_tipo;
        private System.Windows.Forms.DateTimePicker txt_fecha2;
        private System.Windows.Forms.DateTimePicker txt_fecha1;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource proc_gastosBindingSource;
        private BaseDeDatosDataSet BaseDeDatosDataSet;
        private BaseDeDatosDataSetTableAdapters.proc_gastosTableAdapter proc_gastosTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}