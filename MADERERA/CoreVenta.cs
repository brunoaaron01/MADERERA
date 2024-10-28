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
        public CoreVenta()
        {
            InitializeComponent();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentaBuscarCliente buscarCliente = new VentaBuscarCliente();
            buscarCliente.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VentaBuscarVendedor buscar  =new VentaBuscarVendedor();
            buscar.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VentaBuscarProducto buscarProduct=new VentaBuscarProducto();
            buscarProduct.ShowDialog();
        }
    }
}
