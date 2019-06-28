using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Factura
    {
        public long NumFac { get; set; }
        public DateTime Fecha_fac { get; set; }
        public long dniCliente { get; set; }
        public decimal precioV { get; set; }
        public int cantV { get; set; }
        public string nombreC { get; set; }
        public string descripcionP { get; set; }
        public decimal Importe { get; set; }

    }
}
