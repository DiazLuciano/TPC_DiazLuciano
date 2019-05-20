using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Localidad
    {
        public Int32 ID { get; set; }
        public Int32 CP { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
        public string nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

    }
}
