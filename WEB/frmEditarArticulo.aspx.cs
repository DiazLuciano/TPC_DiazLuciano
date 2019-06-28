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
    public partial class frmEditarArticulo : System.Web.UI.Page
    {
        private Articulo art;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                if(Request.QueryString["ID"]!=null) //si es nulo vino por el nuevo
                {
                    long id = Convert.ToInt64(Request.QueryString["ID"]);
                    CargarDatos(id);
                }
            }
        }

        private void CargarDatos(long id)
        {
            Articulo art = new Articulo();
            AccesoDatos AD = new AccesoDatos();

            AD.setearConsulta("select * from articulos where id = " + id);
            AD.abrirConexion();
            AD.ejecutarConsulta();
            AD.Lector.Read();

            txtID.Text = (string)AD.Lector["id"].ToString();
            txtDescripcion.Text = (string)AD.Lector["descripcion"];
            txtMarca.Text = (string)AD.Lector["marca"];
            txtPrecioC.Text = (string)AD.Lector["preciocompra"].ToString();
            txtPrecioV.Text = (string)AD.Lector["precioventa"].ToString();
            ddlTipoArt.SelectedValue = (string)AD.Lector["tipoarticulo"];

        }

        public void Nuevo()
        {
            txtDescripcion.Text = "";
            txtMarca.Text = "";
            txtPrecioC.Text = "";
            txtPrecioV.Text = "";

            txtDescripcion.Focus();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio AN = new ArticuloNegocio();
            try
            {
                if(txtID.Text=="")
                {
                    art = new Articulo();
                    art.Descripcion = txtDescripcion.Text;
                    art.Marca = txtMarca.Text;
                    art.Preciocompra = Convert.ToDecimal(txtPrecioC.Text);
                    art.Precioventa = Convert.ToDecimal(txtPrecioV.Text);
                    art.tipoarticulo = ddlTipoArt.Text;
                    AN.AgregarArticulo(art);
                    Response.Write("<script>alert('REGISTRO INGRESADO')</script>");
                }
                else
                {
                    art = new Articulo();
                    art.ID = Convert.ToInt64(txtID.Text.Trim());
                    art.Descripcion = txtDescripcion.Text;
                    art.Marca = txtMarca.Text;
                    art.Preciocompra = Convert.ToDecimal(txtPrecioC.Text);
                    art.Precioventa = Convert.ToDecimal(txtPrecioV.Text);
                    art.tipoarticulo = ddlTipoArt.Text;
                    AN.ModificarArticulo(art);
                    Response.Write("<script>alert('REGISTRO MODIFICADO')</script>");
                }
                this.Dispose();
                Response.Redirect("frmListaArticulos.aspx");
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}