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

    }  
}
