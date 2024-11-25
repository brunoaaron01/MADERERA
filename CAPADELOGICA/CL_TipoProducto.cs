using CAPADEDATOS;
using CAPADEENTIDAD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADELOGICA
{
    public class CL_TipoProducto
    {
        #region sigleton
        private static readonly CL_TipoProducto _instancia = new CL_TipoProducto();
        public static CL_TipoProducto Instancia
        {
            get
            {
                return CL_TipoProducto._instancia;
            }
        }
        #endregion singleton
        public List<CE_TipoProducto> Get_List_TipoProducto(String Descripcion)
        {
            return CD_TipoProducto.Instancia.Get_List_TipoProducto(Descripcion);
        }
        public DataTable Get_dt_TipoProducto(String Descripcion)
        {
            return CD_TipoProducto.Instancia.Get_dt_TipoProducto(Descripcion);
        }
        public Int32 Ins_TipoProducto(CE_TipoProducto Req_TipoProducto) { 
            return CD_TipoProducto.Instancia.Ins_TipoProducto(Req_TipoProducto);
        }
    }
}
