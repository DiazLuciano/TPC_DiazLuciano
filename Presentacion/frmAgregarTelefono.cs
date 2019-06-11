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
        public frmAgregarTelefono(string id)
        {
            InitializeComponent();
            txtIDCli.Text = id;
        }

        private void FrmAgregarTelefono_Load(object sender, EventArgs e)
        {
            
            //combo de tipo de telefono, le agrego las opciones a mano. Estas deberían ser de la base de datos en realidad.
            //pero nuestro teléfono debería a su vez tener un atributo clase TIPO para poder asignarlo.
            cmbTipoTel.Items.Add("Trabajo");
            cmbTipoTel.Items.Add("Casa");
            cmbTipoTel.Items.Add("Celular");
            //seteo el primero por default
            cmbTipoTel.SelectedIndex = 0;
            //Tipo de Persona por default

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AccesoDatos AD = new AccesoDatos();
            Telefono tel = new Telefono();

            tel.telefono = txtTelefono.Text;
            tel.tipotelefono = cmbTipoTel.Text;

            string consulta = "Exec SP_AgregarTelefono " +long.Parse(txtIDCli.Text)+ ", " + tel.telefono + ", ";
            try
            {

                //seteo insert y ejecuto
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
            catch (Exception)
            {
                throw;
            }
            finally
            {
                AD.cerrarConexion();
                this.Close();
            }
        }
    }
}
