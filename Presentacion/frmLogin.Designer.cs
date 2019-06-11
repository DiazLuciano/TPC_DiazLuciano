namespace Presentacion
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbImagenUsuario = new System.Windows.Forms.PictureBox();
            this.pbIniciar = new System.Windows.Forms.PictureBox();
            this.pbImagenUsuarioMini = new System.Windows.Forms.PictureBox();
            this.pbCandado = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pbTick1 = new System.Windows.Forms.PictureBox();
            this.pbTick2 = new System.Windows.Forms.PictureBox();
            this.pbCruz1 = new System.Windows.Forms.PictureBox();
            this.pbCruz2 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtContraseña = new Negocio.ErrorTxtBox();
            this.txtUsuario = new Negocio.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenUsuarioMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCandado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTick1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTick2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCruz1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCruz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCerrar
            // 
            this.pbCerrar.BackColor = System.Drawing.Color.Transparent;
            this.pbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCerrar.ErrorImage = null;
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(361, 12);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(25, 25);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 7;
            this.pbCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.pbCerrar, "Cerrar");
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.pbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizar.Image")));
            this.pbMinimizar.Location = new System.Drawing.Point(328, 12);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(25, 25);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizar.TabIndex = 8;
            this.pbMinimizar.TabStop = false;
            this.toolTip1.SetToolTip(this.pbMinimizar, "Minimizar");
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // pbImagenUsuario
            // 
            this.pbImagenUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pbImagenUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pbImagenUsuario.Image")));
            this.pbImagenUsuario.Location = new System.Drawing.Point(143, 72);
            this.pbImagenUsuario.Name = "pbImagenUsuario";
            this.pbImagenUsuario.Size = new System.Drawing.Size(114, 124);
            this.pbImagenUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenUsuario.TabIndex = 9;
            this.pbImagenUsuario.TabStop = false;
            // 
            // pbIniciar
            // 
            this.pbIniciar.AccessibleDescription = "";
            this.pbIniciar.AccessibleName = "";
            this.pbIniciar.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.pbIniciar.BackColor = System.Drawing.Color.Transparent;
            this.pbIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIniciar.Image = ((System.Drawing.Image)(resources.GetObject("pbIniciar.Image")));
            this.pbIniciar.Location = new System.Drawing.Point(325, 296);
            this.pbIniciar.Name = "pbIniciar";
            this.pbIniciar.Size = new System.Drawing.Size(63, 43);
            this.pbIniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIniciar.TabIndex = 10;
            this.pbIniciar.TabStop = false;
            this.pbIniciar.Tag = "";
            this.toolTip1.SetToolTip(this.pbIniciar, "Iniciar Sesión");
            this.pbIniciar.Click += new System.EventHandler(this.pbIniciar_Click);
            // 
            // pbImagenUsuarioMini
            // 
            this.pbImagenUsuarioMini.BackColor = System.Drawing.Color.Transparent;
            this.pbImagenUsuarioMini.Image = ((System.Drawing.Image)(resources.GetObject("pbImagenUsuarioMini.Image")));
            this.pbImagenUsuarioMini.Location = new System.Drawing.Point(73, 215);
            this.pbImagenUsuarioMini.Name = "pbImagenUsuarioMini";
            this.pbImagenUsuarioMini.Size = new System.Drawing.Size(28, 20);
            this.pbImagenUsuarioMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenUsuarioMini.TabIndex = 11;
            this.pbImagenUsuarioMini.TabStop = false;
            // 
            // pbCandado
            // 
            this.pbCandado.BackColor = System.Drawing.Color.Transparent;
            this.pbCandado.Image = ((System.Drawing.Image)(resources.GetObject("pbCandado.Image")));
            this.pbCandado.Location = new System.Drawing.Point(73, 252);
            this.pbCandado.Name = "pbCandado";
            this.pbCandado.Size = new System.Drawing.Size(28, 20);
            this.pbCandado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCandado.TabIndex = 12;
            this.pbCandado.TabStop = false;
            // 
            // pbTick1
            // 
            this.pbTick1.BackColor = System.Drawing.Color.Transparent;
            this.pbTick1.Image = ((System.Drawing.Image)(resources.GetObject("pbTick1.Image")));
            this.pbTick1.Location = new System.Drawing.Point(290, 215);
            this.pbTick1.Name = "pbTick1";
            this.pbTick1.Size = new System.Drawing.Size(21, 20);
            this.pbTick1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTick1.TabIndex = 13;
            this.pbTick1.TabStop = false;
            this.pbTick1.Visible = false;
            // 
            // pbTick2
            // 
            this.pbTick2.BackColor = System.Drawing.Color.Transparent;
            this.pbTick2.Image = ((System.Drawing.Image)(resources.GetObject("pbTick2.Image")));
            this.pbTick2.Location = new System.Drawing.Point(290, 252);
            this.pbTick2.Name = "pbTick2";
            this.pbTick2.Size = new System.Drawing.Size(21, 20);
            this.pbTick2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTick2.TabIndex = 14;
            this.pbTick2.TabStop = false;
            this.pbTick2.Visible = false;
            // 
            // pbCruz1
            // 
            this.pbCruz1.BackColor = System.Drawing.Color.Transparent;
            this.pbCruz1.Image = ((System.Drawing.Image)(resources.GetObject("pbCruz1.Image")));
            this.pbCruz1.Location = new System.Drawing.Point(290, 215);
            this.pbCruz1.Name = "pbCruz1";
            this.pbCruz1.Size = new System.Drawing.Size(21, 20);
            this.pbCruz1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCruz1.TabIndex = 15;
            this.pbCruz1.TabStop = false;
            this.pbCruz1.Visible = false;
            // 
            // pbCruz2
            // 
            this.pbCruz2.BackColor = System.Drawing.Color.Transparent;
            this.pbCruz2.Image = ((System.Drawing.Image)(resources.GetObject("pbCruz2.Image")));
            this.pbCruz2.Location = new System.Drawing.Point(290, 252);
            this.pbCruz2.Name = "pbCruz2";
            this.pbCruz2.Size = new System.Drawing.Size(21, 20);
            this.pbCruz2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCruz2.TabIndex = 16;
            this.pbCruz2.TabStop = false;
            this.pbCruz2.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(107, 252);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.ShortcutsEnabled = false;
            this.txtContraseña.Size = new System.Drawing.Size(177, 20);
            this.txtContraseña.TabIndex = 18;
            this.toolTip1.SetToolTip(this.txtContraseña, "Contraseña");
            this.txtContraseña.Validar = true;
            this.txtContraseña.TextChanged += new System.EventHandler(this.TxtContraseña_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(107, 215);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ShortcutsEnabled = false;
            this.txtUsuario.Size = new System.Drawing.Size(177, 20);
            this.txtUsuario.TabIndex = 17;
            this.txtUsuario.Validar = true;
            this.txtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(400, 351);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pbCruz2);
            this.Controls.Add(this.pbCruz1);
            this.Controls.Add(this.pbTick2);
            this.Controls.Add(this.pbTick1);
            this.Controls.Add(this.pbCandado);
            this.Controls.Add(this.pbImagenUsuarioMini);
            this.Controls.Add(this.pbIniciar);
            this.Controls.Add(this.pbImagenUsuario);
            this.Controls.Add(this.pbMinimizar);
            this.Controls.Add(this.pbCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
         
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenUsuarioMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCandado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTick1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTick2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCruz1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCruz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbImagenUsuario;
        private System.Windows.Forms.PictureBox pbIniciar;
        private System.Windows.Forms.PictureBox pbImagenUsuarioMini;
        private System.Windows.Forms.PictureBox pbCandado;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pbTick1;
        private System.Windows.Forms.PictureBox pbTick2;
        private System.Windows.Forms.PictureBox pbCruz1;
        private System.Windows.Forms.PictureBox pbCruz2;
        private Negocio.ErrorTxtBox txtUsuario;
        private Negocio.ErrorTxtBox txtContraseña;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

