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
    public class CD_Prodcuto
    {
        #region sigleton
        private static readonly CD_Prodcuto _instancia = new CD_Prodcuto();
        public static CD_Prodcuto Instancia
        {
            get
            {
                return CD_Prodcuto._instancia;
            }
        }
        #endregion singleton
        public Int32 Ins_Producto(CE_Producto Req_Producto)
        {
            Int32 Rpta = 0;
            SqlCommand cmd = null;
            try
            {
                using (SqlConnection cn = CD_Conexion.Instancia.Conectar()) //singleton
                {
                    cmd = new SqlCommand("sp_InsertProducto", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NOMBREPRODUC", Req_Producto.NombreProd);
                    cmd.Parameters.AddWithValue("@DESCRIPCION", Req_Producto.DescriProd);
                    cmd.Parameters.AddWithValue("@STOCK", Req_Producto.StockProduc);
                    cmd.Parameters.AddWithValue("@PRECIO", Req_Producto.PrecioProduc);
                    cmd.Parameters.AddWithValue("@FECHAPRODUC", DateTime.Now);
                    cmd.Parameters.AddWithValue("@IDTIPOPRODUC", Req_Producto.CE_TipoProducto.IdTipoProd);
                    cn.Open();
                    Rpta = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { throw ex; }
            return Rpta;
        }
    }
}
