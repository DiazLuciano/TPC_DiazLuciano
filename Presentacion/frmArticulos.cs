﻿using System;
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

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo art = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmAgregarArticulo modificar = new frmAgregarArticulo(art);
                modificar.Text = "Modificando";
                modificar.ShowDialog();
                CargarGrillaArticulos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnEliminarF_Click(object sender, EventArgs e)
        {
            ArticuloNegocio AN = new ArticuloNegocio();
            try
            {
                if (MessageBox.Show("Está seguro de elimnar fisicamente al articulo?", "Eliminar", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
                Articulo art = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                AN.eliminarFisico(art);
                CargarGrillaArticulos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnEliminarL_Click(object sender, EventArgs e)
        {
            ArticuloNegocio AN = new ArticuloNegocio();
            try
            {
                if (MessageBox.Show("Está seguro de elimnar logicamente al articulo?", "Eliminar", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
                Articulo art = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                AN.eliminarLogico(art);
                CargarGrillaArticulos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TxtDescripcion_TextChanged_1(object sender, EventArgs e)
        {
            ArticuloNegocio AN = new ArticuloNegocio();

            try
            {
                dgvArticulos.DataSource = AN.BuscarPro(txtDescripcion.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No buscó nada,rompio");
                throw ex;

            }
        }
    }
}
