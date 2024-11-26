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
    public partial class MatenedorCliente : Form
    {
        public MatenedorCliente()
        {
            InitializeComponent();
        }
        private void MatenedorCliente_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            CE_Cliente Req_Cliente = new CE_Cliente();
            Req_Cliente.DNI = txtNroDocIdeCli.Text.Trim();
            Req_Cliente.NombreCli = txtNomCliente.Text.Trim();
            Req_Cliente.Correo = txtCorreoCli.Text.Trim();
            Req_Cliente.Telefono = txtFonoCli.Text.Trim();

            Int32 Rpt = CL_CLIENTE.Instancia.Ins_Cliente(Req_Cliente);

            if (Rpt == 1)
            {
                MessageBox.Show("CLiente registrado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNroDocIdeCli.Text = "";
                txtNomCliente.Text = "";
                txtCorreoCli.Text = "";
                txtFonoCli.Text = "";
            }
            else
            {
                MessageBox.Show($"Error al registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
