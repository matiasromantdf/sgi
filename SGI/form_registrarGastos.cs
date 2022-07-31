using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace SGI
{
    public partial class form_registrarGastos : Form
    {
        Gastos gastos = new Gastos();
        Caja caja = new Caja();


        public form_registrarGastos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_monto.Text != "" & txt_fecha.Value != null)
            {
                gastos.detalle = txt_detalle.Text;
                gastos.fecha = txt_fecha.Value;
                gastos.monto = float.Parse(txt_monto.Text);
                
                if (radio_retiro.Checked)
                {
                    gastos.esRetiro = true;
                }
                else gastos.esRetiro = false;

                if (gastos.Registrar() == "correcto" && caja.ActualizarGanancia(float.Parse(txt_monto.Text)*-1)=="correcto")
                {
                    MessageBox.Show("Regsitrado correctamente");
                    Dispose();
                }
                else MessageBox.Show("No se pudo registrar en Base de datos");

            }
            else MessageBox.Show("complete todos los campos");
        }

        private void form_registrarGastos_Load(object sender, EventArgs e)
        {
            radio_gasto.Checked = true;

        }
    }
}
