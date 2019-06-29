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
    public partial class frmClientes : Form
    {

        public List<Cliente> ListaC;
        public frmClientes()
        {
            InitializeComponent();
        }

        private void CargarGrillaClientes()
        {

            try
            {
                ClientesNegocio cliN = new ClientesNegocio();
                dgvClientes.DataSource = cliN.ListarClientes();

                dgvClientes.Columns[4].Visible = false;
                dgvClientes.Columns[6].Visible = false;
                dgvClientes.Columns[7].Visible = false;
                dgvClientes.Columns[10].Visible = false;
                dgvClientes.Columns[12].Visible = false;
                dgvClientes.Columns[13].Visible = false;
                dgvClientes.Columns[14].Visible = false;
                dgvClientes.Columns[13].Visible = false;
                dgvClientes.Columns[14].Visible = false;
                dgvClientes.Columns[15].Visible = false;
                dgvClientes.Columns[16].Visible = false;
                dgvClientes.Columns[17].Visible = false;
                dgvClientes.Columns[18].Visible = false;
                dgvClientes.Columns[19].Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("FALLO " + ex.ToString());
            }

        }

        private void VerClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
        }

        private void VerClientes_Load(object sender, EventArgs e)
        {
            CargarGrillaClientes();
            cmbBuscarPor.Items.Add("DNI");
            cmbBuscarPor.Items.Add("Nombre/Apellido");
            cmbBuscarPor.SelectedIndex = 0;
        }

        private void pbAgregarCliente_Click(object sender, EventArgs e)
        {
            
            frmCargarCliente VentanaCargarCliente = new frmCargarCliente();
            VentanaCargarCliente.Show();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

       


        private void pbModificarCliente_Click(object sender, EventArgs e)
        {
            
            try
            {
                Cliente cli = new Cliente();
                cli = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                frmCargarCliente modificar = new frmCargarCliente(cli);
                modificar.Text = "Modificando";
                modificar.ShowDialog();
                CargarGrillaClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pbEliminarCliente_Click(object sender, EventArgs e)
        {
            ClientesNegocio serv = new ClientesNegocio();
            try
            {
                if (MessageBox.Show("Está seguro de elimnar lógicamente al Cliente?", "Eliminar", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
                Cliente cli = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                serv.eliminarFisico(cli);
                CargarGrillaClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            ClientesNegocio CN = new ClientesNegocio();

            try
            {
                dgvClientes.DataSource = CN.Buscar(cmbBuscarPor.SelectedItem.ToString(), txtDescripcion.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No buscó nada,rompio");
                throw ex;

            }
        }

        private void PbTelefonos_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            //guardo el item seleccionado, lo casteo a Cliente, porque sé que es uno...
            cli = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            //creo una instancia de la ventana de telefonos y le paso los telefonos del Cliente seleccionado
            //por el constructor nuevo que agregamos.
            frmTelefonos ventanaTelefonos = new frmTelefonos(cli.telefonos,cli);
            ventanaTelefonos.Show();
            
            
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            frmDetalleCliente detalle = new frmDetalleCliente((Cliente)dgvClientes.CurrentRow.DataBoundItem);
            detalle.ShowDialog();
        }

        private void BtnEliminarLog_Click(object sender, EventArgs e)
        {
            ClientesNegocio serv = new ClientesNegocio();
            try
            {
                if (MessageBox.Show("Está seguro de elimnar fisicamente al Cliente?", "Eliminar", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
                Cliente cli = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                serv.eliminarLogico(cli);
                CargarGrillaClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if(dgvClientes.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
