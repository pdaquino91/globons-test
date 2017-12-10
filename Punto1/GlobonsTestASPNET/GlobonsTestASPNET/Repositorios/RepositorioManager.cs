using GlobonsTestASPNET.Models.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobonsTestASPNET.Repositorios
{
    public class RepositorioManager
    {

        public PersonaRepositorio Personas { get; set; }
        public DireccionRepositorio Direcciones { get; set; }



        public RepositorioManager()
        {
            var ctx = new GlobonsTestEntities();
            Personas = new PersonaRepositorio(ctx);
            Direcciones = new DireccionRepositorio(ctx);

        }

    }
}