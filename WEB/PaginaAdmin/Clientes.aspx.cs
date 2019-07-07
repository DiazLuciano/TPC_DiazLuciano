using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace WEB
{
    public partial class Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) // si es la primera vez
            {
                txtFecha.Text = DateTime.Now.ToString("yyyy-mm-dd");
                if (Request.QueryString["ID"] != null) //si es nulo vino por el nuevo, sino a modificar
                {
                    long id = Convert.ToInt64(Request.QueryString["ID"]);
                    CargarDatos(id);
                }

            }

        }

        private void CargarDatos(long id)
        {
            Cliente cli = new Cliente();
            AccesoDatos AD = new AccesoDatos();

            AD.setearConsulta("select * from clientes as c inner join telefonos as t on t.dnicliente =c.dni where c.id = " + id);
            AD.abrirConexion();
            AD.ejecutarConsulta();
            AD.Lector.Read();

            txtDNI.Text = (string)AD.Lector["DNI"].ToString();
            txtNombre.Text = (string)AD.Lector["Nombre"];
            txtApellido.Text = (string)AD.Lector["Apellido"];
            txtDireccion.Text = (string)AD.Lector["Direccion"];
            txtLocalidad.Text = (string)AD.Lector["Localidad"];
            txtCP.Text = (string)AD.Lector["CP"].ToString();
            txtCiudad.Text = (string)AD.Lector["Ciudad"];
            txtProvincia.Text = (string)AD.Lector["Provincia"];
            txtCUILCUIT.Text = (string)AD.Lector["CUILCUIT"];
            txtFecha.Text = (string)AD.Lector["Fnac"];
            txtEmail.Text = (string)AD.Lector["Email"];
            txtTelefono.Text = (string)AD.Lector["Telefono"].ToString();
            txtEdad.Text = (string)AD.Lector["Edad"].ToString();
            ddlTipoTel.SelectedValue = (string)AD.Lector["TipoTel"];
            ddlSexo.SelectedValue = (string)AD.Lector["Genero"];
        }

        private Cliente GetEntityC()
        {
            Telefono tel = new Telefono();
            Cliente cli = new Cliente();

            cli.DNI = Convert.ToInt64(txtDNI.Text);
            cli.nombre = txtNombre.Text;
            cli.apellido = txtApellido.Text;
            cli.direccion = txtDireccion.Text;
            cli.Localidad = txtLocalidad.Text;
            cli.CP = Convert.ToInt32(txtCP.Text);
            cli.Ciudad = txtCiudad.Text;
            cli.Provincia = txtProvincia.Text;
            cli.CUILCUIT = Convert.ToInt64(txtCUILCUIT.Text);
            cli.fnac = Convert.ToDateTime(txtFecha.Text);
            cli.edad = Convert.ToInt32(txtEdad.Text);
            cli.Email = txtEmail.Text;
            cli.genero = Convert.ToChar(ddlSexo.SelectedValue == "Femenino" ? 'F' : ddlSexo.SelectedValue == "Masculino" ? 'F' : 'O');
            cli.tipo = Convert.ToChar(ddlTipoPersona.SelectedValue == "Físico" ? 'F' : 'J');
            cli.razonsocial = txtRazonS.Text;
            cli.Estado = true;

            return cli;

        }

        private Telefono GetEntityT()
        {
            Telefono tel = new Telefono();
            tel.DNICliente = Convert.ToInt64(txtDNI.Text);
            tel.telefono = txtTelefono.Text.ToString().Trim();
            tel.tipotelefono = ddlTipoTel.SelectedValue.Trim();
            return tel;
        }


        protected void btnCalcularEdad_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaNac = Convert.ToDateTime(txtFecha.Text);
                int años = System.DateTime.Now.Year - fechaNac.Year;
                txtEdad.Text = Convert.ToString(años);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Nuevo()
        {
            txtID.Text = "";
            txtDNI.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtRazonS.Text = "";
            txtDireccion.Text = "";
            txtLocalidad.Text = "";
            txtCP.Text = "";
            txtCUILCUIT.Text = "";
            txtCiudad.Text = "";
            txtProvincia.Text = "";
            txtEmail.Text = "";
            txtEdad.Text = "";
            txtFecha.Text = "";
            txtTelefono.Text = "";
            txtDNI.Focus();
        }
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            //REGISTRO CLIENTE
            Cliente cli = GetEntityC();
            Telefono tel = GetEntityT();

            ClientesNegocio CN = new ClientesNegocio();
            TelefonoNegocio TN = new TelefonoNegocio();

            try
            {
                if (txtID.Text == "")
                {
                    CN.AgregarCliente(cli);
                    TN.agregar(tel, cli.DNI);
                    Response.Write("<script>alert('REGISTRO INGRESADO')</script>");
                }
                else
                {
                    cli.IDCliente = long.Parse(txtID.Text.Trim());
                    CN.ModificarCliente(cli);
                    tel.DNICliente = cli.DNI;
                    TN.agregar(tel, cli.DNI);
                    Response.Write("<script>alert('REGISTRO MODIFICADO')</script>");
                }
                this.Dispose();
                Response.Redirect("Clientes.aspx");

            }

            catch (Exception)
            {
                Response.Write("<script>alert('ERROR')</script>");
            }

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Nuevo();
        }
    }
}