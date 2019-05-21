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
            this.lblCUILCUIT = new System.Windows.Forms.Label();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblEdadNum = new System.Windows.Forms.Label();
            this.lblTipoPersona = new System.Windows.Forms.Label();
            this.chbFisica = new System.Windows.Forms.CheckBox();
            this.chbJuridica = new System.Windows.Forms.CheckBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.cmbTipoTel = new System.Windows.Forms.ComboBox();
            this.lblTipoTel = new System.Windows.Forms.Label();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbOtro = new System.Windows.Forms.RadioButton();
            this.gpbGenero = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            this.gpbGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(385, 318);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(90, 35);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(481, 318);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 35);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(99, 109);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(237, 20);
            this.txtDNI.TabIndex = 2;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress_1);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(99, 181);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(237, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(99, 145);
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
            this.lblDNI.Location = new System.Drawing.Point(57, 113);
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
            this.lblApellido.Location = new System.Drawing.Point(37, 185);
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
            this.lblNombre.Location = new System.Drawing.Point(38, 146);
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
            this.txtDireccion.Location = new System.Drawing.Point(99, 217);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(237, 20);
            this.txtDireccion.TabIndex = 9;
            // 
            // txtCUIL
            // 
            this.txtCUIL.Location = new System.Drawing.Point(99, 253);
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
            this.lblDireccion.Location = new System.Drawing.Point(27, 221);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(61, 16);
            this.lblDireccion.TabIndex = 11;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblCUILCUIT
            // 
            this.lblCUILCUIT.AutoSize = true;
            this.lblCUILCUIT.BackColor = System.Drawing.Color.Transparent;
            this.lblCUILCUIT.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUILCUIT.ForeColor = System.Drawing.Color.Silver;
            this.lblCUILCUIT.Location = new System.Drawing.Point(22, 257);
            this.lblCUILCUIT.Name = "lblCUILCUIT";
            this.lblCUILCUIT.Size = new System.Drawing.Size(73, 16);
            this.lblCUILCUIT.TabIndex = 12;
            this.lblCUILCUIT.Text = "CUIL/CUIT";
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
            this.lblFechaNac.Location = new System.Drawing.Point(18, 299);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(70, 16);
            this.lblFechaNac.TabIndex = 14;
            this.lblFechaNac.Text = "Fecha Nac.";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(99, 295);
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
            this.lblEdad.Location = new System.Drawing.Point(47, 327);
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
            this.lblTipoPersona.Location = new System.Drawing.Point(366, 110);
            this.lblTipoPersona.Name = "lblTipoPersona";
            this.lblTipoPersona.Size = new System.Drawing.Size(82, 16);
            this.lblTipoPersona.TabIndex = 20;
            this.lblTipoPersona.Text = "Tipo Persona";
            // 
            // chbFisica
            // 
            this.chbFisica.AutoSize = true;
            this.chbFisica.BackColor = System.Drawing.Color.Transparent;
            this.chbFisica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbFisica.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFisica.ForeColor = System.Drawing.Color.Silver;
            this.chbFisica.Location = new System.Drawing.Point(481, 106);
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
            this.chbJuridica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbJuridica.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbJuridica.ForeColor = System.Drawing.Color.Silver;
            this.chbJuridica.Location = new System.Drawing.Point(543, 106);
            this.chbJuridica.Name = "chbJuridica";
            this.chbJuridica.Size = new System.Drawing.Size(70, 20);
            this.chbJuridica.TabIndex = 22;
            this.chbJuridica.Text = "Juridica";
            this.chbJuridica.UseVisualStyleBackColor = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.Location = new System.Drawing.Point(-250, 116);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(237, 20);
            this.txtTelefono.TabIndex = 23;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.Silver;
            this.lblTelefono.Location = new System.Drawing.Point(366, 149);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(58, 16);
            this.lblTelefono.TabIndex = 24;
            this.lblTelefono.Text = "Telefono";
            // 
            // cmbTipoTel
            // 
            this.cmbTipoTel.FormattingEnabled = true;
            this.cmbTipoTel.Location = new System.Drawing.Point(430, 185);
            this.cmbTipoTel.Name = "cmbTipoTel";
            this.cmbTipoTel.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoTel.TabIndex = 25;
            // 
            // lblTipoTel
            // 
            this.lblTipoTel.AutoSize = true;
            this.lblTipoTel.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoTel.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoTel.ForeColor = System.Drawing.Color.Silver;
            this.lblTipoTel.Location = new System.Drawing.Point(389, 185);
            this.lblTipoTel.Name = "lblTipoTel";
            this.lblTipoTel.Size = new System.Drawing.Size(35, 16);
            this.lblTipoTel.TabIndex = 26;
            this.lblTipoTel.Text = "Tipo";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.BackColor = System.Drawing.Color.Transparent;
            this.rdbMasculino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbMasculino.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMasculino.ForeColor = System.Drawing.Color.Silver;
            this.rdbMasculino.Location = new System.Drawing.Point(14, 20);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(82, 20);
            this.rdbMasculino.TabIndex = 27;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = false;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.BackColor = System.Drawing.Color.Transparent;
            this.rdbFemenino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbFemenino.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemenino.ForeColor = System.Drawing.Color.Silver;
            this.rdbFemenino.Location = new System.Drawing.Point(102, 19);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(81, 20);
            this.rdbFemenino.TabIndex = 28;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = false;
            // 
            // rdbOtro
            // 
            this.rdbOtro.AutoSize = true;
            this.rdbOtro.BackColor = System.Drawing.Color.Transparent;
            this.rdbOtro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbOtro.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOtro.ForeColor = System.Drawing.Color.Silver;
            this.rdbOtro.Location = new System.Drawing.Point(189, 19);
            this.rdbOtro.Name = "rdbOtro";
            this.rdbOtro.Size = new System.Drawing.Size(54, 20);
            this.rdbOtro.TabIndex = 29;
            this.rdbOtro.TabStop = true;
            this.rdbOtro.Text = "Otro";
            this.rdbOtro.UseVisualStyleBackColor = false;
            // 
            // gpbGenero
            // 
            this.gpbGenero.BackColor = System.Drawing.Color.Transparent;
            this.gpbGenero.Controls.Add(this.rdbOtro);
            this.gpbGenero.Controls.Add(this.rdbFemenino);
            this.gpbGenero.Controls.Add(this.rdbMasculino);
            this.gpbGenero.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbGenero.ForeColor = System.Drawing.Color.Silver;
            this.gpbGenero.Location = new System.Drawing.Point(379, 221);
            this.gpbGenero.Name = "gpbGenero";
            this.gpbGenero.Size = new System.Drawing.Size(273, 60);
            this.gpbGenero.TabIndex = 30;
            this.gpbGenero.TabStop = false;
            this.gpbGenero.Text = "Genero";
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "txtTelefono";
            this.textBox1.Location = new System.Drawing.Point(430, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 31;
            // 
            // frmCargarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gpbGenero);
            this.Controls.Add(this.lblTipoTel);
            this.Controls.Add(this.cmbTipoTel);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.chbJuridica);
            this.Controls.Add(this.chbFisica);
            this.Controls.Add(this.lblTipoPersona);
            this.Controls.Add(this.lblEdadNum);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.pbMinimizar);
            this.Controls.Add(this.lblCUILCUIT);
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
            this.gpbGenero.ResumeLayout(false);
            this.gpbGenero.PerformLayout();
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
        private System.Windows.Forms.Label lblCUILCUIT;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblEdadNum;
        private System.Windows.Forms.Label lblTipoPersona;
        private System.Windows.Forms.CheckBox chbFisica;
        private System.Windows.Forms.CheckBox chbJuridica;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.ComboBox cmbTipoTel;
        private System.Windows.Forms.Label lblTipoTel;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbOtro;
        private System.Windows.Forms.GroupBox gpbGenero;
        private System.Windows.Forms.TextBox textBox1;
    }
}