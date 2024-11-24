using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADEDATOS
{
    public class CD_Conexion
    {
        //patron de Diseño Singleton
        private static readonly CD_Conexion _instancia = new CD_Conexion();
        public static CD_Conexion Instancia
        {
            get { return CD_Conexion._instancia; }
        }
        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=JOSE; Initial Catalog = DBMADERERA;User= Jose; password=TiraDeCerdo2991!; Integrated Security=true";

            return cn;
        }        
    }
}
