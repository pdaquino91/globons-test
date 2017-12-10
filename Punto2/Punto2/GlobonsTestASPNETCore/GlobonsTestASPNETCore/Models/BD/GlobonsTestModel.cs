using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GlobonsTestASPNETCore.Models.BD
{
    public class GlobonsTestModel : DbContext
    {
        public GlobonsTestModel(DbContextOptions<GlobonsTestModel> options) : base(options)
        {
        }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>().ToTable("Persona");
            modelBuilder.Entity<Direccion>().ToTable("Direccion");
        }
    }
}

