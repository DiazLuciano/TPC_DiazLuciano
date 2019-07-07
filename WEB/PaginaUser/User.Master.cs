﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace WEB
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

     

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.Remove("usuario");
            Response.Redirect("~/Login.aspx");
        }
    }
}