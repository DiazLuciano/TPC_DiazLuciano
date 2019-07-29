using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using System.Windows.Forms;

namespace WEB
{
    public partial class Registrarme : System.Web.UI.Page
    {
        public Usuario usuarioCargado;
        public void setusuario(Usuario usuario)
        {
            this.usuarioCargado = usuario;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            Usuario usuarioCargado = new Usuario();
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            try
            {
                usuarioCargado.nombre = txtNombre.Text.Trim();
                usuarioCargado.contraseña = txtContraseña.Text.Trim();
                if (usuarioNegocio.ValidarExisteUser(txtNombre.Text)==true)
                {
                    Session["UserReg"] = usuarioCargado;
                    Response.Redirect("~/RegistrarmeUsuario.aspx",false);
                }
                else
                {
                    ClientScript.RegisterStartupScript(typeof(Page), "alert",
                    "<script language=JavaScript>alert('Este usuario ya existe, elija otro por favor.');</script>");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex);

            }
            
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}