using GlobonsTestASPNET.Repositorios;
using GlobonsTestASPNET.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GlobonsTestASPNET.Controllers
{
    public class ControllerBase : Controller
    {
        //
        // 
        public RepositorioManager RepositorioManager { get; set; }
        //public ServicioManager ServicioManager { get; set; }

        public ControllerBase()
        {
            //Instanciamos el repositorioManager para que el mismo sea heredado por los restantes controladores
            RepositorioManager = new RepositorioManager();
            //ServicioManager = new ServicioManager();
        }

    }
}