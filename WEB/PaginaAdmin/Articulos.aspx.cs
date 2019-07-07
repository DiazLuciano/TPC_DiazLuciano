using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using System.Data;

namespace WEB
{
    public partial class Articulos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AccesoDatos AD = new AccesoDatos();

            if (!Page.IsPostBack) //nos aseguramos que se haga una unica vez
            {

                DataSet ds = AD.dataSet("select *from Articulos");
                dgvArticulos.DataSource = ds.Tables[0];
                dgvArticulos.DataBind();
            }
        }
        protected void dgvArticulos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "EditarProducto")
                {

                    long id = Convert.ToInt64(e.CommandArgument.ToString());
                    Response.Redirect("ModificarArticulo.aspx?id=" + id);
                }
                else if (e.CommandName == "EliminarProducto")
                {
                    Articulo art = new Articulo();
                    ArticuloNegocio AN = new ArticuloNegocio();
                    art.ID = Convert.ToInt64(e.CommandArgument.ToString());
                    AN.eliminarFisico(art);
                    Response.Redirect("Articulos.aspx");
                }
            }
            catch
            {
                throw;
            }

        }

    }
}