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
    public class CD_TipoProducto
    {
        #region sigleton
        private static readonly CD_TipoProducto _instancia = new CD_TipoProducto();
        public static CD_TipoProducto Instancia
        {
            get
            {
                return CD_TipoProducto._instancia;
            }
        }
        #endregion singleton
        //Listar tipo producto por descripción
        public List<CE_TipoProducto> Get_List_TipoProducto(String Descripcion)
        {
            SqlCommand cmd = null;
            List<CE_TipoProducto> ListTipoProducto = new List<CE_TipoProducto>();
            try
            {
                using (SqlConnection cn = CD_Conexion.Instancia.Conectar()) //singleton
                {
                    cmd = new SqlCommand("sp_Get_List_TipoProducto_Por_Descripcion", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            CE_TipoProducto Get_TipoProducto = new CE_TipoProducto();
                            Get_TipoProducto.IdTipoProd = Convert.ToInt32(dr["IDTIPOPRODUC"].ToString());
                            Get_TipoProducto.Descripcion = dr["DESCRIPCION"].ToString();
                            Get_TipoProducto.FecRegTipoProd = Convert.ToDateTime(dr["FECHATIPOPRO"].ToString());
                            ListTipoProducto.Add(Get_TipoProducto);
                        }
                    }
                }
            }
            catch (Exception ex) { throw ex; }
            return ListTipoProducto;
        }
    }
}
