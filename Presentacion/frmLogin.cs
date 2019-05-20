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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //btnIniciar.Enabled = false;

        }

        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length != 0)
            {
                pbCruz1.Visible = false;
                pbTick1.Visible = true;
            }
            else
            {
                pbCruz1.Visible = true;
                pbTick1.Visible = false;
            }
            //tb.BackColor = System.Drawing.SystemColors.AppWorkspace;
            Validar();
        }

        private void txtContraseña_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length != 0)
            {
                pbTick2.Visible = true;
                pbCruz2.Visible = false;
            }
            else
            {
                pbCruz2.Visible = true;
                pbTick2.Visible = false;
            }
            Validar();
        }

        private void Validar()
        {
            //btnIniciar.Enabled = ((txtUsuario.BackColor != Color.Red) && (txtContraseña.BackColor != Color.Red) );
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

    }
}
