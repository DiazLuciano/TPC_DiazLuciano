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
    public partial class frmDetalleCliente : Form
    {
        private Cliente cli = null;
        public frmDetalleCliente()
        {
            InitializeComponent();
        }

        public frmDetalleCliente(Cliente cliente)
        {
            InitializeComponent();
            cli = cliente;
        }

        private void FrmDetalleCliente_Load(object sender, EventArgs e)
        {
            txtDNI.Text = Convert.ToString(cli.DNI);
            txtNombre.Text = cli.nombre;
            txtApellido.Text = cli.apellido;
            txtDireccion.Text = cli.direccion;
            txtLocalidad.Text = cli.Localidad;
            txtCP.Text = Convert.ToString(cli.CP);
            txtCiudad.Text = cli.Ciudad;
            txtProvincia.Text = cli.Provincia;
            txtCUILCUIT.Text = Convert.ToString(cli.CUILCUIT);
            txtEmail.Text = cli.Email;
            txtEdad.Text = cli.edad.ToString();
            txtFechaNac.Text = cli.fnac.ToString();
            txtFechaAlta.Text = cli.fecha_alta.ToString();
            txtTipoP.Text = cli.tipo.ToString();
            txtRazonS.Text = cli.razonsocial;
            txtGenero.Text = cli.genero.ToString();
            txtID.Text = cli.IDCliente.ToString();


        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
