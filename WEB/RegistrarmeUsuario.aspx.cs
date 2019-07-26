using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace WEB
{
    public partial class RegistrarmeUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AccesoDatos AD = new AccesoDatos();

            AD.setearConsulta("select MAX(ID)+1 as ID from clientes");
            AD.abrirConexion();
            AD.ejecutarConsulta();
            AD.Lector.Read();
            txtID.Text = AD.Lector["ID"].ToString();
            //Usuario us = new Usuario();
            //us = (Usuario)Session["UserReg"];
            //txtNombre.Text = us.nombre;

        }
        private Telefono GetEntityT()
        {
            Telefono tel = new Telefono();
            tel.DNICliente = Convert.ToInt64(txtDNI.Text);
            tel.telefono = txtTelefono.Text.ToString().Trim();
            tel.tipotelefono = ddlTipoTel.SelectedValue.Trim();
            return tel;
        }
        private Cliente GetEntityC()
        {
            Cliente cli = new Cliente();

            cli.IDCliente = Convert.ToInt64(txtID.Text);
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
            cli.Estado = true;
            

            return cli;
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btnCalcularEdad_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaNac = Convert.ToDateTime(txtFecha.Text);
                txtEdad.Text = (DateTime.Today.AddTicks(-fechaNac.Ticks).Year - 1).ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Cliente cli = GetEntityC();
            Telefono tel = GetEntityT();
            Usuario us = (Usuario)Session["UserReg"];
            us.DNI = Convert.ToInt64(txtDNI.Text);
            

            ClientesNegocio CN = new ClientesNegocio();
            TelefonoNegocio TN = new TelefonoNegocio();
            UsuarioNegocio UN = new UsuarioNegocio();

            try
            {

                CN.AgregarCliente(cli);
                TN.agregar(tel, cli.DNI);
                UN.AgregarUs(us);

                Response.Redirect("Exito.aspx?ID=" + txtID.Text, false);

            }

            catch (Exception)
            {
                ClientScript.RegisterStartupScript(typeof(Page), "alert",
                           "<script language=JavaScript>alert('ERROR');</script>");
            }
            
        }
    }
}