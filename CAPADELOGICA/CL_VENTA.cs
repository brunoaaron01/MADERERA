using CAPADEDATOS;
using CAPADEENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADELOGICA
{
    public class CL_VENTA
    {
        #region sigleton
        private static readonly CL_VENTA _instancia = new CL_VENTA();
        public static CL_VENTA Instancia
        {
            get
            {
                return CL_VENTA._instancia;
            }
        }
        #endregion singleton
        public Int32 Ins_Venta(CE_Venta Req_Venta)
        {
            return CD_Venta.Instancia.Ins_Venta(Req_Venta);
        }
    }
}
