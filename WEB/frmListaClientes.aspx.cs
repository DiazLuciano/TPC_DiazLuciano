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
    public partial class frmListaClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AccesoDatos AD = new AccesoDatos();

            if (!Page.IsPostBack) //nos aseguramos que se haga una unica vez
            {

                DataSet ds = AD.dataSet("select *from clientes");
                dgvClientes.DataSource = ds.Tables[0];
                dgvClientes.DataBind();
            }

        }

        protected void dgvClientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName=="EditarCliente")
            {
                long id = Convert.ToInt64(e.CommandArgument.ToString());
                Response.Redirect("frmClientes.aspx?id"+id);
            }
            else if(e.CommandName=="EliminarCliente")
            {
                Cliente cli = new Cliente();
                ClientesNegocio CN = new ClientesNegocio();
                cli.IDCliente = Convert.ToInt64(e.CommandArgument);
                CN.eliminarFisico(cli);
                Response.Redirect("frmListaClientes.aspx");
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            
        }
    }
}