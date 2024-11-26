using CAPADEENTIDAD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace CAPADEDATOS
{
    public class CD_Cliente
    {
        #region sigleton
        private static readonly CD_Cliente _instancia = new CD_Cliente();
        public static CD_Cliente Instancia
        {
            get
            {
                return CD_Cliente._instancia;
            }
        }
        #endregion singleton
        public Int32 Ins_Cliente(CE_Cliente Req_Cliente) { 
            Int32 Rpta = 0;
            SqlCommand cmd = null;
            try
            {
                using (SqlConnection cn = CD_Conexion.Instancia.Conectar()) //singleton
                {
                    cmd = new SqlCommand("sp_InsertCliente", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DNI", Req_Cliente.DNI);
                    cmd.Parameters.AddWithValue("@NOMBRECLI", Req_Cliente.NombreCli);
                    cmd.Parameters.AddWithValue("@CORREO", Req_Cliente.Correo);
                    cmd.Parameters.AddWithValue("@TELEFONO", Req_Cliente.Telefono);
                    cmd.Parameters.AddWithValue("@FECHACLI", DateTime.Now);
                    cn.Open();
                    Rpta = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { throw ex; }
            return Rpta;
        }
        public Int32 Upd_Cliente(CE_Cliente Req_Cliente)
        {
            Int32 Rpta = 0;
            SqlCommand cmd = null;
            try
            {
                using (SqlConnection cn = CD_Conexion.Instancia.Conectar()) //singleton
                {
                    cmd = new SqlCommand("sp_UpdCliente", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDCLI", Req_Cliente.IdCliente);
                    cmd.Parameters.AddWithValue("@DNI", Req_Cliente.DNI);
                    cmd.Parameters.AddWithValue("@NOMBRECLI", Req_Cliente.NombreCli);
                    cmd.Parameters.AddWithValue("@CORREO", Req_Cliente.Correo);
                    cmd.Parameters.AddWithValue("@TELEFONO", Req_Cliente.Telefono);
                    cn.Open();
                    Rpta = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { throw ex; }
            return Rpta;
        }
        public Int32 Del_Cliente(CE_Cliente Req_Cliente)
        {
            Int32 Rpta = 0;
            SqlCommand cmd = null;
            try
            {
                using (SqlConnection cn = CD_Conexion.Instancia.Conectar()) //singleton
                {
                    cmd = new SqlCommand("sp_DelCliente", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDCLI", Req_Cliente.IdCliente);
                    cn.Open();
                    Rpta = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { throw ex; }
            return Rpta;
        }
        //Listar cliente por DNI
        public List<CE_Cliente> List_Cliente_Por_NroDocIde(String NroDocCli)
        {
            SqlCommand cmd = null;
            List<CE_Cliente> ListCliente = new List<CE_Cliente>();
            try
            {
                SqlConnection cn = CD_Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("Get_List_Cliente_Por_NroDocIde", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DNI", NroDocCli);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CE_Cliente Get_Cliente = new CE_Cliente();
                    Get_Cliente.IdCliente = Convert.ToInt32(dr["IDCLI"].ToString());
                    Get_Cliente.DNI = dr["DNI"].ToString();
                    Get_Cliente.NombreCli = dr["NOMBRECLI"].ToString();
                    Get_Cliente.Correo = dr["CORREO"].ToString();
                    Get_Cliente.Telefono = dr["TELEFONO"].ToString();
                    ListCliente.Add(Get_Cliente);
                }

            }
            catch (Exception ex) { throw ex; }

            finally
            {
                cmd.Connection.Close();
            }
            return ListCliente;
        }
    }
}
