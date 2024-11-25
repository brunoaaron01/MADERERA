using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADEENTIDAD
{
    public  class CE_Cliente
    {
        public Int32 IdCliente {  get; set; }
        public String DNI { get; set; }
        public String NombreCli {  get; set; }
        public String Correo { get; set; }
        public String Telefono { get; set; }
        public DateTime FechaRegistroCliente { get; set; }

    }
}
