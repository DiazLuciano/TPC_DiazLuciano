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
    public partial class frmLogin : Form
    {

        public Usuario usuarioCargado;

        public void setusuario(Usuario usuario)
        {
            this.usuarioCargado = usuario;
        }

        public frmLogin()
        {
            InitializeComponent();
            MessageBox.Show("contra y usuario : admin");
        }
       
        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pbIniciar_Click(object sender, EventArgs e)
        {
           if (AccesoDatos.ValidarFormulario(this,errorProvider1) == false) // si en este metodo que le pasamos la ventana y el errorprovider, si es igual a false, que haga lo sgte
            {
                Usuario usuarioCargado = new Usuario();
                UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                try
                {
                    usuarioCargado.nombre = txtUsuario.Text.Trim();
                    usuarioCargado.contraseña = txtContraseña.Text.Trim();
                    if (usuarioNegocio.ValidarUsuario(usuarioCargado))
                    {

                        setusuario(usuarioCargado);
                        this.Hide();
                        frmPrincipal principal = new frmPrincipal();
                        principal.Show();


                    }
                    else
                    {
                        MessageBox.Show("usuario o pass incorrectos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
           else
            {

            }
           
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
