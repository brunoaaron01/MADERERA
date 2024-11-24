using CAPADEDATOS;
using CAPADEENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADELOGICA
{
    public class CL_Usuario
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly CL_Usuario _instancia = new CL_Usuario();
        //privado para evitar la instanciación directa
        public static CL_Usuario Instancia
        {
            get
            {
                return CL_Usuario._instancia;
            }
        }
        #endregion singleton
        public List<CE_Usuario> ValidarLoginUsuario(CE_Usuario Usuario)
        {
            return CD_Usuario.Instancia.ValidarLoginUsuario(Usuario);
        }
    }
}
