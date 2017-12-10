using GlobonsTestASPNETCore.Models.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobonsTestASPNET.Repositorios
{
    public class RepositorioBase
    {

        protected GlobonsTestModel MiContexto { get; set; }


        public RepositorioBase(GlobonsTestModel ctx)
        {

            this.MiContexto = ctx;
        }

    }
}