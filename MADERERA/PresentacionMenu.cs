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
    public partial class PresentacionMenu : Form
    {
        private static List<CE_Usuario> usuarioActual;
        public PresentacionMenu(List<CE_Usuario> objusuario = null)
        {

            if (objusuario == null)
                usuarioActual = new List<CE_Usuario>
                {
                    new CE_Usuario { Usuario = "ADMIN PREDEFINIDO" }
                };
            else
                usuarioActual = objusuario;
            MostrarMensajeBienvenida();
            InitializeComponent();
        }
        private void MostrarMensajeBienvenida()
        {
            string nombreUsuario = usuarioActual[0].Nombre;
            MessageBox.Show($"¡Bienvenido, {nombreUsuario}!", "Bienvenida", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MatenedorCliente mc = new MatenedorCliente();
            mc.ShowDialog();
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorUsuario mu=new MantenedorUsuario();
            mu.ShowDialog();
        }

        private void registrarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorProveedor mp=new MantenedorProveedor();
            mp.ShowDialog();
        }

        private void registrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorProducto mp=new MantenedorProducto();
            mp.ShowDialog();
        }

        private void registrarHerramientaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorHerramientas mp=new MantenedorHerramientas();
            mp.ShowDialog();
        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoreVenta cv= new CoreVenta(usuarioActual);
            cv.ShowDialog();    
        }

        private void registrarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoredeCompra cc=new CoredeCompra(usuarioActual); 
            cc.ShowDialog();
        }

        private void consultasDetalleDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorDetalleVenta mdv=new MantenedorDetalleVenta();
            mdv.ShowDialog();
        }

        private void consultasDetalleDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorDetalleCompra cc=new MantenedorDetalleCompra();
            cc.ShowDialog();   
        }

        private void PresentacionMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
