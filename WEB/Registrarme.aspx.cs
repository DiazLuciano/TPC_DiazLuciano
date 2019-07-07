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
    public partial class Registrarme : System.Web.UI.Page
    {
        public Usuario usuarioCargado;
        public void setusuario(Usuario usuario)
        {
            this.usuarioCargado = usuario;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            Usuario usuarioCargado = new Usuario();
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            try
            {
                usuarioCargado.nombre = txtNombre.Text.Trim();
                usuarioCargado.contraseña = txtContraseña.Text.Trim();
                if (usuarioNegocio.ValidarExisteUser(txtNombre.Text))
                {
                    Response.Redirect("RegistrarmeUsuario.aspx");

                }
                else
                {
                   Response.Write("<script>alert('USUARIO EXISTENTE.'</script>");               
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('USUARIO EXISTENTE.'</script>");
                throw ex;
            }
            
        }
    }
}