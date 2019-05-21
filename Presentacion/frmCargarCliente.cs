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
            this.Hide();
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

            //combo de tipo de telefono, le agrego las opciones a mano. Estas deberían ser de la base de datos en realidad.
            //pero nuestro teléfono debería a su vez tener un atributo clase TIPO para poder asignarlo.
            cmbTipoTel.Items.Add("Trabajo");
            cmbTipoTel.Items.Add("Casa");
            cmbTipoTel.Items.Add("Celular");
            //seteo el primero por default
            cmbTipoTel.SelectedIndex = 0;
        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {
            lblEdadNum.Text = (DateTime.Today.AddTicks(-dtpFechaNac.Value.Ticks).Year - 1).ToString();
        }

        private void txtDNI_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8 && txtDNI.TextLength == 8)
                e.Handled = true;
        }

        private void txtCUIL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtCUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
