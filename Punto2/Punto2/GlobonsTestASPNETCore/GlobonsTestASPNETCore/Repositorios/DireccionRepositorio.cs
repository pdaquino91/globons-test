using GlobonsTestASPNETCore.Models.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobonsTestASPNET.Repositorios
{
    public class DireccionRepositorio:RepositorioBase
    {
        public DireccionRepositorio(GlobonsTestModel ctx) : base(ctx)
        {
            
        }

        internal bool AgregarDireccion(Direccion direccion)
        {
            try
            {
                MiContexto.Direcciones.Add(direccion);
                MiContexto.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                string error = e.Message;
                string error2 = e.StackTrace;
                return false;
            }
        }

        internal List<Direccion> ObtenerListaDeDirecciones()
        {
            return MiContexto.Direcciones.ToList();
        }

        internal Direccion ObtenerDireccionPorId(int idDireccion)
        {
            return MiContexto.Direcciones.FirstOrDefault(e=>e.idDireccion==idDireccion);
        }

        internal bool EditarDireccionPorId(Direccion direccion)
        {
            try
            {
                MiContexto.Direcciones.FirstOrDefault(e => e.idDireccion == direccion.idDireccion).calle = direccion.calle;
                MiContexto.Direcciones.FirstOrDefault(e => e.idDireccion == direccion.idDireccion).numero = direccion.numero;
                MiContexto.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }


    }
}