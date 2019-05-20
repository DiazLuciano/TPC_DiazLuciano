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
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader Lector;
            List<Articulo> listado = new List<Articulo>();
            Articulo art = new Articulo();

            try
            {
                conexion.ConnectionString = AccesoDatos.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //accesoDatos.setearConsulta( 
                comando.CommandText = ("select * From Articulos");
                comando.Connection = conexion;
                conexion.Open();
                Lector = comando.ExecuteReader();
                //accesoDatos.abrirConexion();
                // accesoDatos.ejecutarConsulta();
                while (Lector.Read())
                {
                    art = new Articulo();
                    art.ID = (int)Lector["ID"];
                    /*art.marca = (int)Lector["DNI"];
                    art.tipoarticulo = Lector["Nombre"].ToString();
                    art.precioventa = Lector["Apellido"].ToString();*/
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
                conexion.Close();
                //accesoDatos.cerrarConexion();
            }
        }
    }
}
