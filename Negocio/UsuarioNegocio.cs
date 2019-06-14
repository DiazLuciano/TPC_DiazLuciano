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
                    conexion.setearConsulta("select ID, Nombre, Contraseña from USUARIOS Where Nombre=@usuario and Contraseña=@contraseña");
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
    }
}
