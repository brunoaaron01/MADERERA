using CAPADEENTIDAD;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADEDATOS
{
    public class CD_Usuario
    {
        #region sigleton
        //Patron Singleton
        //Variable estática para la instancia
        private static readonly CD_Usuario _instancia = new CD_Usuario();
        //privado para evitar la instanciación directa
        public static CD_Usuario Instancia
        {
            get
            {
                return CD_Usuario._instancia;
            }
        }
        #endregion singleton
        //Login Usuario
        public List<CE_Usuario> ValidarLoginUsuario(CE_Usuario Usuario) { 
            SqlCommand cmd = null;
            List<CE_Usuario> ListUsuario = new List<CE_Usuario>();
            try {
                SqlConnection cn = CD_Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("sp_GetUsuarioForLogin", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", Usuario.Usuario);
                cmd.Parameters.AddWithValue("@Pass", Usuario.Pass);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CE_Usuario Get_Usuario = new CE_Usuario();
                    Get_Usuario.IdUsuario = Convert.ToInt32(dr["IDUSU"].ToString());
                    Get_Usuario.Usuario = dr["USUARIO"].ToString();
                    Get_Usuario.Nombre = dr["Nombre"].ToString();
                    Get_Usuario.NroDocIde = dr["NroDocIde"].ToString();
                    Get_Usuario.CE_Rol.NombreRol = dr["NOMBREROL"].ToString();
                    ListUsuario.Add(Get_Usuario);
                }

            }
            catch (Exception ex) { throw ex; }

            finally
            {
                cmd.Connection.Close();
            }
            return ListUsuario;
        }
    }
}
