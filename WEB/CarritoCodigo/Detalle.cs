using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;


namespace WEB.CarritoCodigo
{
    public class Detalle
    {
        private DataTable tabla;
        public Detalle()
        { 
            //inicializar tabla
            tabla = new DataTable();
            tabla.Columns.Add("ID", Type.GetType("System.Int64")); //damos un nombre y tipo de dato
            tabla.Columns.Add("Nombre", Type.GetType("System.String"));
            tabla.Columns.Add("Precio", Type.GetType("System.Decimal"));
            tabla.Columns.Add("Cantidad", Type.GetType("System.Int32"));
            tabla.Columns.Add("Total", Type.GetType("System.Decimal"), "precio * cantidad");
            tabla.PrimaryKey = new DataColumn[] { tabla.Columns[0] }; //definir clave
        }
        public DataTable getTabla
        {
            get { return tabla; }
        }
    }
   
}