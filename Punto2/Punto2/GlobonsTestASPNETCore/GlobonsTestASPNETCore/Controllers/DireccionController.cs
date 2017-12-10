using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GlobonsTestASPNETCore.Models;
using GlobonsTestASPNETCore.Models.BD;

namespace GlobonsTestASPNET.Controllers
{
    public class DireccionController : ControllerBase
    {
        // GET: Direccion
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AgregarDireccion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AgregarDireccion(Direccion direccion)
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

        public IActionResult VerDirecciones()
        {
            List<Direccion> direcciones = Servicios.ServicioManager.Direcciones.ObtenerListaDeDirecciones();
            return View(direcciones);
        }

        public IActionResult EditarDireccion(int id)
        {
            Direccion direccion = Servicios.ServicioManager.Direcciones.ObtenerDireccionPorId(id);
            return View(direccion);
        }

        [HttpPost]
        public IActionResult EditarDireccion(Direccion nuevadireccion)
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