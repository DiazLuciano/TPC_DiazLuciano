using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB.PaginaAdmin
{
    public partial class Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Sesion.situacion==true)
            {
                if (!Page.IsPostBack)
                {

                }
            }
            else
            {
                ClientScript.RegisterStartupScript(typeof(Page), "alert",
                    "<script language=JavaScript>alert('Debe iniciar sesión');</script>");
                Response.Redirect("~/Login.aspx", false);
            }
        }
    }
}