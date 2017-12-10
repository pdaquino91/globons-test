using GlobonsTestASPNETCore.Models.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobonsTestASPNET.Repositorios
{
    public class PersonaRepositorio : RepositorioBase
    {

        public PersonaRepositorio(GlobonsTestModel ctx) : base(ctx)
        {

        }


        internal bool AgregarPersona(Persona persona)
        {
            try
            {
                MiContexto.Personas.Add(persona);
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
            
            MiContexto.Direcciones.ToList();
            return MiContexto.Personas.ToList();
        }

        internal bool EditarPersonaPorId(Persona persona)
        {
            try
            {
                MiContexto.Personas.FirstOrDefault(e => e.idPersona == persona.idPersona).nombre = persona.nombre;
                MiContexto.Personas.FirstOrDefault(e => e.idPersona == persona.idPersona).apellido = persona.nombre;
                MiContexto.Personas.FirstOrDefault(e => e.idPersona == persona.idPersona).fechaNacimiento = persona.fechaNacimiento;
                MiContexto.Personas.FirstOrDefault(e => e.idPersona == persona.idPersona).numeroDocumento = persona.numeroDocumento;
                MiContexto.Personas.FirstOrDefault(e => e.idPersona == persona.idPersona).direccion = persona.direccion;
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
                return MiContexto.Personas.FirstOrDefault(e => e.idPersona == idPersona);
        }

        internal bool EliminarPersonaPorId(int idPersona)
        {
            try
            {
                MiContexto.Personas.Remove(MiContexto.Personas.FirstOrDefault(e => e.idPersona == idPersona));
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
                return MiContexto.Personas.Any(e => e.numeroDocumento == dni);
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
                return MiContexto.Personas.Any(e => e.numeroDocumento == dni && e.idPersona != idPersona);
            }
            catch (Exception e)
            {
                return false;
            }

        }


    }
}