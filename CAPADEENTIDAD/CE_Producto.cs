using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADEENTIDAD
{
    public class CE_Producto
    {
        public Int32 IdProducto { get; set; }
        public String NombreProd {  get; set; }
        public String DescriProd { get; set; } 
        public Int32 StockProduc {  get; set; }
        public Decimal PrecioProduc { get; set; }
        public DateTime FechaProduc { get; set; }
        public CE_TipoProducto CE_TipoProducto=new CE_TipoProducto();

    }
}
