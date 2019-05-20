using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Direccion
    {
        public int ID { get; set; }
        public char calle { get; set; }
        public int altura { get; set; }
        public int piso { get; set; }
        public float latitud { get; set; }
        public float longitud { get; set; }
        public Localidad localidad { get; set; }

        public override string ToString()
        {
            return calle + " " + altura.ToString() + ", " + piso.ToString() + ", " + localidad.nombre + "(" + localidad.CP.ToString() + ")";
        }
    }
}
