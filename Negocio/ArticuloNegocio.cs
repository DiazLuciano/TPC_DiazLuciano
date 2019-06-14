using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> ListarArticulos()
        {
            AccesoDatos AD = new AccesoDatos();
            List<Articulo> listado = new List<Articulo>();
            Articulo art;

            try
            {
                AD.setearConsulta("Select *from Articulos");
                AD.abrirConexion();
                AD.ejecutarConsulta();
              
                while (AD.Lector.Read())
                {
                    art = new Articulo();
                    art.ID = (long)AD.Lector["ID"];
                    art.Descripcion = (string)AD.Lector["Descripcion"];
                    art.Marca = (string)AD.Lector["Marca"];
                    art.tipoarticulo = (string)AD.Lector["TipoArticulo"];
                    art.Preciocompra = (decimal)AD.Lector["Preciocompra"];
                    art.Precioventa = (decimal)AD.Lector["Precioventa"];
                    art.Estado = (bool)AD.Lector["estado"];
                    listado.Add(art);
                }


                return listado;

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

        public void AgregarArticulo(Articulo art)
        {
            AccesoDatos AD = new AccesoDatos();
            AD.setearConsulta("Exec SP_InsertarArticulo" + art.Descripcion + ",'" + art.Marca + "'," + art.Preciocompra + "," + art.Precioventa + ",'" + art.tipoarticulo + "'");
            try
            {
                AD.abrirConexion();
                AD.ejecutarAccion();
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
    }
}
