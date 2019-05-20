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
    public partial class frmCargarCliente : Form
    {
        private Cliente cliente;

        public frmCargarCliente()
        {
            InitializeComponent();
            cliente = new Cliente();
        }

        public frmCargarCliente(Cliente cli)
        {
            InitializeComponent();
            cliente = cli;
        }

        private void BorrarRegistros()
        {
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            ClientesNegocio serv = new ClientesNegocio();

            try
            {
                cliente.nombre = txtNombre.Text.Trim();
                cliente.apellido = txtApellido.Text.Trim();
                cliente.DNI = Convert.ToInt32(txtDNI.Text.Trim());
                // contacto.Localidad = (Localidad)cboLocalidad.SelectedItem;

                if (this.Text != "Modificando")
                {
                    serv.AgregarCliente(cliente);
                    MessageBox.Show("Agregado correctamente!");
                }
                else
                {
                    serv.ModificarCliente(cliente);
                    MessageBox.Show("Modificado correctamente!");
                }

                this.Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error FATAL. " + ex.ToString(), "", MessageBoxButtons.OK);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
        }

        private void frmCargarCliente_Load(object sender, EventArgs e)
        {
            if (Text == "Modificando")
            {
                txtApellido.Text = cliente.apellido;
                txtNombre.Text = cliente.nombre;
                txtDNI.Text = Convert.ToString(cliente.DNI);
            }
            else
            {
          
            }
        }
    }
}
