using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADEENTIDAD
{
    public class CE_MANTENIMIENTO
    {
        public Int32 Idman { get; set; }
        public DateTime Fechamantenimiento { get; set; }
        public String Descripcionman { get; set; }
        public CE_TipoMantenimiento CE_TipoMantenimiento =new CE_TipoMantenimiento();
        public CE_Usuario CE_Usuario=new CE_Usuario();
        public Decimal CostoMantenimiento { get; set; }
    }
}
