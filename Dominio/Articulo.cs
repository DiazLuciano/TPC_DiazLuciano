using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int ID { get; set; }
        public string marca { get; set; }
        public decimal preciocompra { get; set; }
        public decimal precioventa { get; set; }
        public decimal precioventamayorista { get; set; }
        public string tipoarticulo { get; set; }

    }
}
