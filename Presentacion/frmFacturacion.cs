using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using System.Data.SqlClient;

namespace Presentacion
{
    public partial class frmFacturacion : Form
    {
        public frmFacturacion()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
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

        private void BtnBuscar_Click(object sender, EventArgs e)
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
                    txtCliente.Text = (string)AD.Lector["Nombre"];
                    txtCodigoPro.Focus();
                }
                catch (Exception )
                {
                     MessageBox.Show("Cliente no encontrado");
                }
            }
        }

        public static int cont_fila = 0;
        public static double total;
        private void BtnColocar_Click(object sender, EventArgs e)
        {
            if(AccesoDatos.ValidarFormulario(this,errorProvider1)==false)
            {
                bool existe = false;
                int num_fila = 0;

                if(cont_fila==0)
                {
                    dgvProductos.Rows.Add(txtCodigoPro.Text, txtDescripcion.Text, txtPrecio.Text, txtCantidad.Text);
                    double importe = Convert.ToDouble(dgvProductos.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dgvProductos.Rows[cont_fila].Cells[3].Value);
                    dgvProductos.Rows[cont_fila].Cells[4].Value = importe;
                    cont_fila++;

                }
                else
                {
                    foreach (DataGridViewRow Fila in dgvProductos.Rows)
                    {
                        if(Fila.Cells[0].Value.ToString()==txtCodigoPro.Text)
                        {
                            existe = true;
                            num_fila = Fila.Index;
                        }
                    }
                    if(existe==true)
                    {
                        dgvProductos.Rows[num_fila].Cells[3].Value = (Convert.ToDouble(txtCantidad.Text) + Convert.ToDouble(dgvProductos.Rows[num_fila].Cells[3].Value)).ToString();
                        double importe= Convert.ToDouble(dgvProductos.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(dgvProductos.Rows[num_fila].Cells[3].Value);
                        dgvProductos.Rows[num_fila].Cells[4].Value = importe;
                    }
                    else
                    {
                        dgvProductos.Rows.Add(txtCodigoPro.Text, txtDescripcion.Text, txtPrecio.Text, txtCantidad.Text);
                        double importe = Convert.ToDouble(dgvProductos.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dgvProductos.Rows[cont_fila].Cells[3].Value);
                        dgvProductos.Rows[cont_fila].Cells[4].Value = importe;
                        cont_fila++;
                    }
                }

                total = 0;

                foreach (DataGridViewRow Fila in dgvProductos.Rows)
                {
                    total += Convert.ToDouble(Fila.Cells[4].Value);
                }
                txtTotal.Text = "$" + total.ToString();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if(cont_fila>0)
            {
                total = total - (Convert.ToDouble(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[4].Value));
                txtTotal.Text = "$" + total.ToString();
                dgvProductos.Rows.RemoveAt(dgvProductos.CurrentRow.Index);
                cont_fila--;
            }
        }

        private void BtnBuscarP_Click(object sender, EventArgs e)
        {
            AccesoDatos AD = new AccesoDatos();

            if (string.IsNullOrEmpty(txtCodigoPro.Text.Trim()) == false)
            {
                try
                {
                    AD.setearConsulta("Select * from Articulos where ID = " + long.Parse(txtCodigoPro.Text));
                    AD.abrirConexion();
                    AD.ejecutarConsulta();
                    AD.Lector.Read();
                    txtDescripcion.Text = (string)AD.Lector["Descripcion"];
                    txtPrecio.Text = AD.Lector["PrecioVenta"].ToString();
                    txtCantidad.Focus();
                }
                catch (Exception)
                {
                    MessageBox.Show("Cliente no encontrado");
                }
            }
        }

        public void Nuevo()
        {
            txtDNI.Text = "";
            txtCliente.Text = "";
            txtCodigoPro.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            txtTotal.Text = "";
            dgvProductos.Rows.Clear();
            cont_fila = 0;
            total = 0;
            txtDNI.Focus();
        }

        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            AccesoDatos AD = new AccesoDatos();
            
            if(cont_fila!=0)
            {
                try
                {
                    string cmd = string.Format("Exec SP_ActualizarFacturas '{0}'",txtDNI.Text.Trim());
                    DataSet ds = AD.dataSet(cmd);
                    string numFac = ds.Tables[0].Rows[0]["NumFac"].ToString().Trim();

                    foreach (DataGridViewRow Fila in dgvProductos.Rows)
                    {
                        cmd = string.Format("Exec SP_ActualizarDetalles '{0}','{1}','{2}','{3}'", numFac , Fila.Cells[0].Value.ToString() , Fila.Cells[2].Value.ToString() , Fila.Cells[3].Value.ToString());
                        ds = AD.dataSet(cmd);
                    }

                    cmd = "Exec SP_DATOSFACTURA " + numFac;
                    ds = AD.dataSet(cmd);

                    Reporte rp = new Reporte();
                    rp.reportViewer1.LocalReport.DataSources[0].Value = ds.Tables[0];

                    rp.ShowDialog();
                    Nuevo();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
       
                }
                finally
                {
                    AD.cerrarConexion();
                }
            }
        }

   
    }  
}
