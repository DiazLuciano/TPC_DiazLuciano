using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WEB.CarritoCodigo;

namespace WEB.PaginaAdmin
{
    public partial class Pedidos : System.Web.UI.Page
    {
        Pedido p = new Pedido();
        protected void Page_Load(object sender, EventArgs e)
        {
  
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                GridView1.DataSource = p.pedidosXcliente(long.Parse(txtDNI.Text));
                GridView1.DataBind();
            }
            catch
            {
                ClientScript.RegisterStartupScript(typeof(Page), "alert",
                       "<script language=JavaScript>alert('Cliente No encontrado');</script>");
            }
            
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                //al cambiar de pagina
                GridView1.PageIndex = e.NewPageIndex;
                //pedidos x cliente
                GridView1.DataSource = p.pedidosXcliente(long.Parse(txtDNI.Text));
                GridView1.DataBind();
            }
            catch
            {
                ClientScript.RegisterStartupScript(typeof(Page), "alert",
                       "<script language=JavaScript>alert('Cliente No encontrado');</script>");
            }
           
        }
    }
}