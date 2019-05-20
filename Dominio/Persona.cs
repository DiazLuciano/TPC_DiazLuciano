using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona
    {
        public int ID { get; set; }
        public int DNI { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int Edad { get; set; }
        public DateTime fnac { get; set; }
        public string Genero { get; set; }
        public int CUIL { get; set; }
        public int CUIT { get; set; }
        public CuentaBancaria cuentabancaria { get; set; }
        public Direccion direccion { get; set; }
        public Usuario usuario { get; set; }
        public string tipo { get; set; }
        public string razonsocial { get; set; }
        public List<Telefono> telefonos = new List<Telefono>();
        public List<string> emails = new List<string>();

    }
}
