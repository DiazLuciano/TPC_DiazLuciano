using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
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
                        art.ID = Convert.ToInt64(txtIDPro.Text);
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
      
      
        }

        private void FrmAgregarArticulo_Load(object sender, EventArgs e)
        {
            if (Text == "Modificando")
            {
                txtIDPro.Text = art.ID.ToString();
                txtDescripcion.Text = art.Descripcion;
                txtMarca.Text = art.Marca;
                txtCompra.Text = art.Preciocompra.ToString();
                txtVenta.Text = art.Precioventa.ToString();
                cmbTipoArt.SelectedItem = art.tipoarticulo;

            }
            else
            {
                //cmbTipoArt.SelectedIndex = 0;
            }
            cmbTipoArt.Items.Add("Inmuebles");
            cmbTipoArt.Items.Add("Tecnologia");
            cmbTipoArt.Items.Add("Hogar y Electrodomesticos");
            cmbTipoArt.Items.Add("Herramientos y Industria");
            cmbTipoArt.Items.Add("Juguetes");
            cmbTipoArt.Items.Add("Belleza");
            cmbTipoArt.Items.Add("Higiene");
            cmbTipoArt.Items.Add("Ropa y accesorios");
            cmbTipoArt.Items.Add("Comida");
            
        }

        private void BtnFoto_Click(object sender, EventArgs e)
        {
            
            
                //OpenFileDialog para que abra la ventanita que te deja buscar
                OpenFileDialog file = new OpenFileDialog();
                file.ShowDialog();
                //Path.GetFullPath es para saber la dirección completa y poder guardarla.
                //para usarla tuve que incluir System.IO
                txtFoto.Text = Path.GetFullPath(file.FileName);

            
        }
    }
}
