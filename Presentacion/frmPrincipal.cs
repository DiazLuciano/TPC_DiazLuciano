using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

        }

        private void pbCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            frmClientes clientes = new frmClientes();
            clientes.Show();
        }

        private void pbProducto_Click(object sender, EventArgs e)
        {
            this.Close();
            frmArticulos articulos = new frmArticulos();
            articulos.Show();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
                
        }

        private void pbMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pbMaximizar.Visible = false;
            pbRestaurar.Visible = true;
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;         
        }

        private void pbRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            pbRestaurar.Visible = false;
            pbMaximizar.Visible = true;
        }

        private void PbCompra_Click(object sender, EventArgs e)
        {
            frmFacturacion factura = new frmFacturacion();
            factura.Show();
        }
    }
}
