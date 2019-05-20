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
    }
}
