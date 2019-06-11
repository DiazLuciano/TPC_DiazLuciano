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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargarCliente));
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.txtCUIL = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCUIL = new System.Windows.Forms.Label();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblEdadNum = new System.Windows.Forms.Label();
            this.lblTipoPersona = new System.Windows.Forms.Label();
            this.chbFisica = new System.Windows.Forms.CheckBox();
            this.chbJuridica = new System.Windows.Forms.CheckBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.cmbTipoTel = new System.Windows.Forms.ComboBox();
            this.lblTipoTel = new System.Windows.Forms.Label();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbOtro = new System.Windows.Forms.RadioButton();
            this.gpbGenero = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtRazonS = new System.Windows.Forms.TextBox();
            this.lblRazonS = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtDNI = new Negocio.ErrorTxtBox();
            this.txtNombre = new Negocio.ErrorTxtBox();
            this.txtApellido = new Negocio.ErrorTxtBox();
            this.txtDireccion = new Negocio.ErrorTxtBox();
            this.txtLocalidad = new Negocio.ErrorTxtBox();
            this.txtCP = new Negocio.ErrorTxtBox();
            this.txtProvincia = new Negocio.ErrorTxtBox();
            this.txtCiudad = new Negocio.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            this.gpbGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(366, 430);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(90, 35);
            this.btnCargar.TabIndex = 23;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(476, 430);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 35);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.BackColor = System.Drawing.Color.Transparent;
            this.lblDNI.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.Color.Silver;
            this.lblDNI.Location = new System.Drawing.Point(57, 36);
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
            this.lblApellido.Location = new System.Drawing.Point(37, 108);
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
            this.lblNombre.Location = new System.Drawing.Point(38, 69);
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
            this.pbCerrar.Location = new System.Drawing.Point(864, 12);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(25, 25);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 8;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // txtCUIL
            // 
            this.txtCUIL.Location = new System.Drawing.Point(99, 344);
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
            this.lblDireccion.Location = new System.Drawing.Point(27, 143);
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
            this.lblCUIL.Location = new System.Drawing.Point(48, 348);
            this.lblCUIL.Name = "lblCUIL";
            this.lblCUIL.Size = new System.Drawing.Size(37, 16);
            this.lblCUIL.TabIndex = 12;
            this.lblCUIL.Text = "CUIL";
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.pbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizar.Image")));
            this.pbMinimizar.Location = new System.Drawing.Point(833, 12);
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
            this.lblFechaNac.Location = new System.Drawing.Point(18, 407);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(70, 16);
            this.lblFechaNac.TabIndex = 14;
            this.lblFechaNac.Text = "Fecha Nac.";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(99, 403);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNac.TabIndex = 12;
            this.dtpFechaNac.ValueChanged += new System.EventHandler(this.dtpFechaNac_ValueChanged);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.BackColor = System.Drawing.Color.Transparent;
            this.lblEdad.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.ForeColor = System.Drawing.Color.Silver;
            this.lblEdad.Location = new System.Drawing.Point(47, 434);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(41, 16);
            this.lblEdad.TabIndex = 18;
            this.lblEdad.Text = "Edad:";
            // 
            // lblEdadNum
            // 
            this.lblEdadNum.AutoSize = true;
            this.lblEdadNum.BackColor = System.Drawing.Color.Transparent;
            this.lblEdadNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEdadNum.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadNum.ForeColor = System.Drawing.Color.Silver;
            this.lblEdadNum.Location = new System.Drawing.Point(96, 434);
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
            this.lblTipoPersona.Location = new System.Drawing.Point(374, 139);
            this.lblTipoPersona.Name = "lblTipoPersona";
            this.lblTipoPersona.Size = new System.Drawing.Size(82, 16);
            this.lblTipoPersona.TabIndex = 20;
            this.lblTipoPersona.Text = "Tipo Persona";
            // 
            // chbFisica
            // 
            this.chbFisica.AutoSize = true;
            this.chbFisica.BackColor = System.Drawing.Color.Transparent;
            this.chbFisica.Checked = true;
            this.chbFisica.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFisica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbFisica.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFisica.ForeColor = System.Drawing.Color.Silver;
            this.chbFisica.Location = new System.Drawing.Point(476, 139);
            this.chbFisica.Name = "chbFisica";
            this.chbFisica.Size = new System.Drawing.Size(56, 20);
            this.chbFisica.TabIndex = 17;
            this.chbFisica.Text = "Fisica";
            this.chbFisica.UseVisualStyleBackColor = false;
            this.chbFisica.Click += new System.EventHandler(this.chbFisica_Click);
            // 
            // chbJuridica
            // 
            this.chbJuridica.AutoSize = true;
            this.chbJuridica.BackColor = System.Drawing.Color.Transparent;
            this.chbJuridica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbJuridica.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbJuridica.ForeColor = System.Drawing.Color.Silver;
            this.chbJuridica.Location = new System.Drawing.Point(550, 139);
            this.chbJuridica.Name = "chbJuridica";
            this.chbJuridica.Size = new System.Drawing.Size(70, 20);
            this.chbJuridica.TabIndex = 18;
            this.chbJuridica.Text = "Juridica";
            this.chbJuridica.UseVisualStyleBackColor = false;
            this.chbJuridica.Click += new System.EventHandler(this.chbJuridica_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.Silver;
            this.lblTelefono.Location = new System.Drawing.Point(380, 250);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(58, 16);
            this.lblTelefono.TabIndex = 24;
            this.lblTelefono.Text = "Telefono";
            // 
            // cmbTipoTel
            // 
            this.cmbTipoTel.FormattingEnabled = true;
            this.cmbTipoTel.Location = new System.Drawing.Point(444, 280);
            this.cmbTipoTel.Name = "cmbTipoTel";
            this.cmbTipoTel.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoTel.TabIndex = 21;
            // 
            // lblTipoTel
            // 
            this.lblTipoTel.AutoSize = true;
            this.lblTipoTel.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoTel.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoTel.ForeColor = System.Drawing.Color.Silver;
            this.lblTipoTel.Location = new System.Drawing.Point(400, 281);
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
            this.rdbMasculino.TabIndex = 14;
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
            this.rdbFemenino.TabIndex = 15;
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
            this.rdbOtro.TabIndex = 16;
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
            this.gpbGenero.Location = new System.Drawing.Point(408, 69);
            this.gpbGenero.Name = "gpbGenero";
            this.gpbGenero.Size = new System.Drawing.Size(273, 60);
            this.gpbGenero.TabIndex = 15;
            this.gpbGenero.TabStop = false;
            this.gpbGenero.Text = "Género";
            // 
            // txtTelefono
            // 
            this.txtTelefono.AccessibleName = "txtTelefono";
            this.txtTelefono.Location = new System.Drawing.Point(444, 249);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(237, 20);
            this.txtTelefono.TabIndex = 20;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.BackColor = System.Drawing.Color.Transparent;
            this.lblLocalidad.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.ForeColor = System.Drawing.Color.Silver;
            this.lblLocalidad.Location = new System.Drawing.Point(31, 174);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(62, 16);
            this.lblLocalidad.TabIndex = 33;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.BackColor = System.Drawing.Color.Transparent;
            this.lblCP.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCP.ForeColor = System.Drawing.Color.Silver;
            this.lblCP.Location = new System.Drawing.Point(61, 213);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(24, 16);
            this.lblCP.TabIndex = 35;
            this.lblCP.Text = "CP";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(444, 32);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(237, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(400, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Email";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.BackColor = System.Drawing.Color.Transparent;
            this.lblProvincia.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.ForeColor = System.Drawing.Color.Silver;
            this.lblProvincia.Location = new System.Drawing.Point(27, 285);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(60, 16);
            this.lblProvincia.TabIndex = 46;
            this.lblProvincia.Text = "Provincia";
            // 
            // txtRazonS
            // 
            this.txtRazonS.Enabled = false;
            this.txtRazonS.Location = new System.Drawing.Point(444, 213);
            this.txtRazonS.Name = "txtRazonS";
            this.txtRazonS.Size = new System.Drawing.Size(237, 20);
            this.txtRazonS.TabIndex = 19;
            // 
            // lblRazonS
            // 
            this.lblRazonS.AutoSize = true;
            this.lblRazonS.BackColor = System.Drawing.Color.Transparent;
            this.lblRazonS.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonS.ForeColor = System.Drawing.Color.Silver;
            this.lblRazonS.Location = new System.Drawing.Point(359, 214);
            this.lblRazonS.Name = "lblRazonS";
            this.lblRazonS.Size = new System.Drawing.Size(79, 16);
            this.lblRazonS.TabIndex = 48;
            this.lblRazonS.Text = "Razon Social";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.BackColor = System.Drawing.Color.Transparent;
            this.lblCiudad.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.ForeColor = System.Drawing.Color.Silver;
            this.lblCiudad.Location = new System.Drawing.Point(39, 249);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(49, 16);
            this.lblCiudad.TabIndex = 49;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Enabled = false;
            this.txtCUIT.Location = new System.Drawing.Point(99, 374);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(237, 20);
            this.txtCUIT.TabIndex = 11;
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.BackColor = System.Drawing.Color.Transparent;
            this.lblCUIT.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUIT.ForeColor = System.Drawing.Color.Silver;
            this.lblCUIT.Location = new System.Drawing.Point(46, 378);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(39, 16);
            this.lblCUIT.TabIndex = 52;
            this.lblCUIT.Text = "CUIT";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(99, 32);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(237, 20);
            this.txtDNI.SoloNumeros = true;
            this.txtDNI.TabIndex = 53;
            this.txtDNI.Validar = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(99, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(237, 20);
            this.txtNombre.SoloNumeros = false;
            this.txtNombre.TabIndex = 54;
            this.txtNombre.Validar = true;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(99, 103);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(237, 20);
            this.txtApellido.SoloNumeros = false;
            this.txtApellido.TabIndex = 55;
            this.txtApellido.Validar = true;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(99, 138);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(237, 20);
            this.txtDireccion.SoloNumeros = false;
            this.txtDireccion.TabIndex = 56;
            this.txtDireccion.Validar = true;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(99, 174);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(237, 20);
            this.txtLocalidad.SoloNumeros = false;
            this.txtLocalidad.TabIndex = 57;
            this.txtLocalidad.Validar = true;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(99, 212);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(237, 20);
            this.txtCP.SoloNumeros = true;
            this.txtCP.TabIndex = 58;
            this.txtCP.Validar = true;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(99, 280);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(237, 20);
            this.txtProvincia.SoloNumeros = false;
            this.txtProvincia.TabIndex = 59;
            this.txtProvincia.Validar = true;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(99, 246);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(237, 20);
            this.txtCiudad.SoloNumeros = false;
            this.txtCiudad.TabIndex = 60;
            this.txtCiudad.Validar = true;
            // 
            // frmCargarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 477);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblCUIT);
            this.Controls.Add(this.txtCUIT);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblRazonS);
            this.Controls.Add(this.txtRazonS);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.gpbGenero);
            this.Controls.Add(this.lblTipoTel);
            this.Controls.Add(this.cmbTipoTel);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.chbJuridica);
            this.Controls.Add(this.chbFisica);
            this.Controls.Add(this.lblTipoPersona);
            this.Controls.Add(this.lblEdadNum);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.pbMinimizar);
            this.Controls.Add(this.lblCUIL);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtCUIL);
            this.Controls.Add(this.pbCerrar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCargarCliente";
            this.Load += new System.EventHandler(this.frmCargarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            this.gpbGenero.ResumeLayout(false);
            this.gpbGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.TextBox txtCUIL;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCUIL;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblEdadNum;
        private System.Windows.Forms.Label lblTipoPersona;
        private System.Windows.Forms.CheckBox chbFisica;
        private System.Windows.Forms.CheckBox chbJuridica;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.ComboBox cmbTipoTel;
        private System.Windows.Forms.Label lblTipoTel;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbOtro;
        private System.Windows.Forms.GroupBox gpbGenero;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.TextBox txtRazonS;
        private System.Windows.Forms.Label lblRazonS;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Label lblCUIT;
        private Negocio.ErrorTxtBox txtDNI;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Negocio.ErrorTxtBox txtCiudad;
        private Negocio.ErrorTxtBox txtProvincia;
        private Negocio.ErrorTxtBox txtCP;
        private Negocio.ErrorTxtBox txtLocalidad;
        private Negocio.ErrorTxtBox txtDireccion;
        private Negocio.ErrorTxtBox txtApellido;
        private Negocio.ErrorTxtBox txtNombre;
    }
}