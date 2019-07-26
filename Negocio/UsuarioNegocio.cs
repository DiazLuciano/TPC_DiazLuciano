using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;

namespace Negocio
{
    public class UsuarioNegocio
    {
        private Usuario us;
        public void setusuario(Usuario usuario)
        {
            this.us = usuario;

        }

        public long buscarUser(string user)
        {
            AccesoDatos AD = new AccesoDatos();
            AD.setearConsulta("select *from usuarios where nombre like '"+ user + "'");
            AD.abrirConexion();
            AD.ejecutarConsulta();
            long dni= 0;
            if(AD.Lector.Read())
            {
                dni = (long)AD.Lector["DNI"];
            }
            return (dni);
        }
        public static String Codigo = "";
        public bool ValidarUsuario(Usuario usuario)
        {
                AccesoDatos conexion;
                try
                {
                    conexion = new AccesoDatos();
                    conexion.setearConsulta("select ID, Nombre, Contraseña,Tipo from USUARIOS Where Nombre=@usuario and Contraseña=@contraseña");
                    conexion.Comando.Parameters.Clear();
                    conexion.Comando.Parameters.AddWithValue("@usuario", usuario.nombre);
                    conexion.Comando.Parameters.AddWithValue("@contraseña", usuario.contraseña);
                    conexion.abrirConexion();
                    conexion.ejecutarConsulta();
                    if (conexion.Lector.Read())
                    {
                        
                        usuario.ID = (long)conexion.Lector["ID"];
                        usuario.nombre = (string)conexion.Lector["Nombre"];
                        usuario.contraseña = (string)conexion.Lector["Contraseña"];
                        usuario.Tipo = (string)conexion.Lector["Tipo"];
                        Codigo = Convert.ToString(usuario.ID);
                        conexion.cerrarConexion();

                    return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
           
            
        }

        public bool ValidarExisteUser(string nom)
        {
            string cad="";
                AccesoDatos AD = new AccesoDatos();
                AD.setearConsulta("select nombre from usuarios where nombre = '" + nom.Trim()+ "'");
                AD.abrirConexion();
                AD.ejecutarConsulta();
     
            if(AD.Lector.Read())
            {
                if (!Convert.IsDBNull(AD.Lector["nombre"].ToString()))
                { cad = (string)AD.Lector["Nombre"]; }
            }
            AD.cerrarConexion();
   
            if (cad == "") { return true; }
            else { return false; }

        }
        public void AgregarUs(Usuario us)
        {
            AccesoDatos AD = new AccesoDatos();
            AD.setearConsulta("Insert into Usuarios (DNI,Nombre,Contraseña,Tipo,Estado) values (" + us.DNI + ",'" + us.nombre + "','" + us.contraseña + "','Usuario',1)");
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
