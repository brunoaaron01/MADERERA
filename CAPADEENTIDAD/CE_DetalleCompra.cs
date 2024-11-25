using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADEENTIDAD
{
    public class CE_DetalleCompra
    {
        public Int32 IdDetalleCompra {  get; set; }
        public CE_COMPRA CE_COMPRA=new CE_COMPRA();
        public CE_Producto CE_Producto=new CE_Producto();
        public Decimal PrecioDetCompra {  get; set; }
        public Decimal MontoTotal { get; set; }
        public DateTime FechaDetCompra { get; set; }
    }
}
