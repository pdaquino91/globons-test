using GlobonsTestASPNET.Controllers;
using GlobonsTestASPNET.Models.BD;
using GlobonsTestASPNET.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobonsTestASPNET.Servicios
{
    public class PersonaServicio: ControllerBase
    {
        public bool AgregarPersona(Persona persona)
        {
            return RepositorioManager.Personas.AgregarPersona(persona);
        }

        public List<Persona> ObtenerListaDePersonas()
        {
            return RepositorioManager.Personas.ObtenerListaDePersonas();
        }

        public bool EditarPersonaPorId(Persona persona)
        {
           return RepositorioManager.Personas.EditarPersonaPorId(persona);
        }

        public Persona ObtenerPersonaPorId(int idPersona)
        {
            return RepositorioManager.Personas.ObtenerPersonaPorId(idPersona);
        }

        public bool EliminarPersonaPorId(int idPersona)
        {
            return RepositorioManager.Personas.EliminarPersonaPorId(idPersona);
        }

        public bool ExisteDni(int dni)
        {
            return RepositorioManager.Personas.ExisteDni(dni);
        }

        public bool ExisteDni(int dni, int idPersona)
        {
            return RepositorioManager.Personas.ExisteDni(dni, idPersona);
        }

    }
}