using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGI
{
    public partial class form_reporteGastos : Form
    {
        public form_reporteGastos()
        {
            InitializeComponent();
        }

        private void form_reporteGastos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BaseDeDatosDataSet.proc_gastos' Puede moverla o quitarla según sea necesario.
            combo_tipo.SelectedIndex = 0;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime f1, f2;
            bool tipo;
            f1 = txt_fecha1.Value;
            f2 = txt_fecha2.Value;
            tipo = combo_tipo.SelectedIndex == 0? false : true;

            ReportParameter[] reportParameters = new ReportParameter[1];
            reportParameters[0] = new ReportParameter("titulo", combo_tipo.Text, false);
            reportViewer1.LocalReport.SetParameters(reportParameters);
            this.proc_gastosTableAdapter.Fill(this.BaseDeDatosDataSet.proc_gastos,f1,f2,tipo);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
