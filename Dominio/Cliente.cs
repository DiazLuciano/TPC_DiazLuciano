using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente : Persona
    {
        public int ID_cliente { get; set; }
        public bool Estado { get; set; }
        public int CUIL { get; set; }
        public int CUIT { get; set; }
    }
}
