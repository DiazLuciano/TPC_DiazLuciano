using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
     
        public long ID { get; set; }
        public string nombre { get; set; }
        public string contraseña { get; set; }
        public string Tipo { get; set; }
        public Boolean Estado { get; set; }


    }
}
