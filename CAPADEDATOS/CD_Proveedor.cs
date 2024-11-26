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
    public class CD_Proveedor
    {
        #region sigleton
        private static readonly CD_Proveedor _instancia = new CD_Proveedor();
        public static CD_Proveedor Instancia
        {
            get
            {
                return CD_Proveedor._instancia;
            }
        }
        #endregion singleton
        public Int32 Ins_Proveedor(CE_Proveedor Req_Proveedor)
        {
            Int32 Rpta = 0;
            SqlCommand cmd = null;
            try
            {
                using (SqlConnection cn = CD_Conexion.Instancia.Conectar()) //singleton
                {
                    cmd = new SqlCommand("sp_InsertProveedor", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RUC", Req_Proveedor.RUC);
                    cmd.Parameters.AddWithValue("@RAZONSOCIAL", Req_Proveedor.RazonSocial);
                    cmd.Parameters.AddWithValue("@CORREO", Req_Proveedor.Correo);
                    cmd.Parameters.AddWithValue("@TELEFONO", Req_Proveedor.Telefono);
                    cmd.Parameters.AddWithValue("@FECHAPROVEEDOR", DateTime.Now);
                    cn.Open();
                    Rpta = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { throw ex; }
            return Rpta;
        }
        public Int32 Upd_Proveedor(CE_Proveedor Req_Proveedor)
        {
            Int32 Rpta = 0;
            SqlCommand cmd = null;
            try
            {
                using (SqlConnection cn = CD_Conexion.Instancia.Conectar()) //singleton
                {
                    cmd = new SqlCommand("sp_UpdProveedor", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDPROVEEDOR", Req_Proveedor.IdProveedor);
                    cmd.Parameters.AddWithValue("@RUC", Req_Proveedor.RUC);
                    cmd.Parameters.AddWithValue("@RAZONSOCIAL", Req_Proveedor.RazonSocial);
                    cmd.Parameters.AddWithValue("@CORREO", Req_Proveedor.Correo);
                    cmd.Parameters.AddWithValue("@TELEFONO", Req_Proveedor.Telefono);
                    cn.Open();
                    Rpta = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { throw ex; }
            return Rpta;
        }
        public Int32 Del_Proveedor(CE_Proveedor Req_Proveedor)
        {
            Int32 Rpta = 0;
            SqlCommand cmd = null;
            try
            {
                using (SqlConnection cn = CD_Conexion.Instancia.Conectar()) //singleton
                {
                    cmd = new SqlCommand("sp_DelProveedor", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDPROVEEDOR", Req_Proveedor.IdProveedor);
                    cn.Open();
                    Rpta = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { throw ex; }
            return Rpta;
        }
        public List<CE_Proveedor> List_Proveedor_Por_NroDocIde(String NroDocProv)
        {
            SqlCommand cmd = null;
            List<CE_Proveedor> ListProveedor = new List<CE_Proveedor>();
            try
            {
                SqlConnection cn = CD_Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("Get_List_Proveedor_Por_NroDocIde", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RUC", NroDocProv);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CE_Proveedor Get_Proveedor = new CE_Proveedor();
                    Get_Proveedor.IdProveedor = Convert.ToInt32(dr["IDPROVEEDOR"].ToString());
                    Get_Proveedor.RUC = dr["RUC"].ToString();
                    Get_Proveedor.RazonSocial = dr["RAZONSOCIAL"].ToString();
                    Get_Proveedor.Correo = dr["CORREO"].ToString();
                    Get_Proveedor.Telefono = dr["TELEFONO"].ToString();
                    ListProveedor.Add(Get_Proveedor);
                }

            }
            catch (Exception ex) { throw ex; }

            finally
            {
                cmd.Connection.Close();
            }
            return ListProveedor;
        }
    }
}
