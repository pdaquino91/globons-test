using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobonsTestASPNETCore.Models.BD
{
    public class Persona
    {
        public int idPersona { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int numeroDocumento { get; set; }
        public System.DateTime fechaNacimiento { get; set; }
        public int direccion { get; set; }

        public ICollection<Direccion> Direccion1 { get; set; }

    }
}
