using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Vendedor : Persona
    {
        public int ID_vendedor { get; set; }
        public List<Venta> ventas = new List<Venta>();
    }
}
