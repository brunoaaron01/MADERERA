using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADEENTIDAD
{
    public  class CE_DetalleVenta
    {
        public Int32 IdDetalleVenta {  get; set; }
        public CE_Venta CE_Venta=new CE_Venta();
        public CE_Producto CE_Producto=new CE_Producto();
        public CE_Cliente CE_Cliente = new CE_Cliente();
        public Decimal PrecioDetVenta { get; set; }
        public Int32 CantidadVenta { get; set; }
        public DateTime FechadeDetVenta { get; set; }
        public Decimal SubTotal { get; set; }
    }
}
