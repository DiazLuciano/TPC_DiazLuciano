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
    public partial class frmVerCompras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AccesoDatos AD = new AccesoDatos();
            if (!Page.IsPostBack) //nos aseguramos que se haga una unica vez
            {

                DataSet ds = AD.dataSet("select *from facturas as f inner join detalles as d on d.numfac=f.numfac ");
                dgvCompras.DataSource = ds.Tables[0];
                dgvCompras.DataBind();
            }
        }
        private void CargarGrillaCompras()
        {

            try
            {
                FacturaNegocio FN = new FacturaNegocio();
                dgvCompras.DataSource = FN.ListarFacturas(long.Parse(txtDNI.Text));

            }
            catch
            {
                Response.Write("<script>alert('ERROR')</script>");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarGrillaCompras();
        }
    }
}