using GlobonsTestASPNET.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobonsTestASPNET.Servicios
{
    public class ServicioManager
    {
        public static PersonaServicio Personas = new PersonaServicio();
        public static DireccionServicio Direcciones = new DireccionServicio();
        public static FechaServicio Fechas = new FechaServicio();
    }
}