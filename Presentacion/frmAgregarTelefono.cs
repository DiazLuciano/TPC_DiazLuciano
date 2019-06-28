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
    public partial class frmAgregarTelefono : Form
    {
        public frmAgregarTelefono(string dni)
        {
            InitializeComponent();
            txtDNI.Text = dni.Trim();
        }

        private void FrmAgregarTelefono_Load(object sender, EventArgs e)
        {
            cmbTipoTel.Items.Add("Trabajo");
            cmbTipoTel.Items.Add("Casa");
            cmbTipoTel.Items.Add("Celular");
            cmbTipoTel.SelectedIndex = 0;
            

        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (AccesoDatos.ValidarFormulario(this, errorProvider1) == false)
            {
                AccesoDatos AD = new AccesoDatos();
                Telefono tel = new Telefono();

                tel.telefono = txtTelefono.Text;
                tel.tipotelefono = cmbTipoTel.Text;

                string consulta = "Exec SP_AgregarTelefono " + long.Parse(txtDNI.Text) + ", " + tel.telefono + ", ";
                try
                {

                    if (tel.tipotelefono.ToString().Trim() == "Casa")
                    {
                        consulta = consulta + "Casa";
                    }
                    else
                    {
                        if (tel.tipotelefono.ToString().Trim() == "Celular")
                        {
                            consulta = consulta + "Celular";
                        }
                        else
                        {
                            if (tel.tipotelefono.ToString().Trim() == "Trabajo")
                            {
                                consulta = consulta + "Trabajo";
                            }
                        }
                    }
                    AD.setearConsulta(consulta);
                    AD.abrirConexion();
                    AD.ejecutarAccion();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {

                    MessageBox.Show("AGREGADO CORRECTAMENTE");
                    AD.cerrarConexion();
                    this.Dispose();

                }
            }
               

        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

 
    }
}
