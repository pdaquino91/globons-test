using GlobonsTestASPNET.Models.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GlobonsTestASPNET.Controllers
{
    public class PersonaController : ControllerBase
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AgregarPersona()
        {
            ViewBag.ListaDirecciones = Servicios.ServicioManager.Direcciones.ObtenerListaDeDirecciones();
            return View();
        }

        [HttpPost]
        public ActionResult AgregarPersona(Persona persona)
        {

            ViewBag.ListaDirecciones = Servicios.ServicioManager.Direcciones.ObtenerListaDeDirecciones();

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (Servicios.ServicioManager.Fechas.EsPosteriorAFechaActual(persona.fechaNacimiento))
            {
                ViewBag.ErrorFechaNacimiento = "La fecha debe ser anterior a la fecha actual.";
                return View();
            }

            if (Servicios.ServicioManager.Personas.ExisteDni(persona.numeroDocumento))
            {
                ViewBag.ErrorDni = "El DNI " + persona.numeroDocumento + " ya se encuentra registrado";
                return View();
            }

            if (!Servicios.ServicioManager.Personas.AgregarPersona(persona))
            {
                ViewBag.MensajeError = "No se ha podido registrar la persona. Ha ocurrido un error interno.";
                return View();
            }

            ModelState.Clear();

            ViewBag.Mensaje = "La persona ha sido agregada correctamente.";
            return View();
        }

        public ActionResult EditarPersona(int id)
        {
            ViewBag.ListaDirecciones = Servicios.ServicioManager.Direcciones.ObtenerListaDeDirecciones();

            Persona persona = Servicios.ServicioManager.Personas.ObtenerPersonaPorId(id);
            return View(persona);
        }

        [HttpPost]
        public ActionResult EditarPersona(Persona persona)
        {
            ViewBag.ListaDirecciones = Servicios.ServicioManager.Direcciones.ObtenerListaDeDirecciones();

            if (!ModelState.IsValid)
            {
                return View(persona);
            }

            if (Servicios.ServicioManager.Personas.ExisteDni(persona.numeroDocumento, persona.idPersona))
            {
                ViewBag.ErrorDni = "El DNI " + persona.numeroDocumento + " ya se encuentra registrado";
                return View(persona);
            }

            if (!Servicios.ServicioManager.Personas.EditarPersonaPorId(persona))
            {
                ViewBag.MensajeError = "No se ha podido editar los datos de la persona. Ha ocurrido un error interno.";
                return View(persona);
            }

            ViewBag.Mensaje = "La persona ha sido editada correctamente.";
            return View(persona);
        }

        public ActionResult VerPersonas()
        {
            List<Persona> personas = Servicios.ServicioManager.Personas.ObtenerListaDePersonas();
            return View(personas);
        }

        public ActionResult EliminarPersona(int id)
        {
            Servicios.ServicioManager.Personas.EliminarPersonaPorId(id);
            return RedirectToAction("VerPersonas", "Persona");
        }


    }
}