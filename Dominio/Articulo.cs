using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public long ID { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public decimal Preciocompra { get; set; }
        public decimal Precioventa { get; set; }
        public string tipoarticulo { get; set; }
        public int Stock { get; set; }
        public string Imagen { get; set; }
        public Boolean Estado { get; set; }

    }
}
