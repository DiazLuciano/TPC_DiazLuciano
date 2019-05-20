using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data;
using System.Data.SqlClient;
using Negocio;

namespace Negocio
{
    public class ClientesNegocio
    {

        ////Metodo que se conecta y trae los registros de la DB
        //public IList<Cliente> traerClientes()
        //{

        //   // TelefonoService serviceTel = new TelefonoService();
        //    IList<Cliente> lista = new List<Cliente>();
        //    //conection string >> es donde esta la DB
        //    SqlConnection conexion = new SqlConnection();
        //    conexion.ConnectionString = "Data Source=ABEL-PC\\SQLEXPRESS;Initial Catalog=AGENDA_DB;Integrated Security=True";
        //    //comando >> es la consulta que voy a enviar
        //    SqlCommand comando = new SqlCommand();
        //    comando.CommandType = System.Data.CommandType.Text;
        //    comando.CommandText = "Select Nombre, Apellido, Direccion, C.ID, Localidad, L.CP, L.ID, C.Altura, C.Edad, C.FechaNacimiento, C.Foto From CONTACTOS C inner join LOCALIDADES L On C.CP = L.CP Where C.Estado = 1";
        //    comando.Connection = conexion;
        //    //contenedor del resultado la consulta
        //    SqlDataReader lector;

        //    try
        //    {

        //        conexion.Open();
        //        lector = comando.ExecuteReader();

        //        while (lector.Read())
        //        {
        //            Contacto con = new Contacto();
        //            con.Nombre = lector.GetString(0);
        //            con.Apellido = lector.GetString(1);
        //            con.Direccion = lector.GetString(2);
        //            con.ContactoId = lector.GetInt32(3);
        //            con.Localidad = new Localidad() { Localid = lector.GetString(4), CP = lector.GetInt32(5), Id = lector.GetInt32(6) };
        //            con.Telefonos = serviceTel.traerTelefonosPorContacto(con.ContactoId);
        //            con.Altura = lector.GetDecimal(7);
        //            con.Edad = lector.GetInt16(8);

        //            //esto para validar si viene nulo de la base de datos...
        //            if (!(lector.IsDBNull(lector.GetOrdinal("fechaNacimiento"))))
        //            {
        //                con.FechaNacimiento = lector.GetDateTime(9);
        //            }
        //            if (!(lector.IsDBNull(lector.GetOrdinal("Foto"))))
        //            {
        //                con.Foto = lector.GetString(10);
        //            }



        //            lista.Add(con);
        //        }
        //        return lista;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        conexion.Close();
        //        conexion.Dispose();
        //        comando.Dispose();
        //    }

        //}

        public List<Cliente> ListarClientes()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader Lector;
            List<Cliente> listado = new List<Cliente>();           
            Cliente cli = new Cliente();

            try
            {
                conexion.ConnectionString = AccesoDatos.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //accesoDatos.setearConsulta( 
                comando.CommandText = ("select ID,DNI, Nombre, Apellido From Clientes");
                comando.Connection = conexion;
                conexion.Open();
                Lector = comando.ExecuteReader();
                //accesoDatos.abrirConexion();
                // accesoDatos.ejecutarConsulta();
                while (Lector.Read())
                {
                    cli = new Cliente();
                    cli.ID = (int)Lector["ID"];
                    cli.DNI = (int)Lector["DNI"];
                    cli.nombre = Lector["Nombre"].ToString();
                    cli.apellido = Lector["Apellido"].ToString();
                    listado.Add(cli);
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

        public void AgregarCliente(Cliente cli)
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = AccesoDatos.cadenaConexion;
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            comando.CommandText = "insert into Clientes (DNI,Nombre,Apellido) values ('" + cli.DNI + "','" + cli.nombre + "','" + cli.apellido + "')";

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
                comando.Dispose();
            }

        }

        public void ModificarCliente(Cliente cli)
        {
            DataAccessLayer dato = new DataAccessLayer();
            try
            {
                dato.setearComandoText("Update Clientes Set  DNI = '" + cli.DNI + "',Nombre = '" + cli.nombre + "', Apellido = '" + cli.apellido + "' Where ID = " + cli.ID);
                dato.abrirConexion();
                dato.ejecutarNonQuery();
                dato.cerrarConexion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarFisico(Cliente cli)
        {

            DataAccessLayer datos = new DataAccessLayer();

            try
            {
                datos.setearComandoText("Delete From Clientes Where ID = " + cli.ID);
                datos.abrirConexion();
                datos.ejecutarNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public void eliminarLogico(Cliente cli)
        {

            DataAccessLayer acceso = new DataAccessLayer();
            try
            {

                acceso.setearComandoText("Update Clientes  Where ID = " + cli.ID);//me falta poner despues de contactos set Estado=0
                acceso.abrirConexion();
                acceso.ejecutarNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                acceso.cerrarConexion();
            }
        }
    }
}
