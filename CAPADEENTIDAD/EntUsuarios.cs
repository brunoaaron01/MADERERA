using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADEENTIDAD
{
    public class EntUsuarios
    {
        public int IdUsuario { get; set; }
        public string Dni { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }

        public EntRol Rid { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
    }
}
