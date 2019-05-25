using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Localidad
    {
        public int ID { get; set; }
        public int CP { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
        public string nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public override string ToString()
        {
            return CP.ToString() + " - " + nombre;
        }

    }
}
