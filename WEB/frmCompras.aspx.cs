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
    public partial class frmCompras : System.Web.UI.Page
    {
        public static double total;
        protected void Page_Load(object sender, EventArgs e)
        {
            txtTotal.Text = "$";
            AccesoDatos AD = new AccesoDatos();

            try
            {
                AD.setearConsulta("Select *from Usuarios where ID = " + UsuarioNegocio.Codigo);
                AD.abrirConexion();
                AD.ejecutarConsulta();
                AD.Lector.Read();
                txtLeAtiende.Text = (string)AD.Lector["Nombre"];
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                AD.cerrarConexion();
            }
        }

        protected void btnBuscarDNI_Click(object sender, EventArgs e)
        {
            AccesoDatos AD = new AccesoDatos();

            if (string.IsNullOrEmpty(txtDNI.Text.Trim()) == false)
            {
                try
                {
                    AD.setearConsulta("Select Nombre from Clientes where DNI = " + long.Parse(txtDNI.Text.Trim()));
                    AD.abrirConexion();
                    AD.ejecutarConsulta();
                    AD.Lector.Read();
                    txtNombre.Text = (string)AD.Lector["Nombre"];
                    txtCodPro.Focus();
                }
                catch (Exception)
                {
                    Response.Write("<script>alert('Cliente no encontrado')</script>");
                   
                }
            }
        }

        protected void btnBuscarPro_Click(object sender, EventArgs e)
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
                    txtDescripcion.Text = (string)AD.Lector["Descripcion"];
                    txtPrecio.Text = AD.Lector["PrecioVenta"].ToString();
                    txtCantidad.Focus();
                }
                catch (Exception)
                {
                    Response.Write("<script>alert('Articulo no encontrado')</script>");
                }
            }
        }

        public void Nuevo()
        {
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtCodPro.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            txtTotal.Text = "";
            total = 0;
            txtDNI.Focus();
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            AccesoDatos AD = new AccesoDatos();

                try
                {
                    string cmd = string.Format("Exec SP_ActualizarFacturas '{0}'", txtDNI.Text.Trim());
                    DataSet ds = AD.dataSet(cmd);
                    string numFac = ds.Tables[0].Rows[0]["NumFac"].ToString().Trim();


                        cmd = string.Format("Exec SP_ActualizarDetalles '{0}','{1}','{2}','{3}'", numFac, txtCodPro.Text.Trim(), txtPrecio.Text.Trim(), txtCantidad.Text.Trim());
                        ds = AD.dataSet(cmd);

                    cmd = "Exec SP_DATOSFACTURA " + numFac;
                    ds = AD.dataSet(cmd);

                    Nuevo();

                }
                catch (Exception)
                {
                    Response.Write("<script>alert('ERROR EN LA COMPRA')</script>");

                }
                finally
                {
                    Response.Write("<script>alert('COMPRA REALIZADA')</script>");
                    AD.cerrarConexion();
                }
        }
        

        protected void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            decimal precio = Convert.ToDecimal(txtPrecio.Text);
            decimal cant = Convert.ToDecimal(txtCantidad.Text);
            txtTotal.Text = "$" + (cant * precio);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
    }
}