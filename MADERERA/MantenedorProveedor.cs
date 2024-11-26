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
    public partial class MantenedorProveedor : Form
    {
        public MantenedorProveedor()
        {
            InitializeComponent();
            AutocompletarProveedor();
        }

        private void MantenedorProveedor_Load(object sender, EventArgs e)
        {

        }
        private void btnAgregarProv_Click(object sender, EventArgs e)
        {
            CE_Proveedor Req_Proveedor = new CE_Proveedor();
            Req_Proveedor.RUC = txtNroDocumento.Text.Trim();
            Req_Proveedor.RazonSocial = txtRazonSocial.Text.Trim();
            Req_Proveedor.Correo = txtCorreo.Text.Trim();
            Req_Proveedor.Telefono = txtTelefono.Text.Trim();

            Int32 Rpt = CL_Proveedor.Instancia.Ins_Proveedor(Req_Proveedor);

            if (Rpt == 1)
            {
                MessageBox.Show("Proveedor registrado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Nuevo();
                AutocompletarProveedor();
            }
            else
            {
                MessageBox.Show($"Error al registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AutocompletarProveedor()
        {
            try
            {
                AutoCompleteStringCollection ProveedorCollection = new AutoCompleteStringCollection();
                List<CE_Proveedor> ListProveedor = new CL_Proveedor().List_Proveedor_Por_NroDocIde(txtNroDocumento.Text);

                if (ListProveedor.Count > 0)
                {
                    foreach (var Prov in ListProveedor)
                    {
                        ProveedorCollection.Add(Prov.RUC);
                    }
                    txtNroDocumento.AutoCompleteCustomSource = ProveedorCollection;
                    txtNroDocumento.AutoCompleteMode = AutoCompleteMode.Suggest;
                    txtNroDocumento.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
                else
                {
                    // Limpiar las sugerencias si no hay resultados
                    txtNroDocumento.AutoCompleteCustomSource.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener sugerencias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Obtener_Datos_Proveedor_Seleccionado(String NroDocProveedor)
        {
            Int32 Stock = 0;
            List<CE_Proveedor> ListProveedor = new CL_Proveedor().List_Proveedor_Por_NroDocIde(NroDocProveedor);
            if (ListProveedor.Count > 0)
            {
                foreach (var Prov in ListProveedor)
                {
                    txtIdProveedor.Text = Prov.IdProveedor.ToString();
                    txtNroDocumento.Text = Prov.RUC.ToString();
                    txtRazonSocial.Text = Prov.RazonSocial.ToString();
                    txtCorreo.Text = Prov.Correo.ToString();
                    txtTelefono.Text = Prov.Telefono.ToString();
                }
                btnEditarProv.Visible = true;
                BtnEliminarProv.Visible = true;
                btnNuevo.Visible = true;
            }
            else
            {
                //MessageBox.Show($"Error al obtener datos de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNroDocumento_Leave(object sender, EventArgs e)
        {
            if (txtNroDocumento.Text != "")
            {
                Obtener_Datos_Proveedor_Seleccionado(txtNroDocumento.Text);
            }
        }
        private void btnEditarProv_Click(object sender, EventArgs e)
        {
            CE_Proveedor Req_Proveedor = new CE_Proveedor();
            Req_Proveedor.IdProveedor = Convert.ToInt32(txtIdProveedor.Text.ToString());
            Req_Proveedor.RUC = txtNroDocumento.Text.Trim();
            Req_Proveedor.RazonSocial = txtRazonSocial.Text.Trim();
            Req_Proveedor.Correo = txtCorreo.Text.Trim();
            Req_Proveedor.Telefono = txtTelefono.Text.Trim();

            Int32 Rpt = CL_Proveedor.Instancia.Upd_Proveedor(Req_Proveedor);

            if (Rpt == 1)
            {
                MessageBox.Show("Proveedor actualizado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Nuevo();
                AutocompletarProveedor();
            }
            else
            {
                MessageBox.Show($"Error al registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Nuevo()
        {
            txtIdProveedor.Clear();
            txtNroDocumento.Clear();
            txtRazonSocial.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        private void BtnEliminarProv_Click(object sender, EventArgs e)
        {
            CE_Proveedor Req_Proveeoor = new CE_Proveedor();
            Req_Proveeoor.IdProveedor = Convert.ToInt32(txtIdProveedor.Text.ToString());

            Int32 Rpt = CL_Proveedor.Instancia.Del_Proveedor(Req_Proveeoor);

            if (Rpt == 1)
            {
                MessageBox.Show("Cliente eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Nuevo();
                AutocompletarProveedor();
            }
            else
            {
                MessageBox.Show($"Error al registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
