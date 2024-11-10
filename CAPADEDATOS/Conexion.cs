using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADEDATOS
{
    public class Conexion
    {
        private static readonly Conexion _ingreso = new Conexion();

        public static Conexion Ingreso
        {
            get { return Conexion._ingreso; }
        }

        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source= BRUNOPC; Initial Catalog=MADERERA;" +
                " User= BRUNOSQL; password=root;Integrated Security = true";

            return cn;
        }
    }
}
