using CAPADEDATOS;
using CAPADEENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADELOGICA
{
    public class CL_Proveedor
    {
        #region sigleton
        private static readonly CL_Proveedor _instancia = new CL_Proveedor();
        public static CL_Proveedor Instancia
        {
            get
            {
                return CL_Proveedor._instancia;
            }
        }
        #endregion singleton
        public Int32 Ins_Proveedor(CE_Proveedor Req_Proveedor)
        {
            return CD_Proveedor.Instancia.Ins_Proveedor(Req_Proveedor);
        }
        public Int32 Upd_Proveedor(CE_Proveedor Req_Proveedor)
        {
            return CD_Proveedor.Instancia.Upd_Proveedor(Req_Proveedor);
        }
        public Int32 Del_Proveedor(CE_Proveedor Req_Proveedor)
        {
            return CD_Proveedor.Instancia.Del_Proveedor(Req_Proveedor);
        }
        public List<CE_Proveedor> List_Proveedor_Por_NroDocIde(String NroDocProv)
        {
            return CD_Proveedor.Instancia.List_Proveedor_Por_NroDocIde(NroDocProv);
        }
    }
}
