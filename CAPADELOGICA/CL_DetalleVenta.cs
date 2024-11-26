using CAPADEDATOS;
using CAPADEENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADELOGICA
{
    public class CL_DetalleVenta
    {
        #region sigleton
        private static readonly CL_DetalleVenta _instancia = new CL_DetalleVenta();
        public static CL_DetalleVenta Instancia
        {
            get
            {
                return CL_DetalleVenta._instancia;
            }
        }
        #endregion singleton
        public Int32 Ins_DetalleVenta(CE_DetalleVenta Req_DetalleVenta)
        {
            return CD_DetalleVenta.Instancia.Ins_DetalleVenta(Req_DetalleVenta);
        }
        public List<CE_DetalleVenta> List_DetalleVenta_IdVenta(Int32 IdVenta)
        {
            return CD_DetalleVenta.Instancia.List_DetalleVenta_IdVenta(IdVenta);
        }
    }
}
