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
    public partial class MantenedorDetalleVenta : Form
    {
        List<CE_GridDetalleVenta> Lst_GridDetalleVenta;
        public MantenedorDetalleVenta()
        {
            InitializeComponent();
            Lst_GridDetalleVenta = new List<CE_GridDetalleVenta>();
        }

        private void btnBuscarDetalle_Click(object sender, EventArgs e)
        {
            Int32 IdVenta = Convert.ToInt32(txtIdVenta.Text.ToString());
            List<CE_DetalleVenta> Lst_DetalleVenta = CL_DetalleVenta.Instancia.List_DetalleVenta_IdVenta(IdVenta);
            if (Lst_DetalleVenta.Count > 0)
            {
                txtNroDocIdeCliente.Text = Lst_DetalleVenta[0].CE_Cliente.DNI.ToString();
                txtNombreCliente.Text = Lst_DetalleVenta[0].CE_Cliente.NombreCli.ToString();
            
                foreach (var Prod in Lst_DetalleVenta)
                {
                    CE_GridDetalleVenta _DetalleVenta = new CE_GridDetalleVenta();
                    _DetalleVenta.IdDetalleVenta = Prod.IdDetalleVenta;
                    _DetalleVenta.NombreProducto = Prod.CE_Producto.NombreProd;
                    _DetalleVenta.PrecioProducto = Prod.PrecioDetVenta;
                    _DetalleVenta.CantidadProducto = Prod.CantidadVenta;
                    Lst_GridDetalleVenta.Add(_DetalleVenta);
                }
                CargarDetalleVenta();

            }
            else
            {
                MessageBox.Show("No existe venta con ese codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdVenta.Clear();
            }
        }
        private void CargarDetalleVenta()
        {
            dtgDetalleVenta.DataSource = null;
            dtgDetalleVenta.DataSource = Lst_GridDetalleVenta;
            dtgDetalleVenta.Columns[0].Visible = false;
            dtgDetalleVenta.Columns[1].Visible = false;
            dtgDetalleVenta.Columns[5].Visible = false;
        }
    }
}
