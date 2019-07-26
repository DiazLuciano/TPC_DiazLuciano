using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using System.Windows;
using System.Windows.Forms;

namespace WEB
{
    public partial class Login : System.Web.UI.Page
    {
        public Usuario usuarioCargado;
        public void setusuario(Usuario usuario)
        {
            this.usuarioCargado = usuario;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
            Sesion.cambiarEstado(false);
            
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuarioCargado = new Usuario();
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            try
            {
                if (txtUsuario.Text != "" || txtContraseña.Text != "")
                {
                    usuarioCargado.nombre = txtUsuario.Text.Trim();
                    usuarioCargado.contraseña = txtContraseña.Text.Trim();
                    if (usuarioNegocio.ValidarUsuario(usuarioCargado))
                    {
                        setusuario(usuarioCargado);
                        if (usuarioCargado.Tipo == "Administrador")
                        {
                            Sesion.cambiarEstado(true);
                            Session["usuario"] = usuarioCargado;
                            Response.Redirect("~/PaginaAdmin/Clientes.aspx?UsuarioNombre=" + usuarioCargado.nombre, false);
                        }
                        else
                        {
                            Sesion.cambiarEstado(true);
                            Session["usuario"] = usuarioCargado.nombre;
                            Response.Redirect("~/PaginaUser/Catalogo.aspx?UsuarioNombre=" + usuarioCargado.nombre, false);
                        }

                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(typeof(Page), "alert",
                           "<script language=JavaScript>alert('Usuario Incorrecto');</script>");
                    }
                }
                else
                {
                    ClientScript.RegisterStartupScript(typeof(Page), "alert",
                           "<script language=JavaScript>alert('Debe completar los campos');</script>");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}