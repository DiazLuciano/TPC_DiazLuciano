using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB
{
    public static class Sesion
    {
        public static bool situacion = false;
        public static void cambiarEstado(bool estado)
        {
            situacion = estado;
        }
    }
}