using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Capa_Entidad;

namespace Capa_Datos
{
    public class Usuarios
    {
        private static readonly Usuarios usu = new Usuarios();

        public static Usuarios Usuario
        {
            get { return Usuarios.usu; } 
        
        }

       // public  List<E_Usuario>
    }
}
