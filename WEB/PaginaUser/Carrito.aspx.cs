using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WEB.CarritoCodigo;
using System.Data;
using Negocio;
using System.Windows.Forms;

namespace WEB.PaginaUser
{
    public partial class Carrito1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Sesion.situacion == true)
            {
                if (!Page.IsPostBack)
                {
                    UsuarioNegocio UN = new UsuarioNegocio();
                    //instanciar detallenegocio
                    DetalleNegocio tabla = new DetalleNegocio((DataTable)Session["carrito"]);
                    //listar
                    GridView1.DataSource = tabla.getRegistro;
                    GridView1.DataBind();
                    //mostrar total
                    lblTotal.Text = tabla.totalizar().ToString();

                    txtDNI.Text = UN.buscarUser((string)Session["nombre"]).ToString();
                }
            }
            else
            {
                Response.Redirect("~/Login.aspx", false);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)Session["carrito"];
            if (dt.Rows.Count > 0)
            {
                try
                {
                    //instanciar pedido
                    Pedido ped = new Pedido();
                    ped.DNI = long.Parse(txtDNI.Text);
                    ped.Fpedido = DateTime.Today;
                    ped.Monto = decimal.Parse(lblTotal.Text);

                    //instanciar detallenegocio
                    DetalleNegocio tabla = new DetalleNegocio((DataTable)Session["carrito"]);
                    //ejecutar y mostrar 
                    string mensaje = tabla.Grabar(ped);
                    ClientScript.RegisterStartupScript(typeof(Page), "alert",
                        "<script language=JavaScript>alert('" + mensaje + "');</script>");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    MessageBox.Show("Pedido Agregado,Gracias por Su compra", MessageBoxButtons.OK.ToString());
                    Session.Remove("carrito");
                    Response.Redirect("Catalogo.aspx");
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(typeof(Page), "alert",
                        "<script language=JavaScript>alert('No ha elegido ningun producto para comprar');</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroCompra.aspx");
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            DataTable dt = (DataTable)Session["carrito"];
            dt.Rows.RemoveAt(e.RowIndex);

            Session["carrito"] = dt;

            GridView1.DataSource = dt;
            GridView1.DataBind();
            Response.Redirect("Carrito.aspx");
        }


    }
}