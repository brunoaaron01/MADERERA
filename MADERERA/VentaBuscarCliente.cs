using CAPADEENTIDAD;
using CAPADELOGICA;
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
    public partial class VentaBuscarCliente : Form
    {
        private CoreVenta _coreVenta;
        public VentaBuscarCliente(CoreVenta coreVenta)
        {
            InitializeComponent();
            _coreVenta = coreVenta;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List_Cliente();
        }
        private void List_Cliente()
        {
            List<CE_Cliente> ListCliente = new CL_CLIENTE().List_Cliente_Por_NroDocIde(txtNroDocCli.Text);
            dataGridView1.DataSource = ListCliente;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dataGridView1.Rows[e.RowIndex];
            _coreVenta.txtIdClienteBus.Text = filaActual.Cells[0].Value.ToString();
            _coreVenta.txtNroDocIdeClieBus.Text = filaActual.Cells[1].Value.ToString();
            _coreVenta.txtNomBus.Text = filaActual.Cells[2].Value.ToString();
            _coreVenta.txtCorreoBus.Text = filaActual.Cells[3].Value.ToString();
            _coreVenta.txtTelBus.Text = filaActual.Cells[4].Value.ToString();
            this.Hide();
        }
    }
}
