using GlobonsTestASPNET.Models.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobonsTestASPNET.Repositorios
{
    public class DireccionRepositorio:RepositorioBase
    {
        public DireccionRepositorio(GlobonsTestEntities ctx) : base(ctx)
        {
            
        }

        internal bool AgregarDireccion(Direccion direccion)
        {
            try
            {
                MiContexto.Direccion.Add(direccion);
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
            return MiContexto.Direccion.ToList();
        }

        internal Direccion ObtenerDireccionPorId(int idDireccion)
        {
            return MiContexto.Direccion.FirstOrDefault(e=>e.idDireccion==idDireccion);
        }

        internal bool EditarDireccionPorId(Direccion direccion)
        {
            try
            {
                MiContexto.Direccion.FirstOrDefault(e => e.idDireccion == direccion.idDireccion).calle = direccion.calle;
                MiContexto.Direccion.FirstOrDefault(e => e.idDireccion == direccion.idDireccion).numero = direccion.numero;
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