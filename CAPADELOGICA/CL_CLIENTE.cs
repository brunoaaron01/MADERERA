using CAPADEDATOS;
using CAPADEENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADELOGICA
{
    public class CL_CLIENTE
    {
        #region sigleton
        private static readonly CL_CLIENTE _instancia = new CL_CLIENTE();
        public static CL_CLIENTE Instancia
        {
            get
            {
                return CL_CLIENTE._instancia;
            }
        }
        #endregion singleton
        public Int32 Ins_Cliente(CE_Cliente Req_Cliente)
        {
            return CD_Cliente.Instancia.Ins_Cliente(Req_Cliente);
        }
        public Int32 Upd_Cliente(CE_Cliente Req_Cliente)
        {
            return CD_Cliente.Instancia.Upd_Cliente(Req_Cliente);
        }
        public Int32 Del_Cliente(CE_Cliente Req_Cliente)
        {
            return CD_Cliente.Instancia.Del_Cliente(Req_Cliente);
        }
        public List<CE_Cliente> List_Cliente_Por_NroDocIde(String NroDocCli)
        {
            return CD_Cliente.Instancia.List_Cliente_Por_NroDocIde(NroDocCli);
        }
    }
}
