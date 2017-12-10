using GlobonsTestASPNET.Models.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobonsTestASPNET.Repositorios
{
    public class PersonaRepositorio : RepositorioBase
    {

        public PersonaRepositorio(GlobonsTestEntities ctx) : base(ctx)
        {

        }


        internal bool AgregarPersona(Persona persona)
        {
            try
            {
                MiContexto.Persona.Add(persona);
                MiContexto.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        internal List<Persona> ObtenerListaDePersonas()
        {
            
            MiContexto.Direccion.ToList();
            return MiContexto.Persona.ToList();
        }

        internal bool EditarPersonaPorId(Persona persona)
        {
            try
            {
                MiContexto.Persona.FirstOrDefault(e => e.idPersona == persona.idPersona).nombre = persona.nombre;
                MiContexto.Persona.FirstOrDefault(e => e.idPersona == persona.idPersona).apellido = persona.nombre;
                MiContexto.Persona.FirstOrDefault(e => e.idPersona == persona.idPersona).fechaNacimiento = persona.fechaNacimiento;
                MiContexto.Persona.FirstOrDefault(e => e.idPersona == persona.idPersona).numeroDocumento = persona.numeroDocumento;
                MiContexto.Persona.FirstOrDefault(e => e.idPersona == persona.idPersona).direccion = persona.direccion;
                MiContexto.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                string mensajeError = e.Message;
                return false;
            }

        }


        internal Persona ObtenerPersonaPorId(int idPersona)
        {
                return MiContexto.Persona.FirstOrDefault(e => e.idPersona == idPersona);
        }

        internal bool EliminarPersonaPorId(int idPersona)
        {
            try
            {
                MiContexto.Persona.Remove(MiContexto.Persona.FirstOrDefault(e => e.idPersona == idPersona));
                MiContexto.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        internal bool ExisteDni(int dni)
        {
            try
            {
                return MiContexto.Persona.Any(e => e.numeroDocumento == dni);
            }
            catch (Exception e)
            {
                return false;
            }

        }


        internal bool ExisteDni(int dni, int idPersona)
        {
            try
            {
                return MiContexto.Persona.Any(e => e.numeroDocumento == dni && e.idPersona != idPersona);
            }
            catch (Exception e)
            {
                return false;
            }

        }


    }
}