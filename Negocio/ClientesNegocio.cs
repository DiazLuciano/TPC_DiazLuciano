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
        public List<Cliente> ListarClientes()
        {            
            AccesoDatos AD = new AccesoDatos();
            List<Cliente> listado = new List<Cliente>();
            TelefonoNegocio telN = new TelefonoNegocio();

            try
            {
                AD.setearConsulta("Exec SP_VerClientes");
                AD.abrirConexion();
                AD.ejecutarConsulta();

                while (AD.Lector.Read())
                {
                    Cliente cli = new Cliente();
                    cli.IDCliente= (long)AD.Lector["ID"];
                    cli.DNI = (long)AD.Lector["DNI"];
                    cli.nombre = (string)AD.Lector["Nombre"];
                    cli.apellido = (string)AD.Lector["Apellido"];
                    cli.genero = Convert.ToChar(AD.Lector["Genero"]);
                    cli.fnac = (DateTime)AD.Lector["Fnac"];
                    cli.fecha_alta = (DateTime)AD.Lector["FechaAlta"];
                    cli.edad = (int)AD.Lector["Edad"];
                    cli.Email = (string)AD.Lector["Email"];
                    cli.direccion = (string)AD.Lector["Direccion"];
                    cli.CP = (int)AD.Lector["CP"];
                    cli.Localidad = (string)AD.Lector["Localidad"];
                    cli.Ciudad = (string)AD.Lector["Ciudad"];
                    cli.Provincia = (string)AD.Lector["Provincia"];
                    cli.tipo = Convert.ToChar(AD.Lector["Tipo"]);
                    if (!Convert.IsDBNull(AD.Lector["CUIL"]))
                        cli.CUIL = (long)AD.Lector["CUIL"];
                    //if (!(AD.Lector.IsDBNull(AD.Lector.GetOrdinal("fechaNacimiento"))))
                    //{
                    //    con.FechaNacimiento = lector.GetDateTime(9);
                    //}
                
                    cli.CUIT = (long)AD.Lector["CUIT"];
                    cli.razonsocial = (string)AD.Lector["RazonSocial"];
                    cli.telefonos = telN.traerTelefonos(cli.IDCliente);
                    //cli.localidad = new Localidad() { CP = (int)AD.Lector["CP"],Loc = (string)AD.Lector["NombreLoc"] };
                    //cli.localidad.CP = (int)AD.Lector["CP"];
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
                AD.cerrarConexion();
            }
        }

        public long BuscarId()
        {
            long id;
            AccesoDatos AD = new AccesoDatos();
            AD.setearConsulta("SELECT MAX(ID) FROM CLIENTES");
            AD.abrirConexion();
            AD.ejecutarConsulta();
            id = (long)AD.Lector["ID"];
            return id;
        }
        public void AgregarCliente(Cliente cli)
        {
            AccesoDatos AD = new AccesoDatos();
            TelefonoNegocio TN = new TelefonoNegocio();

            AD.setearConsulta("Exec SP_InsertarClientes " + cli.DNI + ",'" + cli.nombre + "','" + cli.apellido + "','" + cli.genero + "','" + cli.fnac + "'," + cli.edad + ",'" + cli.Email + "','" + cli.direccion + "'," + cli.CP + ",'" + cli.Localidad + "' ,'" + cli.Ciudad + "' ,'" + cli.Provincia + "' ,'" + cli.tipo + "' ," + cli.CUIL + "," +cli.CUIT + ",'" + cli.razonsocial + "'");

            //SqlConnection conexion = new SqlConnection();
            //conexion.ConnectionString = AccesoDatos.cadenaConexion;
            //SqlCommand comando = new SqlCommand();
            //comando.CommandType = System.Data.CommandType.Text;
            //comando.Connection = conexion;
            //comando.CommandText = "insert into Clientes (DNI,Nombre,Apellido) values ('" + cli.DNI + "','" + cli.nombre + "','" + cli.apellido + "')";

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

        public void ModificarCliente(Cliente cli)
        {
            DataAccessLayer dato = new DataAccessLayer();
            
            try
            {
                dato.setearComandoText("Update Clientes Set  DNI = " + cli.DNI + ",Nombre = '" + cli.nombre + "', Apellido = '" + cli.apellido + "',Genero ='" + cli.genero + "',Fnac='" + cli.fnac + "' ,Edad=" + cli.edad + ",Email='" + cli.Email + "',Direccion='" + cli.direccion + "',CP=" + cli.CP + ",Localidad='" + cli.Localidad + "' ,Ciudad='" + cli.Ciudad + "' ,Provincia='" + cli.Provincia + "' ,Tipo='" + cli.tipo + "' ,CUIL=" + cli.CUIL + ",CUIT=" +cli.CUIT + ",RazonSocial='" + cli.razonsocial + "' Where ID = " + cli.IDCliente);
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
            AccesoDatos AD = new AccesoDatos();
            try
            {
                AD.setearConsulta("Delete From Clientes Where ID = " + cli.IDCliente);
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

        public void eliminarLogico(Cliente cli)
        {

            DataAccessLayer acceso = new DataAccessLayer();
            try
            {

                acceso.setearComandoText("Update Clientes set Estado = 0 Where ID = " + cli.IDCliente);//me falta poner despues de contactos set Estado=0
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

        public IList<Cliente> Buscar(string campo , string clave)
        {

            IList<Cliente> lista = new List<Cliente>();
            TelefonoNegocio telN = new TelefonoNegocio();
            String consulta = "Select * From Clientes  Where Estado = 1 and ";
            AccesoDatos AD = new AccesoDatos();

            try
            {
                switch (campo)
                {
                    case "Nombre/Apellido":
                        consulta = consulta + "NOMBRE " + " Like '%" + clave + "%'" + "OR APELLIDO " + " LIKE '%" + clave + "%'";
                        break;
                    case "DNI":
                        consulta = consulta + campo + " Like '%" + clave + "%'";
                        break;
                }

                AD.setearConsulta(consulta);
                AD.abrirConexion();
                AD.ejecutarConsulta();

                while (AD.Lector.Read())
                {
                    Cliente cli = new Cliente();
                    cli.IDCliente = (long)AD.Lector["ID"];
                    cli.DNI = (long)AD.Lector["DNI"];
                    cli.nombre = (string)AD.Lector["Nombre"];
                    cli.apellido = (string)AD.Lector["Apellido"];
                    cli.genero = Convert.ToChar(AD.Lector["Genero"]);
                    cli.fnac = (DateTime)AD.Lector["Fnac"];
                    cli.fecha_alta = (DateTime)AD.Lector["FechaAlta"];
                    cli.edad = (int)AD.Lector["Edad"];
                    cli.Email = (string)AD.Lector["Email"];
                    cli.direccion = (string)AD.Lector["Direccion"];
                    cli.CP = (int)AD.Lector["CP"];
                    cli.Localidad = (string)AD.Lector["Localidad"];
                    cli.Ciudad = (string)AD.Lector["Ciudad"];
                    cli.Provincia = (string)AD.Lector["Provincia"];
                    cli.tipo = Convert.ToChar(AD.Lector["Tipo"]);
                    if (!Convert.IsDBNull(AD.Lector["CUIL"]))
                        cli.CUIL = (long)AD.Lector["CUIL"];
                    //if (!(AD.Lector.IsDBNull(AD.Lector.GetOrdinal("fechaNacimiento"))))
                    //{
                    //    con.FechaNacimiento = lector.GetDateTime(9);
                    //}

                    cli.CUIT = (long)AD.Lector["CUIT"];
                    cli.razonsocial = (string)AD.Lector["RazonSocial"];
                    cli.telefonos = telN.traerTelefonos(cli.IDCliente);


                    /* //esto para validar si viene nulo de la base de datos...
                     if (!(conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("fechaNacimiento"))))
                     {
                         cli.fnac = conexion.Lector.GetDateTime(9);
                     }*/


                    lista.Add(cli);
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
