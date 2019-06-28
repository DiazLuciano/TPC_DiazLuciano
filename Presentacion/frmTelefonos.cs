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
    public partial class frmTelefonos : Form
    {
       
        public frmTelefonos()
        {
            InitializeComponent();
        }

        public frmTelefonos(IList<Telefono> telefonos,Cliente cli)
        {
            InitializeComponent();
            dgvTelefonos.DataSource = telefonos;
            txtDNI.Text = cli.DNI.ToString();

        }
        public void CargarGrillaTelefonos(long dni)
        {
            TelefonoNegocio TN = new TelefonoNegocio();
            try
            {
                 Telefono tel = (Telefono)dgvTelefonos.CurrentRow.DataBoundItem;
                 dgvTelefonos.DataSource = TN.traerTelefonos(dni);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR, RETORNO NULL PORQUE NO HAY REGISTROS CARGADOS " + ex.ToString(), "", MessageBoxButtons.OK);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            TelefonoNegocio TN = new TelefonoNegocio();
            try
            {
                if (MessageBox.Show("Está seguro de elimnar este Telefono?", "Eliminar", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
                Telefono tel = (Telefono)dgvTelefonos.CurrentRow.DataBoundItem;
                long dni = tel.DNICliente;
                TN.eliminarFisico(tel);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Dispose();
            }
        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            
            //guardo el item seleccionado, lo casteo a Cliente, porque sé que es uno...
            frmAgregarTelefono agregarTel = new frmAgregarTelefono(txtDNI.Text);
            try
            {
                //cuando se ejecuta esto, el form "agregar" toma el control
                agregarTel.ShowDialog();
                //cuando termina, devuelve el control al form AGENDA y se ejecuta el siguiente evento
                //FrmTelefonos_Load(sender, e);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.Close();
            }
        }

        private void FrmTelefonos_Load(object sender, EventArgs e)
        {
            
            CargarGrillaTelefonos(long.Parse(txtDNI.Text));
        }
    }
}
