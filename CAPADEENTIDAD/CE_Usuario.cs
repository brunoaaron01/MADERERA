using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADEENTIDAD
{
    public class CE_Usuario
    {
        public String Usuario { get; set; }
        public String Pass { get; set; }
        public String Nombre { get; set; }
        public String NroDocIde { get; set; }
        public CE_Rol CE_Rol = new CE_Rol();
    }
}
