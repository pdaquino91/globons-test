using GlobonsTestASPNETCore.Models.BD;
using Microsoft.EntityFrameworkCore;
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
            DbContextOptions<GlobonsTestModel> option = new DbContextOptions<GlobonsTestModel>();


            var ctx = new GlobonsTestModel(option);
            Personas = new PersonaRepositorio(ctx);
            Direcciones = new DireccionRepositorio(ctx);

        }

    }
}