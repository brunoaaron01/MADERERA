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
    public class DatUsuarios
    {
        private static readonly DatUsuarios usu = new DatUsuarios();

        public static DatUsuarios Usuario
        {
            get { return DatUsuarios.usu; }

        }

        public List<EntUsuarios> ListarUsuarios()
        {

            SqlCommand cmd = null;
            List<EntUsuarios> list = new List<EntUsuarios>();
            try
            {
                SqlConnection con = Conexion.Ingreso.Conectar();
                cmd = new SqlCommand("ListarUsuarios", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntUsuarios entUsuarios = new EntUsuarios();
                    entUsuarios.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    entUsuarios.Dni = dr["Dni"].ToString();
                    entUsuarios.NombreCompleto = dr["NombreCompleto"].ToString();
                    entUsuarios.Correo = dr["Correo"].ToString();
                    entUsuarios.Clave = dr["Clave"].ToString();
                    entUsuarios.Estado = Convert.ToBoolean(dr["Estado"]);
                    
                    entUsuarios.Rid = new EntRol()
                    {
                        Id = Convert.ToInt32(dr["id_rol"]),
                        Descripcion = dr["Descripcion"].ToString()
                    };

                    list.Add(entUsuarios);

                }

            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {

                cmd.Connection.Close();
            }
            return list;
        }
    }
}
