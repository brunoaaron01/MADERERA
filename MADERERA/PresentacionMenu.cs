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
        private static EntUsuarios usuarioActual;
        public PresentacionMenu(EntUsuarios objusuario = null)
        {

            if (objusuario == null)
                usuarioActual = new EntUsuarios() { NombreCompleto = "ADMIN PREDEFINIDO", IdUsuario = 1 };
            else
                usuarioActual = objusuario;
            InitializeComponent();
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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
            CoreVenta cv=new CoreVenta();
            cv.ShowDialog();    
        }

        private void registrarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoredeCompra cc=new CoredeCompra(); 
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
    }
}
