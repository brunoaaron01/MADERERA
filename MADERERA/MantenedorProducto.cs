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
using System.Windows.Controls;
using System.Windows.Forms;

namespace CAPAPRESENTACION
{
    public partial class MantenedorProducto : Form
    {
        public MantenedorProducto()
        {
            InitializeComponent();
            Autocompletar_txtProducto();
        }
        private void MantenedorProducto_Load(object sender, EventArgs e)
        {
            Load_cboTipoProducto();
        }
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            VentaBuscarProducto buscarProducto = new VentaBuscarProducto();
            buscarProducto.ShowDialog();
        }

        private void btnMantTipoProd_Click(object sender, EventArgs e)
        {
            MantenedorTipoProducto MantTipoProducto = new MantenedorTipoProducto();
            MantTipoProducto.ShowDialog();
        }
        private void Load_cboTipoProducto() {
            var desc = "";
            DataTable dtTipoProd = new CL_TipoProducto().Get_dt_TipoProducto(desc);

            DataRow RowSeleccionar = dtTipoProd.NewRow();
            RowSeleccionar["IDTIPOPRODUC"] = 0;
            RowSeleccionar["DESCRIPCION"] = "Seleccionar";
            dtTipoProd.Rows.InsertAt(RowSeleccionar, 0);

            cboTipoProducto.ValueMember = "IDTIPOPRODUC";
            cboTipoProducto.DisplayMember = "DESCRIPCION";
            cboTipoProducto.DataSource = dtTipoProd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CE_Producto Req_Producto = new CE_Producto();
            Req_Producto.NombreProd = txtNomProducto.Text.Trim();
            Req_Producto.DescriProd = txtDescProd.Text.Trim();
            Req_Producto.StockProduc = Convert.ToInt32(txtStock.Text.Trim());
            Req_Producto.PrecioProduc = Convert.ToDecimal(txtPrecioProd.Text.Trim());
            Req_Producto.CE_TipoProducto.IdTipoProd = Convert.ToInt32(cboTipoProducto.SelectedValue.ToString());

            Int32 Rpt = CL_PRODUCTO.Instancia.Ins_Producto(Req_Producto);

            if (Rpt == 1)
            {
                MessageBox.Show("Producto registrado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomProducto.Text = "";
                txtDescProd.Text = "";
                txtStock.Text = "";
                txtPrecioProd.Text = "";
                cboTipoProducto.SelectedValue = 0;
            }
            else {
                MessageBox.Show($"Error al registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Autocompletar_txtProducto()
        {
            try
            {
                AutoCompleteStringCollection ProdCollection = new AutoCompleteStringCollection();
                List<CE_Producto> ListProd = new CL_PRODUCTO().Get_List_Producto(txtNomProducto.Text);

                if (ListProd.Count > 0)
                {
                    foreach (var Prod in ListProd)
                    {
                        ProdCollection.Add(Prod.NombreProd);
                    }
                    txtNomProducto.AutoCompleteCustomSource = ProdCollection;
                    txtNomProducto.AutoCompleteMode = AutoCompleteMode.Suggest;
                    txtNomProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
                else
                {
                    // Limpiar las sugerencias si no hay resultados
                    txtNomProducto.AutoCompleteCustomSource.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener sugerencias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Obtener_Datos_Producto_Seleccionado(String NomProducto)
        {
            List<CE_Producto> ListProd = new CL_PRODUCTO().Get_List_Producto(NomProducto);
            if (ListProd.Count > 0)
            {
                foreach (var Prod in ListProd)
                {
                    txtIdProducto.Text = Prod.IdProducto.ToString();
                    txtNomProducto.Text = Prod.NombreProd.ToString();
                    cboTipoProducto.SelectedIndex = Convert.ToInt32(Prod.CE_TipoProducto.IdTipoProd.ToString());
                    txtDescProd.Text = Prod.DescriProd.ToString();
                    txtStock.Text = Prod.StockProduc.ToString();
                    txtPrecioProd.Text = Prod.PrecioProduc.ToString();
                }
                btnEditarProducto.Visible = true;

            }
            else
            {
                MessageBox.Show($"Error al obtener datos de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNomProducto_Leave(object sender, EventArgs e)
        {
            Obtener_Datos_Producto_Seleccionado(txtNomProducto.Text);
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            CE_Producto Req_Producto = new CE_Producto();
            Req_Producto.IdProducto = Convert.ToInt32(txtIdProducto.Text.Trim());
            Req_Producto.DescriProd = txtDescProd.Text.Trim();
            Req_Producto.PrecioProduc = Convert.ToDecimal(txtPrecioProd.Text.Trim());
            Req_Producto.CE_TipoProducto.IdTipoProd = Convert.ToInt32(cboTipoProducto.SelectedValue.ToString());

            Int32 Rpt = CL_PRODUCTO.Instancia.Upd_Producto(Req_Producto);

            if (Rpt == 1)
            {
                MessageBox.Show("Producto actualizado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomProducto.Clear();
                txtDescProd.Clear();
                txtStock.Clear();
                txtPrecioProd.Clear();
                txtIdProducto.Clear();
                cboTipoProducto.SelectedValue = 0;
            }
            else
            {
                MessageBox.Show($"Error al registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
