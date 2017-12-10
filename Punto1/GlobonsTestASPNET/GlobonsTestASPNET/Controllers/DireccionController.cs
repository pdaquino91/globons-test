using GlobonsTestASPNET.Models.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GlobonsTestASPNET.Controllers
{
    public class DireccionController : ControllerBase
    {
        // GET: Direccion
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AgregarDireccion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AgregarDireccion(Direccion direccion)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (Servicios.ServicioManager.Direcciones.AgregarDireccion(direccion)==false)
            {
                ViewBag.MensajeError = "No se ha podida agregar la direccion.";
            }

            ModelState.Clear();

            ViewBag.Mensaje = "La direccion ha sido agregada correctamente.";
            return View();
        }

        public ActionResult VerDirecciones()
        {
            List<Direccion> direcciones = Servicios.ServicioManager.Direcciones.ObtenerListaDeDirecciones();
            return View(direcciones);
        }

        public ActionResult EditarDireccion(int id)
        {
            Direccion direccion = Servicios.ServicioManager.Direcciones.ObtenerDireccionPorId(id);
            return View(direccion);
        }

        [HttpPost]
        public ActionResult EditarDireccion(Direccion nuevadireccion)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Servicios.ServicioManager.Direcciones.EditarDireccionPorId(nuevadireccion);
            Direccion direccion = Servicios.ServicioManager.Direcciones.ObtenerDireccionPorId(nuevadireccion.idDireccion);
            ViewBag.Mensaje = "La direccion se ha actualizado correctamente";
            return View(direccion);
        }

    }
}