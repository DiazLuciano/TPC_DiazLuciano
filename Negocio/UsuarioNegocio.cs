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

        public bool ValidarExisteUser(string nombre)
        {
            string existe="";
            AccesoDatos AD = new AccesoDatos();
            AD.setearConsulta("select nombre from usuarios where nombre = '" + nombre +"'");
            AD.abrirConexion();
            AD.ejecutarConsulta();
            AD.Lector.Read();
            if ((AD.Lector.IsDBNull(AD.Lector.GetOrdinal("Nombre"))))
            {
                existe = (string)AD.Lector["Nombre"];
            }
            
            
            if(string.IsNullOrEmpty(existe))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
