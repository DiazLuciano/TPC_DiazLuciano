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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnIniciar.Enabled = false;
            
        }

        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
                tb.BackColor = Color.Red;
            else
                tb.BackColor = System.Drawing.SystemColors.Window;
            Validar();
        }

        private void txtContraseña_Validating_1(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
                tb.BackColor = Color.Red;
            else
                tb.BackColor = System.Drawing.SystemColors.Window;
            Validar();
        }

        private void Validar()
        {
            btnIniciar.Enabled = ((txtUsuario.BackColor != Color.Red) && (txtContraseña.BackColor != Color.Red) );
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
           
            try
            {
                string comando = string.Format("Select *FROM Usuarios WHERE Nombre='{0}' AND Contraseña='{1}'",
                    txtUsuario.Text.Trim(), txtContraseña.Text.Trim());
                DataSet DS = AccesoDatos.Ejecutar(comando);

                string cuenta = DS.Tables[0].Rows[0]["Nombre"].ToString();
                string contraseña = DS.Tables[0].Rows[0]["Contraseña"].ToString();

                if(cuenta == txtUsuario.Text.Trim()&& contraseña == txtContraseña.Text.Trim())
                {
                    this.Hide();
                    Principal principal = new Principal();
                    principal.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Contraseña o Usuario Inconrrecto" + " " +  ex.ToString());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
    }
}
