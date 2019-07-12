using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Dominio;
using Negocio;
using System.Data;
using WEB.CarritoCodigo;

namespace WEB.PaginaUser
{
    public partial class RegistroCompra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["ID"] == null)
            {
                Response.Redirect("Catalogo.aspx");
            }
            else
            {
                long id = long.Parse(Request.Params["ID"]);
                AccesoDatos AD = new AccesoDatos();
                AD.setearConsulta("Select * from Articulos where ID = " + id );
                AD.abrirConexion();
                AD.ejecutarConsulta();
                if(AD.Lector.Read())
                {
                    lblIDPro.Text = Convert.ToString(AD.Lector["ID"]);
                    lblDes.Text = (string)AD.Lector["descripcion"];
                    lblMarca.Text = (string)AD.Lector["Marca"];
                    lblPrecio.Text = Convert.ToString(AD.Lector["PrecioVenta"]);
                    lblCat.Text = (string)AD.Lector["TipoArticulo"];
                    lblStock.Text = Convert.ToString(AD.Lector["Stock"]);
                }
                AD.cerrarConexion();
            }
        }

        public void btnAgregar_Click(object sender, EventArgs e)
        {
            
            if (txtCantidad.Text.Length != 0)
            {
                int cant = int.Parse(txtCantidad.Text);
                int stock = int.Parse(lblStock.Text);
                if (cant <= stock && cant > 0)
                {
                    //instanciamos detallenegocio y le pasamos como parametro la sesion
                    DetalleNegocio tabla = new DetalleNegocio((DataTable)Session["carrito"]);
                    //ejecuto y muestro el mensaje
                    string mensaje = tabla.agregar(long.Parse(lblIDPro.Text), lblDes.Text, decimal.Parse(lblPrecio.Text), int.Parse(txtCantidad.Text));
                    ClientScript.RegisterStartupScript(typeof(Page), "alert",
                        "<script language=JavaScript>alert('" + (mensaje) + "');</script>");
                    //actualizamos la sesion
                    Session["carrito"] = tabla.getRegistro;
                }
                else
                {
                    ClientScript.RegisterStartupScript(typeof(Page), "alert",
                        "<script language=JavaScript>alert('No puede superar el stock');</script>");
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(typeof(Page), "alert",
                    "<script language=JavaScript>alert('No ha ingresado una cantidad valida');</script>");
            }
            

        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Carrito.aspx");
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Catalogo.aspx");
        }
    }
}