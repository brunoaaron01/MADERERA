using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADEENTIDAD
{
    public class CE_COMPRA
    {
        public Int32 IdCompra {  get; set; }
        public DateTime FechaCompra { get; set; }
        public Decimal MontoTotal { get; set; }
        public CE_Usuario CE_Usuario=new CE_Usuario();
        public CE_Proveedor CE_Proveedor=new CE_Proveedor();
    }
}
