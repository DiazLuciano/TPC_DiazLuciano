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
        private IList<Telefono> listaTelefonosNuevos;

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
                cliente.localidad.CP = Convert.ToInt32(txtCP.Text.Trim());
                cliente.direccion=txtDireccion.Text.Trim();
                cliente.localidad.nombre = txtLocalidad.Text.Trim();
                cliente.localidad.Pais = txtPais.Text.Trim();
                cliente.localidad.Provincia = txtProvincia.Text.Trim();
                cliente.tipo = chbFisica.Checked == true ? "Fisica" : "Juridica";


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
                txtDireccion.Text = cliente.direccion.ToString();
                txtCUILCUIT.Text = Convert.ToString(cliente.CUIL);
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
            //Tipo de Persona por default
            chbFisica.Checked = true;
        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {
            lblEdadNum.Text = (DateTime.Today.AddTicks(-dtpFechaNac.Value.Ticks).Year - 1).ToString();
        }

        private void txtDNI_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && (e.KeyChar != 8))
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

        private void chbFisica_Click(object sender, EventArgs e)
        {
            chbJuridica.Checked = false;
        }

        private void chbJuridica_Click(object sender, EventArgs e)
        {
            chbFisica.Checked = false;
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btbAgregarTel_Click(object sender, EventArgs e)
        {
            //agregar el telefono a la lista y la lista a la grilla
            //creo un objeto telefono
            Telefono telNuevo = new Telefono();
            //lo cargo con los datos
            telNuevo.telefono = txtTelefono.Text.Trim();
            telNuevo.tipotelefono = cmbTipoTel.SelectedItem.ToString();
            //lo agrego a la lista
            listaTelefonosNuevos.Add(telNuevo);
            //limpio la grilla y le doy la lista de nuevo
            /*dgvTelefonos.DataSource = null;
            dgvTelefonos.DataSource = listaTelefonosNuevos;
            dgvTelefonos.Columns[0].Visible = false;*/
        }

        private void txtRazonS_TextChanged(object sender, EventArgs e)
        {
            if(chbJuridica.Checked==true)
            {
                txtRazonS.Enabled = true;
            }
        }
    }
}
