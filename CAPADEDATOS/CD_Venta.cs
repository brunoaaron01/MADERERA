using CAPADEENTIDAD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADEDATOS
{
    public class CD_Venta
    {
        #region sigleton
        private static readonly CD_Venta _instancia = new CD_Venta();
        public static CD_Venta Instancia
        {
            get
            {
                return CD_Venta._instancia;
            }
        }
        #endregion singleton
        public Int32 Ins_Venta(CE_Venta Req_Venta)
        {
            Int32 Rpta = 0;
            SqlCommand cmd = null;
            try
            {
                using (SqlConnection cn = CD_Conexion.Instancia.Conectar()) //singleton
                {
                    cmd = new SqlCommand("sp_InsertVenta", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDCLI", Req_Venta.Cliente.IdCliente);
                    cmd.Parameters.AddWithValue("@IDUSU", Req_Venta.CE_Usuario.IdUsuario);
                    cmd.Parameters.AddWithValue("@MONTO", Req_Venta.Monto);
                    cmd.Parameters.AddWithValue("@FECHAVENTA", DateTime.Now);
                    cn.Open();
                    Rpta = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex) { throw ex; }
            return Rpta;
        }
    }
}
