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
    public partial class CoreVenta : Form
    {
        private static List<CE_Usuario> usuarioActual;
        public CoreVenta(List<CE_Usuario> objusuario = null)
        {
            if (objusuario == null)
                usuarioActual = new List<CE_Usuario>
                {
                    new CE_Usuario { Usuario = "ADMIN PREDEFINIDO" }
                };
            else
                usuarioActual = objusuario;
            AsignarDatosUsuario();
            InitializeComponent();
        }

        private void CoreVenta_Load(object sender, EventArgs e)
        {
        }
        private void AsignarDatosUsuario() {
            txtNroDocIdeUsu.Text = usuarioActual[0].Nombre;
            txtNombreUsu.Text = usuarioActual[0].NroDocIde;
            txtCargoUsu.Text = usuarioActual[0].CE_Rol.NombreRol;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentaBuscarCliente buscarCliente = new VentaBuscarCliente();
            buscarCliente.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VentaBuscarVendedor buscarvend = new VentaBuscarVendedor();
            buscarvend.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentaBuscarProducto buscarpro = new VentaBuscarProducto();
            buscarpro.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VentaBuscarProducto buscarpro = new VentaBuscarProducto();
            buscarpro.ShowDialog();
        }
    }
}
