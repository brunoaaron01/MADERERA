using CAPADEDATOS;
using CAPADEENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADELOGICA
{
    public class CL_PRODUCTO
    {
        #region sigleton
        private static readonly CL_PRODUCTO _instancia = new CL_PRODUCTO();
        public static CL_PRODUCTO Instancia
        {
            get
            {
                return CL_PRODUCTO._instancia;
            }
        }
        #endregion singleton
        public Int32 Ins_Producto(CE_Producto Req_Producto)
        {
            return CD_Prodcuto.Instancia.Ins_Producto(Req_Producto);
        }
    }
}
