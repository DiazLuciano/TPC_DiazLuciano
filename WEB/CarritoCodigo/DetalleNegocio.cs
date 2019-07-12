using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Negocio;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WEB.CarritoCodigo
{
    public class DetalleNegocio
    {
        private DataTable registro;
        
        public DetalleNegocio()
        {

        }
        public DetalleNegocio(DataTable carrito)
        {
            this.registro = carrito;
            

        }
        //retornar o enviar
        public DataTable getRegistro
        {
            get { return registro; }
        }

        //agregar un producto al carrito y retorna la confirmacion del proceso
        public String agregar (long id, string nom, decimal pre, int can)
        {
            string msg = "";
            //buscar registro por su id
            DataRow fila = registro.Rows.Find(id);
            //si lo encuentro
            if(fila != null)
            {
                 msg = "Ya existe en el carrito";
            }
            else
            {
                fila = registro.NewRow(); //nueva fila
                //agregamos
                fila[0] = id;
                fila[1] = nom;
                fila[2] = pre;
                fila[3] = can;
                //agregamos fila a registro
                registro.Rows.Add(fila);
                msg = "Agregado al carrito";
            }

            return msg;
        }

        //retorna el total del pedido
        public decimal totalizar()
        {
            decimal t = 0;
            try
            {
                if (registro.Rows.Count > 0)
                {
                    t = (decimal)registro.Compute("sum(total)", "");
                }
            }
            catch
            {
                MessageBox.Show("No hay productos", MessageBoxButtons.OK.ToString());
            }
            
            return t;
        }

        //metodo autogenerar
        public int autogenerar()
        {
            AccesoDatos AD = new AccesoDatos();
            AD.setearConsulta("select count (*) from pedidos");
            AD.abrirConexion();
            AD.ejecutarAccion();
            int i = AD.ejecutarAccionReturn()+1;
            AD.cerrarConexion();
            return (i);
        }

        //metodo que registra pedido y su detalle
        public string Grabar(Pedido ped)
        {
            
            SqlConnection cn = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog = DIAZ_DB; Integrated Security = True");
            string msg = "";
            int Idped = autogenerar();
            cn.Open();
            
            SqlTransaction tr = cn.BeginTransaction(IsolationLevel.Serializable);
            //Comando que ejecuta insert en la tabla Pedidos
            SqlCommand cmd = new SqlCommand("insert into Pedidos values (@n,@c,@f,@m)", cn,tr);
            cmd.Parameters.Add("@n", SqlDbType.Int).Value = Idped;
            cmd.Parameters.Add("@f", SqlDbType.DateTime).Value = ped.Fpedido;
            cmd.Parameters.Add("@c", SqlDbType.BigInt).Value = ped.DNI;
            cmd.Parameters.Add("@m", SqlDbType.Decimal).Value = ped.Monto;

            try
            {
                cmd.ExecuteNonQuery();
                //grabardetalle
                foreach(DataRow fila in registro.Rows)
                {
                    //comando que hace el insert a la tabla pedidos
                    SqlCommand cmd1 = new SqlCommand("insert into PedidosDetalle values (@np,@idpro,@pre,@can)",cn,tr);
                    cmd1.Parameters.Add("@np", SqlDbType.Int).Value = Idped;
                    cmd1.Parameters.Add("@idpro", SqlDbType.BigInt).Value = fila[0];
                    cmd1.Parameters.Add("@pre", SqlDbType.Decimal).Value = fila[2];
                    cmd1.Parameters.Add("@can", SqlDbType.Int).Value = fila[3];
                    cmd1.ExecuteNonQuery(); //ejecuto
                }
                tr.Commit(); //actualiza base
                msg = "Pedido Agregado, Gracias por su Compra";

            }
            catch (Exception ex)
            {
                msg = ex.Message;
                //deshacemos la operacion
                tr.Rollback();
                
            }
            finally
            {
                cn.Close();
            }
            return msg;
        }

    }
}