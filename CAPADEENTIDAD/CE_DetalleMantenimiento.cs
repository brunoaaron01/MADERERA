using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADEENTIDAD
{
    public class CE_DetalleMantenimiento
    {
        public Int32 IdDetMan {  get; set; }
        public CE_Herramienta CE_Herramienta=new CE_Herramienta();
        public CE_MANTENIMIENTO CE_MANTENIMIENTO=new CE_MANTENIMIENTO();
        public Decimal Precio {  get; set; }
        public DateTime FechadeDetMan { get; set; }
    }
}
