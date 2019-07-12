using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;
using System.Data;
using WEB.VentaAdmin;
using System.Windows.Forms;

namespace WEB.PaginaAdmin
{
    public partial class Facturacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblVendedor.Text = Convert.ToString(Session["nombre"]);
                txtDNI.Focus();
                Session["lista"] = new List<VentaColocar>();
            }
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PaginaAdmin/Clientes.aspx");
        }

        protected void btnBuscarP_Click(object sender, EventArgs e)
        {
            AccesoDatos AD = new AccesoDatos();

            if (string.IsNullOrEmpty(txtCodPro.Text.Trim()) == false)
            {
                try
                {
                    AD.setearConsulta("Select * from Articulos where ID = " + long.Parse(txtCodPro.Text));
                    AD.abrirConexion();
                    AD.ejecutarConsulta();
                    AD.Lector.Read();
                    lblDesc.Text = (string)AD.Lector["Descripcion"];
                    lblPrecio.Text = Convert.ToString(AD.Lector["PrecioVenta"]);
                    lblStock.Text = Convert.ToString(AD.Lector["Stock"]);
                    txtCant.Focus();
                }
                catch (Exception)
                {
                    ClientScript.RegisterStartupScript(typeof(Page), "alert",
                       "<script language=JavaScript>alert('Producto No encontrado');</script>");
                }
            }
        }

        protected void btnBuscarC_Click(object sender, EventArgs e)
        {
            AccesoDatos AD = new AccesoDatos();

            if (string.IsNullOrEmpty(txtDNI.Text.Trim()) == false)
            {
                try
                {
                    AD.setearConsulta("Select Nombre from Clientes where DNI = " + long.Parse(txtDNI.Text));
                    AD.abrirConexion();
                    AD.ejecutarConsulta();
                    AD.Lector.Read();
                    lblCliente.Text = (string)AD.Lector["Nombre"];
                    txtCodPro.Focus();
                }
                catch (Exception)
                {
                    ClientScript.RegisterStartupScript(typeof(Page), "alert",
                       "<script language=JavaScript>alert('Cliente No encontrado');</script>");
                }
            }
        }
        protected void btnColocar_Click(object sender, EventArgs e)
        {
            if (txtCant.Text != "" && lblDesc.Text!="")
            {
                int cant = int.Parse(txtCant.Text);
                if (cant > 0 && cant <= (int.Parse(lblStock.Text)))
                {
                    VentaColocar v = new VentaColocar();
                    v.Idpro = int.Parse(txtCodPro.Text);
                    v.desc = lblDesc.Text;
                    v.precio = decimal.Parse(lblPrecio.Text);
                    v.cant = int.Parse(txtCant.Text);
                    v.importe = ((int.Parse(txtCant.Text)) * (decimal.Parse(lblPrecio.Text)));

                    this.guardarlista(v);

                    this.GridView1.DataSource = this.obtenerlista();
                    this.GridView1.DataBind();

                    limpiar();
                    totalizar();
                }
                else
                {
                    ClientScript.RegisterStartupScript(typeof(Page), "alert",
                        "<script language=JavaScript>alert('No ha ingresado una cantidad adecuada');</script>");
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(typeof(Page), "alert",
                    "<script language=JavaScript>alert('No ha ingresado una cantidad');</script>");
            }

        }


        public List<VentaColocar> guardarlista (VentaColocar ven)
        {
            if (Session["lista"] == null)
            {
                List<VentaColocar> v = new List<VentaColocar>();
                v.Add(ven);
                Session["lista"] = v;
            }
            else
            {
                List<VentaColocar> v = (List<VentaColocar>)Session["lista"];
                v.Add(ven);
                Session["lista"] = v;
            }

            return (List < VentaColocar > )Session["lista"];
        }

        public List<VentaColocar> obtenerlista ()
        {
            if (Session["lista"] != null)
            {
                return (List<VentaColocar>)Session["lista"];
            }
            else
            {
                return null;
            }

        }

        public void limpiar()
        {
            txtCodPro.Text = "";
            lblDesc.Text = "";
            lblPrecio.Text = "";
            lblStock.Text = "";
            txtCant.Text = "";
            
        }

        public void limpiarTodo()
        {
            txtCodPro.Text = "";
            lblDesc.Text = "";
            lblPrecio.Text = "";
            lblStock.Text = "";
            txtCant.Text = "";
            txtDNI.Text = "";
            lblCliente.Text = "";

        }
        public void totalizar ()
        {
            decimal t = 0;
            foreach (GridViewRow row in GridView1.Rows)
            {
                t += Convert.ToDecimal(row.Cells[5].Text);
            }
            lblTotal.Text = "$" + t.ToString();
        }

        public void DisminuirStock(long idpro,int cant)
        {
            AccesoDatos AD = new AccesoDatos();
            AD.setearConsulta("Exec sp_disminuirstock "+idpro+","+cant+"");
            AD.abrirConexion();
            AD.ejecutarAccion();
            AD.cerrarConexion();
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            List<VentaColocar> v = (List<VentaColocar>)Session["lista"];
            v.RemoveAt(e.RowIndex);

            Session["lista"] = v;

            this.GridView1.DataSource = this.obtenerlista();
            this.GridView1.DataBind();
            totalizar();
        }

        protected void btnFacturar_Click(object sender, EventArgs e)
        {
            AccesoDatos AD = new AccesoDatos();
            if (txtDNI.Text != "" && lblCliente.Text != "" && GridView1.Rows.Count > 0 )
            {
                try
                {
                    string cmd = string.Format("Exec SP_ActualizarFacturas '{0}'", txtDNI.Text.Trim());
                    DataSet ds = AD.dataSet(cmd);
                    string numFac = ds.Tables[0].Rows[0]["NumFac"].ToString().Trim();

                    foreach (GridViewRow row in GridView1.Rows)
                    {
                        cmd = string.Format("Exec SP_ActualizarDetalles '{0}','{1}','{2}','{3}'", numFac, row.Cells[1].Text.ToString(), row.Cells[3].Text.ToString(), row.Cells[4].Text.ToString());
                        ds = AD.dataSet(cmd);
                        DisminuirStock(long.Parse(row.Cells[1].Text.ToString()), int.Parse(row.Cells[4].Text.ToString()));
                    }

                    cmd = "Exec SP_DATOSFACTURA " + numFac;
                    ds = AD.dataSet(cmd);

                    MessageBox.Show("Venta exitosa", MessageBoxButtons.OK.ToString());
                    limpiarTodo();
                    


                }
                catch (Exception)
                {
                    ClientScript.RegisterStartupScript(typeof(Page), "alert",
                        "<script language=JavaScript>alert('ERROR');</script>");

                }
                finally
                {
                    AD.cerrarConexion();
                    Response.Redirect("Facturacion.aspx");
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(typeof(Page), "alert",
                        "<script language=JavaScript>alert('Complete todos los campos, por favor y eliga los productos para facturar.');</script>");
            }
        
            
        }
    }
}