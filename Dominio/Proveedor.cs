using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Proveedor : Persona
    {
        public int ID_proveedor { get; set; }
        public List<Articulo> articulos = new List<Articulo>();

    }
}
