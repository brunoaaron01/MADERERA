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
        public class ComboBoxItem {
            public String Text { get; set; }
            public Int32 Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
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
    }
}
