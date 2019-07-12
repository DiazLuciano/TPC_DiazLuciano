using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class FacturaNegocio
    {
       
        public List<Factura> ListarFacturas(long dni)
        {
            AccesoDatos AD = new AccesoDatos();
            List<Factura> Lista = new List<Factura>();
            Factura fac;

            try
            {
                AD.setearConsulta("Exec SP_DatosFacturaXDni " + dni);
                AD.abrirConexion();
                AD.ejecutarConsulta();

                while (AD.Lector.Read())
                {
                    fac = new Factura();
                    fac.NumFac = (long)AD.Lector["numfac"];
                    fac.Fecha_fac = (DateTime)AD.Lector["fecha_fac"];
                    fac.dniCliente = (long)AD.Lector["IDcliente"];
                    fac.precioV = (decimal)AD.Lector["PrecioV"];
                    fac.cantV = (int)AD.Lector["cantVend"];
                    fac.nombreC = (string)AD.Lector["Nombre"];
                    fac.descripcionP = (string)AD.Lector["Descripcion"];
                    fac.Importe = (decimal)AD.Lector["Importe"];
                    Lista.Add(fac);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                AD.cerrarConexion();

            }

        }

        public int MyProperty { get; set; }
    }
}
