using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class frmReporteFactura : Form
    {
        
        public frmReporteFactura()
        {
            InitializeComponent();
        }
        private void CargarGrillaCompras()
        {

            try
            {
                FacturaNegocio FN = new FacturaNegocio();
                dgvCompras.DataSource = FN.ListarFacturas(long.Parse(txtDNI.Text));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            frmClientes ventana = new frmClientes();
            ventana.ShowDialog();
            double total=0;
            if(ventana.DialogResult==DialogResult.OK)
            {
                txtDNI.Text = ventana.dgvClientes.Rows[ventana.dgvClientes.CurrentRow.Index].Cells[1].Value.ToString();
                CargarGrillaCompras();

            }
            foreach (DataGridViewRow Fila in dgvCompras.Rows)
            {
                total += Convert.ToDouble(Fila.Cells[7].Value);
            }
            txtTotal.Text = "$" + total.ToString();

        }

        
        private void FrmReporteFactura_Load(object sender, EventArgs e)
        {
            
        }
    }
}
