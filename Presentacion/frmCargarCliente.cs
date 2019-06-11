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
        private Cliente cli;
        private Telefono tel;
        private AccesoDatos AD;
        private IList<Telefono> listaTelefonosNuevos = new List<Telefono>();
  

        public frmCargarCliente()
        {
            InitializeComponent();
            cli = new Cliente();
            tel = new Telefono();
        }

        public frmCargarCliente(Cliente cliente)
        {
            InitializeComponent();
            cli = cliente;
 
        }

        private void BorrarRegistros()
        {
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";

        }

        private void frmCargarCliente_Load(object sender, EventArgs e)
        {


            if (Text == "Modificando")
            {
                txtDNI.Text = Convert.ToString(cli.DNI);
                txtNombre.Text = cli.nombre;
                txtApellido.Text = cli.apellido;
                txtDireccion.Text = cli.direccion;
                txtLocalidad.Text = cli.Localidad;
                txtCP.Text = Convert.ToString(cli.CP);
                txtCiudad.Text = cli.Ciudad;
                txtProvincia.Text = cli.Provincia;
                txtCUIL.Text = Convert.ToString(cli.CUIL);
                txtCUIT.Text = Convert.ToString(cli.CUIT);
                dtpFechaNac.Value = cli.fnac;
                txtEmail.Text = cli.Email;


                switch (cli.genero)
                {
                    case 'F':
                        rdbFemenino.Checked = true;
                        break;
                    case 'M':
                        rdbMasculino.Checked = true;
                        break;
                    case 'O':
                        rdbOtro.Checked = true;
                        break;
                }
                if (cli.tipo == 'F')
                {
                    chbFisica.Checked = true;
                    //chbJuridica.Checked = false;
                }
                else
                {
                    chbJuridica.Checked = true;
                    // chbFisica.Checked = false;
                }
                // txtTelefono.Text = Convert.ToString(cli.telefonos);
            }
            else
            {
                listaTelefonosNuevos = new List<Telefono>();
                AD = new AccesoDatos();
            }

            //combo de tipo de telefono, le agrego las opciones a mano. Estas deberían ser de la base de datos en realidad.
            //pero nuestro teléfono debería a su vez tener un atributo clase TIPO para poder asignarlo.
            cmbTipoTel.Items.Add("Trabajo");
            cmbTipoTel.Items.Add("Casa");
            cmbTipoTel.Items.Add("Celular");
            //seteo el primero por default
            cmbTipoTel.SelectedIndex = 0;
            //Tipo de Persona por default

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if(AccesoDatos.ValidarFormulario(this,errorProvider1)==false)
            {
                ClientesNegocio serv = new ClientesNegocio();
                TelefonoNegocio TN = new TelefonoNegocio();
                tel = new Telefono();
                try
                {
                    cli.DNI = Convert.ToInt32(txtDNI.Text.ToString().Trim());
                    cli.nombre = txtNombre.Text.ToString().Trim();
                    cli.apellido = txtApellido.Text.ToString().Trim();
                    cli.genero = Convert.ToChar(rdbMasculino.Checked == true ? "M" : rdbFemenino.Checked == true ? "F" : "O");
                    cli.fnac = dtpFechaNac.Value;
                    cli.fecha_alta = DateTime.Today;
                    cli.edad = Convert.ToInt32(lblEdadNum.Text.ToString().Trim());
                    cli.Email = txtEmail.Text.ToString().Trim();
                    cli.direccion = txtDireccion.Text.ToString().Trim();
                    cli.CP = int.Parse(txtCP.Text);
                    cli.Localidad = txtLocalidad.Text.ToString().Trim();
                    cli.Ciudad = txtCiudad.Text.ToString().Trim();
                    cli.Provincia = txtProvincia.Text.ToString().Trim();
                    cli.tipo = Convert.ToChar(chbFisica.Checked == true ? "F" : "J");
                    if (chbFisica.Checked == true)
                    { cli.CUIL = Convert.ToInt64(txtCUIL.Text.ToString().Trim()); }
                    else
                    {
                        cli.CUIT = Convert.ToInt64(txtCUIT.Text.ToString().Trim());
                        cli.razonsocial = txtRazonS.Text.ToString().Trim();
                    }

                    if (this.Text != "Modificando")
                    {

                        serv.AgregarCliente(cli);
                        long idcli = serv.BuscarId();
                        tel.telefono = txtTelefono.Text.ToString().Trim();
                        tel.tipotelefono = cmbTipoTel.Text.ToString().Trim();
                        listaTelefonosNuevos.Add(tel);
                        TN.agregar(tel, idcli);
                        MessageBox.Show("Agregado correctamente!");
                    }
                    else
                    {
                        serv.ModificarCliente(cli);
                        tel.IDCliente = cli.IDCliente;
                        tel.telefono = txtTelefono.Text.ToString().Trim();
                        tel.tipotelefono = cmbTipoTel.Text.ToString().Trim();
                        listaTelefonosNuevos.Add(tel);
                        TN.agregar(tel, cli.IDCliente);
                        MessageBox.Show("Modificado correctamente!");
                    }

                    this.Dispose();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error FATAL. " + ex.ToString(), "", MessageBoxButtons.OK);
                }
            }
            this.Close();
            frmClientes verClientes = new frmClientes();
            verClientes.Show();
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

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
            //if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
            //    e.Handled = true;
        }

        private void txtCUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
            //    e.Handled = true;
        }

        private void chbFisica_Click(object sender, EventArgs e)
        {
            chbJuridica.Checked = false;
            txtRazonS.Enabled = false;
            txtCUIT.Enabled = false;
            txtCUIL.Enabled = true;
        }

        private void chbJuridica_Click(object sender, EventArgs e)
        {
            chbFisica.Checked = false;
            txtRazonS.Enabled = true;
            txtCUIT.Enabled = true;
            txtCUIL.Enabled = false;
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
            telNuevo.telefono = txtTelefono.Text.ToString().Trim();
            telNuevo.tipotelefono = cmbTipoTel.SelectedItem.ToString().Trim();
            //lo agrego a la lista
            listaTelefonosNuevos.Add(telNuevo);
            //limpio la grilla y le doy la lista de nuevo
            

        }

       

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
