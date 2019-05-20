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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();           
        }

        private void CargarGrillaClientes()
        {

            try
            {
                ClientesNegocio cliN = new ClientesNegocio();
                dgvClientes.DataSource = cliN.ListarClientes();

                //para ordenar las columnas de la grilla
                //dgvContactos.Columns[4].DisplayIndex = 0;
                dgvClientes.Columns[0].Visible = false;
                dgvClientes.Columns[5].Visible = false;
                dgvClientes.Columns[6].Visible = false;
                dgvClientes.Columns[7].Visible = false;
                dgvClientes.Columns[8].Visible = false;
                dgvClientes.Columns[9].Visible = false;
                //para ocultar

            }
            catch (Exception ex)
            {
                MessageBox.Show("Que lastima, faló... " + ex.ToString());
            }

      
        }

        /* private void btnCargar_Click(object sender, EventArgs e)
         {
             Cliente cli = new Cliente();
             ClientesNegocio cliN = new ClientesNegocio();
             try
             {
                 DateTime fecha = DateTime.Today;

                 cli.DNI = Convert.ToInt32(txtDNI.Text);
                 cli.nombre = txtNombre.Text;
                 cli.apellido = txtApellido.Text;
                 cliN.AgregarCliente(cli);
                 MessageBox.Show("Cargado");
                 BorrarRegistros();

             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }
         }*/

        private void VerClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();    
        }

        private void VerClientes_Load(object sender, EventArgs e)
        {
            CargarGrillaClientes();
            //dgvClientes.DataSource = Cargargrilla("Clientes").Tables[0]; //data source necesita que le asigne un dataset para que me llene el DGV (Mi metodo llenar)
        }

        private void pbAgregarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCargarCliente VentanaCargarCliente = new frmCargarCliente();
            VentanaCargarCliente.Show();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbRestaurar_Click(object sender, EventArgs e)
        {
            
            WindowState = FormWindowState.Normal;
            pbRestaurar.Visible = false;
            pbMaximizar.Visible = true;
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pbMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pbRestaurar.Visible = true;
            pbMaximizar.Visible = false;
        }

        private void pbModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cli = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                frmCargarCliente modificar = new frmCargarCliente(cli);
                modificar.Text = "Modificando";
                modificar.ShowDialog();
                CargarGrillaClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pbEliminarCliente_Click(object sender, EventArgs e)
        {
            ClientesNegocio serv = new ClientesNegocio();
            try
            {
                if (MessageBox.Show("Está seguro de elimnar lógicamente al contaco?", "Eliminar", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
                Cliente cli = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                serv.eliminarFisico(cli);
                CargarGrillaClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
