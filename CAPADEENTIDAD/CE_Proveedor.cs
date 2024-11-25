using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADEENTIDAD
{
    public class CE_Proveedor
    {
        public Int32 IdProveedor {  get; set; }
        public String RazonSocial {  get; set; }
        public String Correo {  get; set; }
        public String Telefono { get; set; }

        public DateTime FechaProveedor { get; set; }

    }
}
