using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADEENTIDAD
{
    public class CE_Herramienta
    {
        public Int32 IdHerramienta {  get; set; }
        public String NomHerra {  get; set; }
        public String DescripcionHerra { get; set; }
        public CE_TipoHerramienta CE_TipoHerramienta=new CE_TipoHerramienta();
        public String Marca {  get; set; }
        public String Estado { get; set; }
    }
}
