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
    public class CD_DetalleVenta
    {
        #region sigleton
        private static readonly CD_DetalleVenta _instancia = new CD_DetalleVenta();
        public static CD_DetalleVenta Instancia
        {
            get
            {
                return CD_DetalleVenta._instancia;
            }
        }
        #endregion singleton
        public Int32 Ins_DetalleVenta(CE_DetalleVenta Req_DetalleVenta)
        {
            Int32 Rpta = 0;
            SqlCommand cmd = null;
            try
            {
                using (SqlConnection cn = CD_Conexion.Instancia.Conectar()) //singleton
                {
                    cmd = new SqlCommand("sp_InsertDetalleVenta", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDDETVEN", Req_DetalleVenta.IdDetalleVenta);
                    cmd.Parameters.AddWithValue("@IDVENTA", Req_DetalleVenta.CE_Venta.IdVenta);
                    cmd.Parameters.AddWithValue("@IDPRODUCTO", Req_DetalleVenta.CE_Producto.IdProducto);
                    cmd.Parameters.AddWithValue("@PRECIO", Req_DetalleVenta.PrecioDetVenta);
                    cmd.Parameters.AddWithValue("@CANTIDAD", Req_DetalleVenta.CantidadVenta);
                    cmd.Parameters.AddWithValue("@FECHADETVENTA", DateTime.Now);
                    cn.Open();
                    Rpta = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { throw ex; }
            return Rpta;
        }
        public List<CE_DetalleVenta> List_DetalleVenta_IdVenta(Int32 IdVenta)
        {
            SqlCommand cmd = null;
            List<CE_DetalleVenta> ListDetalleVenta = new List<CE_DetalleVenta>();
            try
            {
                SqlConnection cn = CD_Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("sp_Get_ListDetalleVenta_IdVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdVenta", IdVenta);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CE_DetalleVenta Get_DetalleVenta = new CE_DetalleVenta();
                    Get_DetalleVenta.IdDetalleVenta = Convert.ToInt32(dr["IDDETVEN"].ToString());
                    Get_DetalleVenta.CE_Cliente.DNI = dr["DNI"].ToString();
                    Get_DetalleVenta.CE_Cliente.NombreCli = dr["NOMBRECLI"].ToString();
                    Get_DetalleVenta.CE_Producto.NombreProd = dr["NOMBREPRODUC"].ToString();
                    Get_DetalleVenta.PrecioDetVenta = Convert.ToDecimal(dr["PRECIO"].ToString());
                    Get_DetalleVenta.CantidadVenta = Convert.ToInt32(dr["CANTIDAD"].ToString());
                    ListDetalleVenta.Add(Get_DetalleVenta);
                }

            }
            catch (Exception ex) { throw ex; }

            finally
            {
                cmd.Connection.Close();
            }
            return ListDetalleVenta;
        }
    }
}
