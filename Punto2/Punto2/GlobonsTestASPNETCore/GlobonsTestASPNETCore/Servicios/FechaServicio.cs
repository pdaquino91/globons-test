using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobonsTestASPNET.Servicios
{
    public class FechaServicio
    {
       public bool EsPosteriorAFechaActual(System.DateTime? fecha)
        {
            if (fecha > System.DateTime.Now)
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