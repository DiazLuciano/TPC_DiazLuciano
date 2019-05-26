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
        public string genero { get; set; }
        public DateTime fnac { get; set; }
        public int edad { get; set; }
        public Int64 CUILCUIT { get; set; }
        public string direccion { get; set; }
        public Localidad localidad { get; set; }
        public CuentaBancaria cuentabancaria { get; set; }
        
        public Usuario usuario { get; set; }
        public string tipo { get; set; }
        public string razonsocial { get; set; }
        public IList<Telefono> telefonos { get; set; }
        public string email1 { get; set; }
        public string email2 { get; set; }
        public Boolean Estado { get; set; }

    }
}
