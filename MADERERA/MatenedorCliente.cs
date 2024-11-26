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
            AutocompletarCLiente();
        }
        private void MatenedorCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarCLiente_Click(object sender, EventArgs e)
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
                Nuevo();
            }
            else
            {
                MessageBox.Show($"Error al registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AutocompletarCLiente() {
            try
            {
                AutoCompleteStringCollection ClienteCollection = new AutoCompleteStringCollection();
                List<CE_Cliente> ListCliente = new CL_CLIENTE().List_Cliente_Por_NroDocIde(txtNroDocIdeCli.Text);

                if (ListCliente.Count > 0)
                {
                    foreach (var Cli in ListCliente)
                    {
                        ClienteCollection.Add(Cli.DNI);
                    }
                    txtNroDocIdeCli.AutoCompleteCustomSource = ClienteCollection;
                    txtNroDocIdeCli.AutoCompleteMode = AutoCompleteMode.Suggest;
                    txtNroDocIdeCli.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
                else
                {
                    // Limpiar las sugerencias si no hay resultados
                    txtNroDocIdeCli.AutoCompleteCustomSource.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener sugerencias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Obtener_Datos_Cliente_Seleccionado(String NroDocCliente)
        {
            Int32 Stock = 0;
            List<CE_Cliente> ListCliente = new CL_CLIENTE().List_Cliente_Por_NroDocIde(NroDocCliente);
            if (ListCliente.Count > 0)
            {
                foreach (var Cli in ListCliente)
                {
                    txtIdCliente.Text = Cli.IdCliente.ToString();
                    txtNroDocIdeCli.Text = Cli.DNI.ToString();
                    txtNomCliente.Text = Cli.NombreCli.ToString();
                    txtCorreoCli.Text = Cli.Correo.ToString();
                    txtFonoCli.Text = Cli.Telefono.ToString();
                }
                btnEditarCliente.Visible = true;
                btnEliminar.Visible = true;
                btnNuevo.Visible = true;
            }
            else
            {
                MessageBox.Show($"Error al obtener datos de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNroDocIdeCli_Leave(object sender, EventArgs e)
        {
            if (txtNroDocIdeCli.Text != "")
            {
                Obtener_Datos_Cliente_Seleccionado(txtNroDocIdeCli.Text);
            }
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            CE_Cliente Req_Cliente = new CE_Cliente();
            Req_Cliente.IdCliente = Convert.ToInt32(txtIdCliente.Text.ToString());
            Req_Cliente.DNI = txtNroDocIdeCli.Text.Trim();
            Req_Cliente.NombreCli = txtNomCliente.Text.Trim();
            Req_Cliente.Correo = txtCorreoCli.Text.Trim();
            Req_Cliente.Telefono = txtFonoCli.Text.Trim();

            Int32 Rpt = CL_CLIENTE.Instancia.Upd_Cliente(Req_Cliente);

            if (Rpt == 1)
            {
                MessageBox.Show("Cliente actualizado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Nuevo();
            }
            else
            {
                MessageBox.Show($"Error al registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Nuevo() {
            txtIdCliente.Clear();
            txtNroDocIdeCli.Clear();
            txtNomCliente.Clear();
            txtCorreoCli.Clear();
            txtFonoCli.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CE_Cliente Req_Cliente = new CE_Cliente();
            Req_Cliente.IdCliente = Convert.ToInt32(txtIdCliente.Text.ToString());

            Int32 Rpt = CL_CLIENTE.Instancia.Del_Cliente(Req_Cliente);

            if (Rpt == 1)
            {
                MessageBox.Show("Cliente eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Nuevo();
            }
            else
            {
                MessageBox.Show($"Error al registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
