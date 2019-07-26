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
    
    public partial class CarritoCompra : System.Web.UI.Page
    {
        DataTable carrito = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Sesion.situacion==true)
            {
                if (!Page.IsPostBack)
                {

                    if (Request.Params["TipoArticulo"] != null) //nos aseguramos que se haga una unica vez
                    {
                        ListView1.DataSourceID = "SqlDataSourceTodosProductos";
                        SqlDataSourceTodosProductos.SelectCommand = "select ID,MARCA, DESCRIPCION,IMAGEN,PRECIOVENTA,TIPOARTICULO from ARTICULOS where UPPER(TIPOARTICULO) LIKE UPPER('" + Request.Params["TipoArticulo"] + "%')";
                        ListView1.DataBind();
                    }

                }
            }
            else
            {
                ClientScript.RegisterStartupScript(typeof(Page), "alert",
                    "<script language=JavaScript>alert('Debe iniciar sesión');</script>");
                Response.Redirect("~/Login.aspx", false);
            }
            
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ListView1.DataSourceID = "SqlDataSourceTodosProductos";
                SqlDataSourceTodosProductos.SelectCommand = "select ID,MARCA, DESCRIPCION,IMAGEN,PRECIOVENTA,TIPOARTICULO from ARTICULOS where UPPER(TIPOARTICULO) LIKE UPPER('" + txtBusqueda.Text + "%') or UPPER(DESCRIPCION) LIKE UPPER('" + txtBusqueda.Text + "%') or UPPER(MARCA) LIKE UPPER('" + txtBusqueda.Text + "%')";
                ListView1.DataBind();
            }
            catch (Exception)
            {
                ClientScript.RegisterStartupScript(typeof(Page), "alert",
                    "<script language=JavaScript>alert('No se han encontrado resultados');</script>");
                throw;
            }
        }

        protected void btnTodos_Click(object sender, EventArgs e)
        {
            Response.Redirect("~PaginaUser/Catalogo.aspx");
        }

        protected void ListView1_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if(e.CommandName=="Seleccionar")
            {
                ListView1.SelectedIndex = e.Item.DataItemIndex;
                string id = ((Label)e.Item.FindControl("lblID")).Text;
                Response.Redirect("RegistroCompra.aspx?ID=" + id,false);
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Carrito.aspx");
        }
    }
}