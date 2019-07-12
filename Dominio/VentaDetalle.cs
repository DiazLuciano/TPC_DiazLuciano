using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class VentaDetalle
    {
        private int ID;
        private Articulo articulo;
        private int cantUnidades;
        private decimal porcDescuento;
        private decimal precioC;
        private decimal precioV;
        private int Idventa;

        public int ID1 { get => ID; set => ID = value; }
        public Articulo Articulo { get => articulo; set => articulo = value; }
        public int CantUnidades { get => cantUnidades; set => cantUnidades = value; }
        public decimal PorcDescuento { get => porcDescuento; set => porcDescuento = value; }
        public decimal PrecioC { get => precioC; set => precioC = value; }
        public decimal PrecioV { get => precioV; set => precioV = value; }
        public int Idventa1 { get => Idventa; set => Idventa = value; }

        public VentaDetalle ()
        {
            articulo = new Articulo();
        }
    }
}
