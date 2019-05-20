using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class UsuarioNegocio
    {
        private Usuario us;
        public void setusuario(Usuario usuario)
        {
            this.us = usuario;
        }

        public bool ValidarUsuario(Usuario usuario)
        {

            AccesoDatos conexion;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("select ID, Nombre, Contraseña from USUARIOS Where Nombre=@usuario and Contraseña=@contraseña");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@usuario", usuario.nombre);
                conexion.Comando.Parameters.AddWithValue("@contraseña", usuario.contraseña );
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                if (conexion.Lector.Read())
                {
                    usuario.ID = (int)conexion.Lector["ID"];
                    usuario.nombre = (string)conexion.Lector["Nombre"];
                    usuario.contraseña = (string)conexion.Lector["Contraseña"];
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
