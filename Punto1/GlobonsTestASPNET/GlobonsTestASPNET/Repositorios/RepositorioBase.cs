using GlobonsTestASPNET.Models.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobonsTestASPNET.Repositorios
{
    public class RepositorioBase
    {

        protected GlobonsTestEntities MiContexto { get; set; }


        public RepositorioBase(GlobonsTestEntities ctx)
        {

            this.MiContexto = ctx;
        }

    }
}