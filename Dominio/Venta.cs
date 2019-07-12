using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Venta
    {
        public int ID { get; set; }
        public DateTime horadeventa { get; set; }
        public DateTime fechaventa { get; set; }
        public int cantidad { get; set; }
        public Articulo articulovendido { get; set; }

        public List<VentaDetalle> ventaDetalles;
        public Venta() { }
        public Venta (int cod) { ID = cod; }
        public Venta (int cod,DateTime horaV, DateTime fechaV, int can, Articulo art)
        {
            ID = cod;
            horadeventa = horaV;
            fechaventa = fechaV;
            cantidad = can;
            articulovendido = art;
        }
    }
}
