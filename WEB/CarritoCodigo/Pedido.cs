using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Negocio;

namespace WEB.CarritoCodigo
{
    public class Pedido
    {
        public int Idped { get; set; }
        public long DNI { get; set; }
        public DateTime Fpedido { get; set; }
        public decimal Monto { get; set; }
        public Pedido() { }

        public DataTable pedidosXcliente(long dni)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_pedidoscliente", Convert.ToString(AccesoDatos.cadenaConexion));
            //definir que es un procedimiento
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            //definir parametro
            da.SelectCommand.Parameters.Add("@dni", SqlDbType.BigInt).Value = dni;
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
    }
}