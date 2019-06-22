namespace Presentacion
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pbCliente = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pbProducto = new System.Windows.Forms.PictureBox();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbMaximizar = new System.Windows.Forms.PictureBox();
            this.pbRestaurar = new System.Windows.Forms.PictureBox();
            this.pbCompra = new System.Windows.Forms.PictureBox();
            this.pbCentro = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCentro)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCliente
            // 
            this.pbCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCliente.BackColor = System.Drawing.Color.Transparent;
            this.pbCliente.Image = ((System.Drawing.Image)(resources.GetObject("pbCliente.Image")));
            this.pbCliente.Location = new System.Drawing.Point(351, 250);
            this.pbCliente.Name = "pbCliente";
            this.pbCliente.Size = new System.Drawing.Size(60, 60);
            this.pbCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCliente.TabIndex = 1;
            this.pbCliente.TabStop = false;
            this.toolTip1.SetToolTip(this.pbCliente, "Clientes");
            this.pbCliente.Click += new System.EventHandler(this.pbCliente_Click);
            // 
            // pbProducto
            // 
            this.pbProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbProducto.BackColor = System.Drawing.Color.Transparent;
            this.pbProducto.Image = ((System.Drawing.Image)(resources.GetObject("pbProducto.Image")));
            this.pbProducto.Location = new System.Drawing.Point(623, 250);
            this.pbProducto.Name = "pbProducto";
            this.pbProducto.Size = new System.Drawing.Size(60, 60);
            this.pbProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProducto.TabIndex = 3;
            this.pbProducto.TabStop = false;
            this.toolTip1.SetToolTip(this.pbProducto, "Articulos");
            this.pbProducto.Click += new System.EventHandler(this.pbProducto_Click);
            // 
            // pbCerrar
            // 
            this.pbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCerrar.BackColor = System.Drawing.Color.Transparent;
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(965, 15);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(25, 25);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 4;
            this.pbCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.pbCerrar, "Cerrar");
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.pbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizar.Image")));
            this.pbMinimizar.Location = new System.Drawing.Point(903, 15);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(25, 25);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizar.TabIndex = 5;
            this.pbMinimizar.TabStop = false;
            this.toolTip1.SetToolTip(this.pbMinimizar, "Minimizar");
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // pbMaximizar
            // 
            this.pbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.pbMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMaximizar.Image")));
            this.pbMaximizar.Location = new System.Drawing.Point(934, 15);
            this.pbMaximizar.Name = "pbMaximizar";
            this.pbMaximizar.Size = new System.Drawing.Size(25, 25);
            this.pbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMaximizar.TabIndex = 6;
            this.pbMaximizar.TabStop = false;
            this.toolTip1.SetToolTip(this.pbMaximizar, "Maximizar");
            this.pbMaximizar.Click += new System.EventHandler(this.pbMaximizar_Click);
            // 
            // pbRestaurar
            // 
            this.pbRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRestaurar.BackColor = System.Drawing.Color.Transparent;
            this.pbRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("pbRestaurar.Image")));
            this.pbRestaurar.Location = new System.Drawing.Point(934, 15);
            this.pbRestaurar.Name = "pbRestaurar";
            this.pbRestaurar.Size = new System.Drawing.Size(25, 25);
            this.pbRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRestaurar.TabIndex = 7;
            this.pbRestaurar.TabStop = false;
            this.toolTip1.SetToolTip(this.pbRestaurar, "Restaurar");
            this.pbRestaurar.Visible = false;
            this.pbRestaurar.Click += new System.EventHandler(this.pbRestaurar_Click);
            // 
            // pbCompra
            // 
            this.pbCompra.BackColor = System.Drawing.Color.Transparent;
            this.pbCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCompra.Image = ((System.Drawing.Image)(resources.GetObject("pbCompra.Image")));
            this.pbCompra.Location = new System.Drawing.Point(492, 234);
            this.pbCompra.Name = "pbCompra";
            this.pbCompra.Size = new System.Drawing.Size(60, 60);
            this.pbCompra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCompra.TabIndex = 9;
            this.pbCompra.TabStop = false;
            this.toolTip1.SetToolTip(this.pbCompra, "Compra");
            this.pbCompra.Click += new System.EventHandler(this.PbCompra_Click);
            // 
            // pbCentro
            // 
            this.pbCentro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCentro.BackColor = System.Drawing.Color.Transparent;
            this.pbCentro.Image = ((System.Drawing.Image)(resources.GetObject("pbCentro.Image")));
            this.pbCentro.Location = new System.Drawing.Point(417, 300);
            this.pbCentro.Name = "pbCentro";
            this.pbCentro.Size = new System.Drawing.Size(200, 200);
            this.pbCentro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCentro.TabIndex = 2;
            this.pbCentro.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.pbRestaurar);
            this.panel1.Controls.Add(this.pbCerrar);
            this.panel1.Controls.Add(this.pbMaximizar);
            this.panel1.Controls.Add(this.pbMinimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 51);
            this.panel1.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pbCompra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbProducto);
            this.Controls.Add(this.pbCentro);
            this.Controls.Add(this.pbCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pbCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCentro)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbCliente;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pbCentro;
        private System.Windows.Forms.PictureBox pbProducto;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbMaximizar;
        private System.Windows.Forms.PictureBox pbRestaurar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pbCompra;
    }
}