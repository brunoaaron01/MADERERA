using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADEENTIDAD
{
    public class CE_GridDetalleVenta
    {
        public Int32 IdDetalleVenta { get; set; }
        public Int32 IdProducto { get; set; }
        public String NombreProducto { get; set; }
        public Decimal PrecioProducto { get; set; }
        public Decimal CantidadProducto { get; set; }
        public Decimal SubTotalVenta { get; set; }
    }
}
