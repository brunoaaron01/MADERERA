using CAPADEENTIDAD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPAPRESENTACION
{
    public partial class CoredeCompra : Form
    {
        private static List<CE_Usuario> usuarioActual;
        public CoredeCompra(List<CE_Usuario> objusuario = null)
        {
            if (objusuario == null)
                usuarioActual = new List<CE_Usuario>
                {
                    new CE_Usuario { Usuario = "ADMIN PREDEFINIDO" }
                };
            else
                usuarioActual = objusuario;
            InitializeComponent();
            AsignarDatosUsuario();
        }

        private void CoredeCompra_Load(object sender, EventArgs e)
        {

        }
        private void AsignarDatosUsuario()
        {
            txtIdUsuario.Text = usuarioActual[0].IdUsuario.ToString();
            txtNroDocUsuario.Text = usuarioActual[0].NroDocIde;
            txtNombreUsuario.Text = usuarioActual[0].Nombre;
            txtCargoUsuario.Text = usuarioActual[0].CE_Rol.NombreRol;
        }
    }
}
