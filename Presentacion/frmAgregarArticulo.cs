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
    public partial class frmAgregarArticulo : Form
    {
        private Articulo art;
        public frmAgregarArticulo()
        {
            InitializeComponent();
            art = new Articulo();
        }

        public frmAgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            art = articulo;

        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (AccesoDatos.ValidarFormulario(this, errorProvider1) == false)
            {
                ArticuloNegocio AN = new ArticuloNegocio();

                try
                {
                    art = new Articulo();
                    art.ID = art.ID;
                    art.Descripcion = txtDescripcion.Text;
                    art.Marca = txtMarca.Text;
                    art.Preciocompra = Convert.ToDecimal(txtCompra.Text);
                    art.Precioventa = Convert.ToDecimal(txtVenta.Text);
                    art.tipoarticulo = cmbTipoArt.Text;

                    if (this.Text != "Modificando")
                    {

                        AN.AgregarArticulo(art);
                        MessageBox.Show("Agregado correctamente!");
                    }
                    else
                    {
                        AN.ModificarArticulo(art);
                        MessageBox.Show("Modificado correctamente!");
                    }

                    this.Dispose();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error FATAL. " + ex.ToString(), "", MessageBoxButtons.OK);
                }
            }
            this.Close();
            frmClientes verClientes = new frmClientes();
            verClientes.Show();
        }

        private void FrmAgregarArticulo_Load(object sender, EventArgs e)
        {
            if (Text == "Modificando")
            {
                textBox1.Text = art.ID.ToString();
                txtDescripcion.Text = art.Descripcion;
                txtMarca.Text = art.Marca;
                txtCompra.Text = art.Preciocompra.ToString();
                txtVenta.Text = art.Precioventa.ToString();

            }
            else
            {
      
            }
            cmbTipoArt.Items.Add("Inmuebles");
            cmbTipoArt.Items.Add("Tecnologia");
            cmbTipoArt.Items.Add("Hogar y Electrodomesticos");
            cmbTipoArt.Items.Add("Herramientos y Industria");
            cmbTipoArt.Items.Add("Juguetes");
            cmbTipoArt.Items.Add("Belleza");
            cmbTipoArt.Items.Add("Higiene");
            cmbTipoArt.Items.Add("Ropa y accesorios");
            cmbTipoArt.SelectedIndex = 0;
        }
    }
}
