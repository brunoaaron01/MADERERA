using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADEENTIDAD
{
    public class CE_Venta
    {
        public Int32 IdVenta { get; set; }
        public CE_Cliente Cliente =new CE_Cliente();
        public CE_Usuario CE_Usuario=new CE_Usuario();
        public Decimal Monto {  get; set; }
        public DateTime FechaVenta { get; set; }

    }
}
