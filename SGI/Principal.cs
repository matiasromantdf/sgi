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
    public partial class Principal : Form
    {
        public string Rol;
        public Principal(string rol)
        {
            Rol = rol;
            InitializeComponent();
        }

        private void registrarNuevoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_NuevoProveedor f = new form_NuevoProveedor();
            f.ShowDialog();

        }

        private void registrarNuevoArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_NuevoArticulo f = new form_NuevoArticulo();
            f.ShowDialog();
        }

        private void verCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_VerCaja f = new form_VerCaja();
            f.ShowDialog();
        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_ventas f = new form_ventas();
            f.ShowDialog();
        }

        private void registrarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_compras f = new form_compras();
            f.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            if (Rol=="ventas")
            {
                comprasToolStripMenuItem.Visible = false;
                cajaToolStripMenuItem.Visible = false;
                usuariosToolStripMenuItem.Visible = false;
                administraciónToolStripMenuItem.Visible = false;
                registrarNuevoArticuloToolStripMenuItem.Visible = false;
                listadoParaReposicionToolStripMenuItem.Visible = false;
                reporteDeStockValuadoToolStripMenuItem.Visible = false;
                registrarBajaperdidaToolStripMenuItem.Visible = false;
                reporteDeVentasToolStripMenuItem.Visible = false;
                btn_vercaja.Visible = false;
                btn_repos.Visible = false;
                btn_compras.Visible = false;
                registrarPagoIVAToolStripMenuItem.Visible = false;

                
            }

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearAdmin f = new CrearAdmin();
            f.ShowDialog();
        }

        private void crearUsuarioVENDEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_crearVendedor f = new form_crearVendedor();
            f.ShowDialog();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarNuevoArticuloToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            form_NuevoArticulo f = new form_NuevoArticulo();
            f.Show();
        }

        private void listadoParaReposicionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           form_ReporteReposicion f = new form_ReporteReposicion();
            
            f.Show();
        }

        private void listarTodosLosArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           form_ListadoArticulos f = new form_ListadoArticulos();
          f.Show();
        }

        private void ingresarInversionParaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_inversion f = new form_inversion();
            f.ShowDialog();
        }

        private void modificarClaveADMINISTRADORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_cambiarClaves f = new form_cambiarClaves();
            f.ShowDialog();

        }

        private void modificarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_reporte_ventas f = new form_reporte_ventas();
            f.ShowDialog();
        }

        private void reporteDeStockValuadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_stck_valuado f = new form_stck_valuado();
            f.ShowDialog();
        }

        private void registrarInversiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_editarProveedor f = new form_editarProveedor();
            f.ShowDialog();
        }

        private void registrarBajaperdidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_bajaArticulo f = new form_bajaArticulo();
            f.ShowDialog();
        }

        private void consultarArtiuculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_consultarArticulo f = new form_consultarArticulo();
            f.ShowDialog();
        }

        private void registrarPagoAProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_pagoaProveedor f = new form_pagoaProveedor();
            f.ShowDialog();
        }

        private void reporteDeCuentasCorrientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_resporCC f = new form_resporCC();
            f.ShowDialog();
        }

        private void registrarGastoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_registrarGastos f = new form_registrarGastos();
            f.ShowDialog();
        }

        private void reporteDeGstosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_reporteGastos f = new form_reporteGastos();
                f.ShowDialog();
        }

        private void ingresarInversionParaCompraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            form_inversion f = new form_inversion();
            f.ShowDialog();
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            form_ventas f = new form_ventas();
            f.ShowDialog();
        }

        private void btn_compras_Click(object sender, EventArgs e)
        {
            form_compras f = new form_compras();
            f.ShowDialog();
        }

        private void btn_repos_Click(object sender, EventArgs e)
        {
            form_ReporteReposicion f = new form_ReporteReposicion();
            f.ShowDialog();
        }

        private void btn_vercaja_Click(object sender, EventArgs e)
        {
            form_VerCaja f = new form_VerCaja();
            f.ShowDialog();
        }

        private void reporteDeComprasEntreFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_reporteCompras f = new form_reporteCompras();
            f.ShowDialog();
        }

        private void registrarPagoIVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_pagoIva f = new form_pagoIva();
            f.ShowDialog();
        }

        private void datosDelComercioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_DatosComercio f = new form_DatosComercio();
            f.ShowDialog();
        }

        private void imprimirComprobanteFiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImprimirFacturas i = new ImprimirFacturas();
            i.ShowDialog();
        }
    }
}
