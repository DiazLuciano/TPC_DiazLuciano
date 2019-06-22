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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuarioCargado = new Usuario();
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            try
            {
                usuarioCargado.nombre = txtUsuario.Text.Trim();
                usuarioCargado.contraseña = txtContraseña.Text.Trim();
                if (usuarioNegocio.ValidarUsuario(usuarioCargado))
                {
                    Response.Redirect("PanelGeneral.aspx");
                }
                else
                {
                    Response.Write("Usuario Invalido");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}