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
            AD.setearConsulta("Exec SP_InsertarArticulo '" + art.Descripcion + "','" + art.Marca + "'," + art.Preciocompra + "," + art.Precioventa + ",'" + art.tipoarticulo + "'");
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

        public void ModificarArticulo (Articulo art)
        {
            AccesoDatos AN = new AccesoDatos();
            try
            {
                AN.setearConsulta("Exec SP_ModificarArticulo "+ art.ID+",'" + art.Descripcion + "', '" + art.Marca + "','" + art.tipoarticulo + "'," + art.Preciocompra + "," + art.Precioventa + "");
                AN.abrirConexion();
                AN.ejecutarAccion();
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                AN.cerrarConexion();
            }
        }

        public void eliminarLogico(Articulo art)
        {

            AccesoDatos AD = new AccesoDatos();
            try
            {

                AD.setearConsulta("Update Articulos Set Estado = 0 Where ID = " + art.ID);
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

        public void eliminarFisico(Articulo art)
        {

            AccesoDatos AD = new AccesoDatos();
            try
            {

                AD.setearConsulta("Delete from articulos Where ID = " + art.ID);
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
        public IList<Articulo> BuscarPro(string clave)
        {

            IList<Articulo> lista = new List<Articulo>();
            ArticuloNegocio AN = new ArticuloNegocio();
            String consulta = "Select * From articulos  Where ";
            AccesoDatos AD = new AccesoDatos();

            try
            {
               
                consulta = consulta + "id " + " Like '%" + clave + "%'";
                AD.setearConsulta(consulta);
                AD.abrirConexion();
                AD.ejecutarConsulta();

                while (AD.Lector.Read())
                {
                    Articulo art = new Articulo();
                    art.ID = (long)AD.Lector["ID"];
                    art.Descripcion = (string)AD.Lector["descripcion"];
                    art.Marca = (string)AD.Lector["marca"];
                    art.Preciocompra = (decimal)AD.Lector["preciocompra"];
                    art.Precioventa = (decimal)AD.Lector["precioventa"];
                    art.tipoarticulo = (string)AD.Lector["tipoarticulo"];
                    art.Estado = (bool)AD.Lector["Estado"];
                    lista.Add(art);
                }
                return lista;

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
