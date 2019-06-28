using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dominio;
using System.Windows.Forms;


namespace Negocio
{
    public class AccesoDatos
    {

            public static string cadenaConexion = "Data Source =.\\SQLEXPRESS;Initial Catalog = DIAZ_DB; Integrated Security = True";
            private SqlCommand comando;
            private SqlConnection conexion;
            private SqlDataReader lector;

            public SqlDataReader Lector
            {
                get { return lector; }
            }
            public SqlCommand Comando
            {
                get { return comando; }
            }

            public AccesoDatos()
            {
                conexion = new SqlConnection(cadenaConexion);
            }

            //setear consulta embebida.
            public void setearConsulta(string consulta)
            {
                comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = consulta;
            }

        //esto para luego...
            public void setearSP(string sp)
            {
                 comando = new SqlCommand();
                 comando.CommandType = System.Data.CommandType.StoredProcedure;
                 comando.CommandText = sp;
            }

            public void abrirConexion()
            {
                try
                {
                    conexion.Open();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void cerrarConexion()
            {
                try
                {
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void ejecutarAccion()
            {
                try
                {
                    comando.Connection = conexion;
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            public int ejecutarAccionReturn()
            {
                try
                {
                    comando.Connection = conexion;
                    return (int)comando.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        public DataSet dataSet(string cmd)
        {
            AccesoDatos ad = new AccesoDatos();
            ad.abrirConexion();

            DataSet ds = new DataSet();
            SqlDataAdapter dp = new SqlDataAdapter(cmd, cadenaConexion);

            dp.Fill(ds);
            ad.cerrarConexion();

            return ds;

        }

        public void ejecutarConsulta()
        {
            try
            {
                comando.Connection = conexion;
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object ejecutarScalar()
        {
            return this.Comando.ExecuteScalar();
        }

        public static Boolean ValidarFormulario (Control objeto,ErrorProvider errorProvider)
        {
            Boolean HayErrores = false;
            //hago un foreach para que vaya revisando los objetos uno por uno
            foreach (Control item in objeto.Controls)
            {
                //ahora si el objeto es un error de tipo txtbox, que es el control de usuario que creamos, nos diga lo sgte
                if (item is ErrorTxtBox)
                {
                    ErrorTxtBox obj = (ErrorTxtBox)item; //instanciamos el error txtbox

                    if (obj.Validar == true) //su propiedad de validar esta encendida o apagada, osea si el obj en su validar es true o false
                    {
                        if (string.IsNullOrEmpty(obj.Text.Trim())) // si la cadena esta vacia o nula del objeto, que me active en el errorprovider el mensaje sgte
                        {
                            errorProvider.SetError(obj, "No puede estar vacio");
                            HayErrores = true;

                        }
                    }

                    if(obj.SoloNumeros==true) // si su atributo esta encendido que haga lo sgte
                    {
                        int cont = 0, LetrasEncontradas = 0; //cada vez que encuentre una letra que me vaya incrementando
                        foreach (char letra in obj.Text.Trim())
                        {
                            if(char.IsLetter(obj.Text.Trim(),cont))
                            {
                                LetrasEncontradas++;
                            }
                            cont++;

                        }

                        if (LetrasEncontradas!=0)
                        {
                            HayErrores = true;
                            errorProvider.SetError(obj, "Solo Numeros");
                        }
                    }

                }
            }
            return HayErrores;
        }

       
    }
         
}
