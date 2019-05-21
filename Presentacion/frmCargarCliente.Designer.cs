namespace Presentacion
{
    partial class frmCargarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargarCliente));
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCUIL = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCUIL = new System.Windows.Forms.Label();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblEdadNum = new System.Windows.Forms.Label();
            this.lblTipoPersona = new System.Windows.Forms.Label();
            this.chbFisica = new System.Windows.Forms.CheckBox();
            this.chbJuridica = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(393, 260);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(90, 35);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(504, 260);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 35);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(72, 69);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(237, 20);
            this.txtDNI.TabIndex = 2;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress_1);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(72, 155);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(237, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(72, 112);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(237, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.BackColor = System.Drawing.Color.Transparent;
            this.lblDNI.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.Color.Silver;
            this.lblDNI.Location = new System.Drawing.Point(12, 73);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(31, 16);
            this.lblDNI.TabIndex = 5;
            this.lblDNI.Text = "DNI";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.Silver;
            this.lblApellido.Location = new System.Drawing.Point(12, 159);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(56, 16);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Silver;
            this.lblNombre.Location = new System.Drawing.Point(12, 116);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 16);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // pbCerrar
            // 
            this.pbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCerrar.BackColor = System.Drawing.Color.Transparent;
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(763, 12);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(25, 25);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 8;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(72, 199);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(237, 20);
            this.txtDireccion.TabIndex = 9;
            // 
            // txtCUIL
            // 
            this.txtCUIL.Location = new System.Drawing.Point(72, 242);
            this.txtCUIL.Name = "txtCUIL";
            this.txtCUIL.Size = new System.Drawing.Size(237, 20);
            this.txtCUIL.TabIndex = 10;
            this.txtCUIL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCUIL_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.Silver;
            this.lblDireccion.Location = new System.Drawing.Point(11, 203);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(61, 16);
            this.lblDireccion.TabIndex = 11;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblCUIL
            // 
            this.lblCUIL.AutoSize = true;
            this.lblCUIL.BackColor = System.Drawing.Color.Transparent;
            this.lblCUIL.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUIL.ForeColor = System.Drawing.Color.Silver;
            this.lblCUIL.Location = new System.Drawing.Point(7, 246);
            this.lblCUIL.Name = "lblCUIL";
            this.lblCUIL.Size = new System.Drawing.Size(37, 16);
            this.lblCUIL.TabIndex = 12;
            this.lblCUIL.Text = "CUIL";
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.pbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizar.Image")));
            this.pbMinimizar.Location = new System.Drawing.Point(732, 12);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(25, 25);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizar.TabIndex = 13;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaNac.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.ForeColor = System.Drawing.Color.Silver;
            this.lblFechaNac.Location = new System.Drawing.Point(11, 318);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(70, 16);
            this.lblFechaNac.TabIndex = 14;
            this.lblFechaNac.Text = "Fecha Nac.";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCUIT.Location = new System.Drawing.Point(72, 279);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(237, 23);
            this.txtCUIT.TabIndex = 15;
            this.txtCUIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCUIT_KeyPress);
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.BackColor = System.Drawing.Color.Transparent;
            this.lblCUIT.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUIT.ForeColor = System.Drawing.Color.Silver;
            this.lblCUIT.Location = new System.Drawing.Point(12, 279);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(39, 16);
            this.lblCUIT.TabIndex = 16;
            this.lblCUIT.Text = "CUIT";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(87, 314);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNac.TabIndex = 17;
            this.dtpFechaNac.ValueChanged += new System.EventHandler(this.dtpFechaNac_ValueChanged);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.BackColor = System.Drawing.Color.Transparent;
            this.lblEdad.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.ForeColor = System.Drawing.Color.Silver;
            this.lblEdad.Location = new System.Drawing.Point(293, 314);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(41, 16);
            this.lblEdad.TabIndex = 18;
            this.lblEdad.Text = "Edad:";
            // 
            // lblEdadNum
            // 
            this.lblEdadNum.AutoSize = true;
            this.lblEdadNum.BackColor = System.Drawing.Color.Transparent;
            this.lblEdadNum.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadNum.ForeColor = System.Drawing.Color.Silver;
            this.lblEdadNum.Location = new System.Drawing.Point(340, 314);
            this.lblEdadNum.Name = "lblEdadNum";
            this.lblEdadNum.Size = new System.Drawing.Size(0, 16);
            this.lblEdadNum.TabIndex = 19;
            // 
            // lblTipoPersona
            // 
            this.lblTipoPersona.AutoSize = true;
            this.lblTipoPersona.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoPersona.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPersona.ForeColor = System.Drawing.Color.Silver;
            this.lblTipoPersona.Location = new System.Drawing.Point(340, 73);
            this.lblTipoPersona.Name = "lblTipoPersona";
            this.lblTipoPersona.Size = new System.Drawing.Size(82, 16);
            this.lblTipoPersona.TabIndex = 20;
            this.lblTipoPersona.Text = "Tipo Persona";
            // 
            // chbFisica
            // 
            this.chbFisica.AutoSize = true;
            this.chbFisica.BackColor = System.Drawing.Color.Transparent;
            this.chbFisica.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFisica.ForeColor = System.Drawing.Color.Silver;
            this.chbFisica.Location = new System.Drawing.Point(446, 73);
            this.chbFisica.Name = "chbFisica";
            this.chbFisica.Size = new System.Drawing.Size(56, 20);
            this.chbFisica.TabIndex = 21;
            this.chbFisica.Text = "Fisica";
            this.chbFisica.UseVisualStyleBackColor = false;
            // 
            // chbJuridica
            // 
            this.chbJuridica.AutoSize = true;
            this.chbJuridica.BackColor = System.Drawing.Color.Transparent;
            this.chbJuridica.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbJuridica.ForeColor = System.Drawing.Color.Silver;
            this.chbJuridica.Location = new System.Drawing.Point(504, 74);
            this.chbJuridica.Name = "chbJuridica";
            this.chbJuridica.Size = new System.Drawing.Size(70, 20);
            this.chbJuridica.TabIndex = 22;
            this.chbJuridica.Text = "Juridica";
            this.chbJuridica.UseVisualStyleBackColor = false;
            // 
            // frmCargarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chbJuridica);
            this.Controls.Add(this.chbFisica);
            this.Controls.Add(this.lblTipoPersona);
            this.Controls.Add(this.lblEdadNum);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.lblCUIT);
            this.Controls.Add(this.txtCUIT);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.pbMinimizar);
            this.Controls.Add(this.lblCUIL);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtCUIL);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.pbCerrar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCargarCliente";
            this.Load += new System.EventHandler(this.frmCargarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCUIL;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCUIL;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblEdadNum;
        private System.Windows.Forms.Label lblTipoPersona;
        private System.Windows.Forms.CheckBox chbFisica;
        private System.Windows.Forms.CheckBox chbJuridica;
    }
}