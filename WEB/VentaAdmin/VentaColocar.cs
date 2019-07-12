using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WEB.VentaAdmin
{
    public class VentaColocar
    {
        public long Idpro { get; set; }
        public string desc { get; set; }
        public decimal precio { get; set; }
        public int cant { get; set; }
        public decimal importe { get; set; }

    }

}