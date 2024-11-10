using CAPADEDATOS;
using CAPADEENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADELOGICA
{
    public class LogUsuarios
    {
        private static readonly LogUsuarios logusu = new LogUsuarios();

        public static LogUsuarios Log
        {
            get { return LogUsuarios.logusu; }

        }

        public List<EntUsuarios> ListarUsuarios()
        {

            return DatUsuarios.Usuario.ListarUsuarios();
        }
    }
}
