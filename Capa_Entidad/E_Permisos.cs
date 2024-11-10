using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class E_Permisos
    {
        public int IdPermisos { get; set; }
        public E_Rol Rid { get; set; }
        public string NombreMenu { get; set; }
        public string FechaRegistro     { get; set; }
    }
}
