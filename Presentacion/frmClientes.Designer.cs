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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.pbAgregarCliente = new System.Windows.Forms.PictureBox();
            this.pbModificarCliente = new System.Windows.Forms.PictureBox();
            this.pbEliminarCliente = new System.Windows.Forms.PictureBox();
            this.pbBuscarCliente = new System.Windows.Forms.PictureBox();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pbRestaurar = new System.Windows.Forms.PictureBox();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbMaximizar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbBuscarPor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbModificarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).BeginInit();
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
            this.dgvClientes.Location = new System.Drawing.Point(12, 131);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(951, 139);
            this.dgvClientes.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(140, 66);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(268, 20);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // pbAgregarCliente
            // 
            this.pbAgregarCliente.BackColor = System.Drawing.Color.Transparent;
            this.pbAgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("pbAgregarCliente.Image")));
            this.pbAgregarCliente.Location = new System.Drawing.Point(602, 51);
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
            this.pbModificarCliente.Location = new System.Drawing.Point(677, 51);
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
            this.pbEliminarCliente.Location = new System.Drawing.Point(753, 51);
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
            // cmbBuscarPor
            // 
            this.cmbBuscarPor.FormattingEnabled = true;
            this.cmbBuscarPor.Location = new System.Drawing.Point(12, 65);
            this.cmbBuscarPor.Name = "cmbBuscarPor";
            this.cmbBuscarPor.Size = new System.Drawing.Size(121, 21);
            this.cmbBuscarPor.TabIndex = 14;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(975, 391);
            this.Controls.Add(this.cmbBuscarPor);
            this.Controls.Add(this.pbMaximizar);
            this.Controls.Add(this.pbMinimizar);
            this.Controls.Add(this.pbRestaurar);
            this.Controls.Add(this.pbCerrar);
            this.Controls.Add(this.pbBuscarCliente);
            this.Controls.Add(this.pbEliminarCliente);
            this.Controls.Add(this.pbModificarCliente);
            this.Controls.Add(this.pbAgregarCliente);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.dgvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClientes";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtDescripcion;
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
    }
}