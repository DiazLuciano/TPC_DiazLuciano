using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Sucursal
    {
        public int ID { get; set; }
        public string direccion { get; set; }
        public List<Proveedor> proveedores = new List<Proveedor>();

    }
}
