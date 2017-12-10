using GlobonsTestASPNET.Controllers;
using GlobonsTestASPNET.Models.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobonsTestASPNET.Servicios
{
    public class DireccionServicio : ControllerBase
    {

        public bool AgregarDireccion(Direccion direccion)
        {
            return RepositorioManager.Direcciones.AgregarDireccion(direccion);
        }

        public List<Direccion> ObtenerListaDeDirecciones()
        {
            return RepositorioManager.Direcciones.ObtenerListaDeDirecciones();
        }

        public Direccion ObtenerDireccionPorId(int idDireccion)
        {
            return RepositorioManager.Direcciones.ObtenerDireccionPorId(idDireccion);
        }

        public bool EditarDireccionPorId(Direccion direccion)
        {
            return RepositorioManager.Direcciones.EditarDireccionPorId(direccion);
        }

    }
}