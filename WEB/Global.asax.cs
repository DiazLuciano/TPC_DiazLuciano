using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Dominio;
using WEB.CarritoCodigo;
using System.Data;

namespace WEB
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta al iniciar la aplicación
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        void Session_Start(object sender, EventArgs e)
        {
            //CODIGO QUE SE EJECUTA CUANDO SE INICIA UNA NUEVA SESION
            //INICIALIZAR SESION 
            Detalle tabla = new Detalle();
            Session["carrito"] = tabla.getTabla;
        }

        void Session_End(object sender, EventArgs e)
        {
            Session.Remove("carrito");
        }
    }
}