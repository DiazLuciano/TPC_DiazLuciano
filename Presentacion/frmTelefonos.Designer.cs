﻿namespace Presentacion
{
    partial class frmTelefonos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelefonos));
            this.dgvTelefonos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtIDCli = new Negocio.ErrorTxtBox();
            this.lblIDCli = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTelefonos
            // 
            this.dgvTelefonos.AccessibleName = "";
            this.dgvTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefonos.Location = new System.Drawing.Point(12, 138);
            this.dgvTelefonos.Name = "dgvTelefonos";
            this.dgvTelefonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelefonos.Size = new System.Drawing.Size(758, 150);
            this.dgvTelefonos.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.AccessibleName = "btnSalir";
            this.button1.Location = new System.Drawing.Point(657, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AccessibleName = "btnSalir";
            this.btnEliminar.Location = new System.Drawing.Point(657, 90);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleName = "btnSalir";
            this.btnAgregar.Location = new System.Drawing.Point(576, 90);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // txtIDCli
            // 
            this.txtIDCli.Location = new System.Drawing.Point(99, 101);
            this.txtIDCli.Name = "txtIDCli";
            this.txtIDCli.Size = new System.Drawing.Size(42, 20);
            this.txtIDCli.SoloNumeros = false;
            this.txtIDCli.TabIndex = 4;
            this.txtIDCli.Validar = false;
            // 
            // lblIDCli
            // 
            this.lblIDCli.AutoSize = true;
            this.lblIDCli.BackColor = System.Drawing.Color.Transparent;
            this.lblIDCli.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCli.ForeColor = System.Drawing.Color.LightGray;
            this.lblIDCli.Location = new System.Drawing.Point(12, 100);
            this.lblIDCli.Name = "lblIDCli";
            this.lblIDCli.Size = new System.Drawing.Size(90, 19);
            this.lblIDCli.TabIndex = 5;
            this.lblIDCli.Text = "ID Cliente: ";
            // 
            // frmTelefonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIDCli);
            this.Controls.Add(this.txtIDCli);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvTelefonos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTelefonos";
            this.Text = "frmTelefonos";
            this.Load += new System.EventHandler(this.FrmTelefonos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTelefonos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private Negocio.ErrorTxtBox txtIDCli;
        private System.Windows.Forms.Label lblIDCli;
    }
}