using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.SP_DatosFactura' Puede moverla o quitarla según sea necesario.
          
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.SP_DatosFactura' Puede moverla o quitarla según sea necesario.
            //this.SP_DatosFacturaTableAdapter.Fill(this.DataSet1.SP_DatosFactura);

            this.reportViewer1.Show();
            this.reportViewer1.RefreshReport();
        }
    }
}
