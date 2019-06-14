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
    public partial class frmArticulos : Form
    {
        public frmArticulos()
        {
            InitializeComponent();
        }

        /*public DataSet Cargargrilla(string Tabla)
        {
            DataSet DS;
            string comando = string.Format("SELECT *FROM " + Tabla);
            DS = AccesoDatos.Ejecutar(comando);

            return DS;
        }*/

        private void VerArticulos_Load(object sender, EventArgs e)
        {
            //dgvArticulos.DataSource = Cargargrilla("Articulos").Tables[0];
            CargarGrillaArticulos();
        }

        private List<Articulo> ListaArticulos;
        private void CargarGrillaArticulos()
        {

            ArticuloNegocio artN = new ArticuloNegocio();
            try
            {

                ListaArticulos = artN.ListarArticulos();
                dgvArticulos.DataSource = ListaArticulos;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerArticulos_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo agregarA = new frmAgregarArticulo();
            agregarA.Show();
        }
    }
}
