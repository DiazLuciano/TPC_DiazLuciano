namespace Presentacion
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.pbAgregarCliente = new System.Windows.Forms.PictureBox();
            this.pbModificarCliente = new System.Windows.Forms.PictureBox();
            this.pbEliminarCliente = new System.Windows.Forms.PictureBox();
            this.pbBuscarCliente = new System.Windows.Forms.PictureBox();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pbRestaurar = new System.Windows.Forms.PictureBox();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbMaximizar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pbTelefonos = new System.Windows.Forms.PictureBox();
            this.cmbBuscarPor = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtDescripcion = new Negocio.ErrorTxtBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnEliminarLog = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbModificarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelefonos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(15, 194);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(951, 139);
            this.dgvClientes.TabIndex = 0;
            // 
            // pbAgregarCliente
            // 
            this.pbAgregarCliente.BackColor = System.Drawing.Color.Transparent;
            this.pbAgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("pbAgregarCliente.Image")));
            this.pbAgregarCliente.Location = new System.Drawing.Point(747, 65);
            this.pbAgregarCliente.Name = "pbAgregarCliente";
            this.pbAgregarCliente.Size = new System.Drawing.Size(60, 60);
            this.pbAgregarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAgregarCliente.TabIndex = 6;
            this.pbAgregarCliente.TabStop = false;
            this.toolTip1.SetToolTip(this.pbAgregarCliente, "Agregar");
            this.pbAgregarCliente.Click += new System.EventHandler(this.pbAgregarCliente_Click);
            // 
            // pbModificarCliente
            // 
            this.pbModificarCliente.BackColor = System.Drawing.Color.Transparent;
            this.pbModificarCliente.Image = ((System.Drawing.Image)(resources.GetObject("pbModificarCliente.Image")));
            this.pbModificarCliente.Location = new System.Drawing.Point(822, 65);
            this.pbModificarCliente.Name = "pbModificarCliente";
            this.pbModificarCliente.Size = new System.Drawing.Size(60, 60);
            this.pbModificarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbModificarCliente.TabIndex = 7;
            this.pbModificarCliente.TabStop = false;
            this.toolTip1.SetToolTip(this.pbModificarCliente, "Modificar");
            this.pbModificarCliente.Click += new System.EventHandler(this.pbModificarCliente_Click);
            // 
            // pbEliminarCliente
            // 
            this.pbEliminarCliente.BackColor = System.Drawing.Color.Transparent;
            this.pbEliminarCliente.Image = ((System.Drawing.Image)(resources.GetObject("pbEliminarCliente.Image")));
            this.pbEliminarCliente.Location = new System.Drawing.Point(898, 65);
            this.pbEliminarCliente.Name = "pbEliminarCliente";
            this.pbEliminarCliente.Size = new System.Drawing.Size(60, 60);
            this.pbEliminarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEliminarCliente.TabIndex = 8;
            this.pbEliminarCliente.TabStop = false;
            this.toolTip1.SetToolTip(this.pbEliminarCliente, "Eliminar");
            this.pbEliminarCliente.Click += new System.EventHandler(this.pbEliminarCliente_Click);
            // 
            // pbBuscarCliente
            // 
            this.pbBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.pbBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscarCliente.Image")));
            this.pbBuscarCliente.Location = new System.Drawing.Point(423, 51);
            this.pbBuscarCliente.Name = "pbBuscarCliente";
            this.pbBuscarCliente.Size = new System.Drawing.Size(50, 44);
            this.pbBuscarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscarCliente.TabIndex = 9;
            this.pbBuscarCliente.TabStop = false;
            this.toolTip1.SetToolTip(this.pbBuscarCliente, "Buscar");
            // 
            // pbCerrar
            // 
            this.pbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCerrar.BackColor = System.Drawing.Color.Transparent;
            this.pbCerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(941, 11);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(25, 25);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 10;
            this.pbCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.pbCerrar, "Cerrar");
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // pbRestaurar
            // 
            this.pbRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRestaurar.BackColor = System.Drawing.Color.Transparent;
            this.pbRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("pbRestaurar.Image")));
            this.pbRestaurar.Location = new System.Drawing.Point(910, 12);
            this.pbRestaurar.Name = "pbRestaurar";
            this.pbRestaurar.Size = new System.Drawing.Size(25, 25);
            this.pbRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRestaurar.TabIndex = 11;
            this.pbRestaurar.TabStop = false;
            this.toolTip1.SetToolTip(this.pbRestaurar, "Restaurar");
            this.pbRestaurar.Visible = false;
            this.pbRestaurar.Click += new System.EventHandler(this.pbRestaurar_Click);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.pbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizar.Image")));
            this.pbMinimizar.Location = new System.Drawing.Point(879, 11);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(25, 25);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizar.TabIndex = 12;
            this.pbMinimizar.TabStop = false;
            this.toolTip1.SetToolTip(this.pbMinimizar, "Minimizar");
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // pbMaximizar
            // 
            this.pbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.pbMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMaximizar.Image")));
            this.pbMaximizar.Location = new System.Drawing.Point(910, 11);
            this.pbMaximizar.Name = "pbMaximizar";
            this.pbMaximizar.Size = new System.Drawing.Size(25, 25);
            this.pbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMaximizar.TabIndex = 13;
            this.pbMaximizar.TabStop = false;
            this.toolTip1.SetToolTip(this.pbMaximizar, "Maximizar");
            this.pbMaximizar.Click += new System.EventHandler(this.pbMaximizar_Click);
            // 
            // pbTelefonos
            // 
            this.pbTelefonos.AccessibleName = "pbTelefono";
            this.pbTelefonos.BackColor = System.Drawing.Color.Transparent;
            this.pbTelefonos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTelefonos.Image = ((System.Drawing.Image)(resources.GetObject("pbTelefonos.Image")));
            this.pbTelefonos.Location = new System.Drawing.Point(668, 65);
            this.pbTelefonos.Name = "pbTelefonos";
            this.pbTelefonos.Size = new System.Drawing.Size(60, 61);
            this.pbTelefonos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTelefonos.TabIndex = 15;
            this.pbTelefonos.TabStop = false;
            this.toolTip1.SetToolTip(this.pbTelefonos, "Ver Telefonos");
            this.pbTelefonos.Click += new System.EventHandler(this.PbTelefonos_Click);
            // 
            // cmbBuscarPor
            // 
            this.cmbBuscarPor.FormattingEnabled = true;
            this.cmbBuscarPor.Location = new System.Drawing.Point(12, 65);
            this.cmbBuscarPor.Name = "cmbBuscarPor";
            this.cmbBuscarPor.Size = new System.Drawing.Size(121, 21);
            this.cmbBuscarPor.TabIndex = 14;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(139, 65);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(278, 20);
            this.txtDescripcion.SoloNumeros = false;
            this.txtDescripcion.TabIndex = 16;
            this.txtDescripcion.Validar = true;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(761, 153);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(106, 23);
            this.btnCliente.TabIndex = 17;
            this.btnCliente.Text = "Ver Completo";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // btnEliminarLog
            // 
            this.btnEliminarLog.Location = new System.Drawing.Point(888, 153);
            this.btnEliminarLog.Name = "btnEliminarLog";
            this.btnEliminarLog.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarLog.TabIndex = 18;
            this.btnEliminarLog.Text = "Baja Fisica";
            this.btnEliminarLog.UseVisualStyleBackColor = true;
            this.btnEliminarLog.Click += new System.EventHandler(this.BtnEliminarLog_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(15, 153);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(106, 23);
            this.btnSeleccionar.TabIndex = 19;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(975, 391);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnEliminarLog);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.pbTelefonos);
            this.Controls.Add(this.cmbBuscarPor);
            this.Controls.Add(this.pbMaximizar);
            this.Controls.Add(this.pbMinimizar);
            this.Controls.Add(this.pbRestaurar);
            this.Controls.Add(this.pbCerrar);
            this.Controls.Add(this.pbBuscarCliente);
            this.Controls.Add(this.pbEliminarCliente);
            this.Controls.Add(this.pbModificarCliente);
            this.Controls.Add(this.pbAgregarCliente);
            this.Controls.Add(this.dgvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VerClientes_FormClosing);
            this.Load += new System.EventHandler(this.VerClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbModificarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelefonos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.PictureBox pbAgregarCliente;
        private System.Windows.Forms.PictureBox pbModificarCliente;
        private System.Windows.Forms.PictureBox pbEliminarCliente;
        private System.Windows.Forms.PictureBox pbBuscarCliente;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.PictureBox pbRestaurar;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbMaximizar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cmbBuscarPor;
        private System.Windows.Forms.PictureBox pbTelefonos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Negocio.ErrorTxtBox txtDescripcion;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnEliminarLog;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}