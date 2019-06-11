using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data;
using System.Data.SqlClient;


namespace Negocio
{
    
    public class TelefonoNegocio
    {
        public IList<Telefono> traerTelefonos (long idCli)
        {
            AccesoDatos AD = new AccesoDatos();
            IList<Telefono> lista = new List<Telefono>();
            
            try
            {
                AD.setearConsulta("exec SP_TraerTelefonos "+ idCli);
                AD.abrirConexion();
                AD.ejecutarConsulta();
                while(AD.Lector.Read())
                {
                    Telefono tel = new Telefono();
                    tel.ID = (long)AD.Lector["ID"];
                    tel.IDCliente = (long)AD.Lector["IDCliente"];
                    tel.telefono = (string)AD.Lector["Telefono"];
                    tel.tipotelefono = (string)AD.Lector["Tipo"];
                    lista.Add(tel);
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                AD.cerrarConexion();
            }
        }

        public void eliminarFisico(Telefono tel)
        {

            AccesoDatos AD = new AccesoDatos();
            try
            {
                AD.setearConsulta("Delete From Telefonos Where ID = " + tel.ID);
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

        //método que agrega una lista de telefonos de un contacto
        public void agregarListaTelefonos(long p, IList<Telefono> iList)
        {
            //recorre la lista con el foreach
            foreach (var telNuevo in iList)
            {
                //llama al metodo agregar en cada vuelta
                //agregar(telNuevo, p);
            }
        }

        //el metodo agregar lo llamo desde el que agrega una lista de telefonos o bien lo podría usar para agregar un telefono solo.
        public void agregar(Telefono telNuevo,long id)
        {
            AccesoDatos AD = new AccesoDatos();
            //DataAccessLayer conexion = new DataAccessLayer();
            string consulta = "Exec SP_AgregarTelefono " + id + ", " + telNuevo.telefono + ", ";
            try
            {

                //seteo insert y ejecuto
                if (telNuevo.tipotelefono.ToString().Trim() == "Casa")
                {
                    consulta = consulta + "Casa";
                }
                else
                {
                    if (telNuevo.tipotelefono.ToString().Trim() == "Celular")
                    {
                        consulta = consulta + "Celular";
                    }
                    else
                    {
                        if (telNuevo.tipotelefono.ToString().Trim() == "Trabajo")
                        {
                            consulta = consulta + "Trabajo";
                        }
                    }
                }
                AD.setearConsulta(consulta);
                AD.abrirConexion();
                AD.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
