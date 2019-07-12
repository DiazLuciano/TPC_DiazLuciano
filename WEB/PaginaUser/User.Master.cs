using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using System.Windows.Forms;
using System.Data;

namespace WEB
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {
                UsuarioNegocio UN = new UsuarioNegocio();
                if (Request.Params["UsuarioNombre"] != null)
                {
                    lblBienvenido.Text = "Bienvenido " + Request.Params["UsuarioNombre"];
                    Session["nombre"] = Request.Params["UsuarioNombre"];
                }
                else
                {
                    lblBienvenido.Text = "Bienvenido " + Convert.ToString(Session["nombre"]);
                }
            }
            else
            {
                MessageBox.Show("DEBE LOGUEARSE");
                Response.Redirect("~/Login.aspx");
            }
        }
        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.Remove("usuario");
            Response.Redirect("~WEB\\Login.aspx");
        }
    }
}