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

        //agregamos este constructor que recibe una lista te telefonos por parámetro
        public frmTelefonos(IList<Telefono> telefonos,Cliente cli)
        {
            InitializeComponent();
            //se la damos como origen de datos a la grilla y nada mas. Cuando este form nace, 
            //carga automaticamente los telefonos que le manden del otro form.
            dgvTelefonos.DataSource = telefonos;
            dgvTelefonos.Columns[0].Visible = false;
            dgvTelefonos.Columns[1].Visible = false;
            txtIDCli.Text = cli.IDCliente.ToString();

        }
        public void CargarGrillaTelefonos(long id)
        {
            TelefonoNegocio TN = new TelefonoNegocio();
            try
            {
                 Telefono tel = (Telefono)dgvTelefonos.CurrentRow.DataBoundItem;
                 dgvTelefonos.DataSource = TN.traerTelefonos(id);
            }
            catch (Exception)
            {

                throw;
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
                long idcli = tel.IDCliente;
                TN.eliminarFisico(tel);
                CargarGrillaTelefonos(idcli);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            //guardo el item seleccionado, lo casteo a Cliente, porque sé que es uno...
            frmAgregarTelefono agregarTel = new frmAgregarTelefono(txtIDCli.Text);
            try
            {
                //cuando se ejecuta esto, el form "agregar" toma el control
                agregarTel.ShowDialog();
                //cuando termina, devuelve el control al form AGENDA y se ejecuta el siguiente evento
                FrmTelefonos_Load(sender, e);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FrmTelefonos_Load(object sender, EventArgs e)
        {

        }
    }
}
