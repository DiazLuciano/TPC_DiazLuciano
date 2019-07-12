using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona
    {
        public long DNI { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public char genero { get; set; }
        public DateTime fnac { get; set; }
        public DateTime fecha_alta { get; set; }
        public int edad { get; set; }
        public string Email { get; set; }
        public string direccion { get; set; }
        public int CP { get; set; }
        public string Localidad { get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
        public char tipo { get; set; }
        public long CUILCUIT { get; set; }
        public string razonsocial { get; set; }
        public Usuario usuario { get; set; }
        public IList<Telefono> telefonos { get; set; }
        public bool Estado { get; set; }



    }
}
