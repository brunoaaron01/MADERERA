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
        public Int32 Upd_Producto(CE_Producto Req_Producto)
        {
            Int32 Rpta = 0;
            SqlCommand cmd = null;
            try
            {
                using (SqlConnection cn = CD_Conexion.Instancia.Conectar()) //singleton
                {
                    cmd = new SqlCommand("sp_Editar_Producto_Por_IdProducto", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDPRODUCTO", Req_Producto.IdProducto);
                    cmd.Parameters.AddWithValue("@IDTIPOPRODUC", Req_Producto.CE_TipoProducto.IdTipoProd);
                    cmd.Parameters.AddWithValue("@DESCRIPCION", Req_Producto.DescriProd);
                    cmd.Parameters.AddWithValue("@PRECIO", Req_Producto.PrecioProduc);
                    cn.Open();
                    Rpta = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { throw ex; }
            return Rpta;
        }
        public List<CE_Producto> Get_List_Producto(String NombreProducto)
        {
            SqlCommand cmd = null;
            List<CE_Producto> ListProducto = new List<CE_Producto>();
            try
            {
                using (SqlConnection cn = CD_Conexion.Instancia.Conectar()) //singleton
                {
                    cmd = new SqlCommand("Get_List_Producto_Por_NombreProducto", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NombreProducto", NombreProducto);
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            CE_Producto Get_Producto = new CE_Producto();
                            Get_Producto.IdProducto = Convert.ToInt32(dr["IDPRODUCTO"].ToString());
                            Get_Producto.CE_TipoProducto.IdTipoProd = Convert.ToInt32(dr["IDTIPOPRODUC"].ToString());
                            Get_Producto.NombreProd = dr["NOMBREPRODUC"].ToString();
                            Get_Producto.DescriProd = dr["DESCRIPCION"].ToString();
                            Get_Producto.StockProduc = Convert.ToInt32(dr["STOCK"].ToString());
                            Get_Producto.PrecioProduc = Convert.ToDecimal(dr["PRECIO"].ToString());
                            ListProducto.Add(Get_Producto);
                        }
                    }
                }
            }
            catch (Exception ex) { throw ex; }
            return ListProducto;
        }
    }
}
