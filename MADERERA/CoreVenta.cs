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
    public partial class CoreVenta : Form
    {
        private static List<CE_Usuario> usuarioActual;
        Int32 IdDetalleVenta = 0;
        List<CE_GridDetalleVenta> ListDetalleVenta;
        public CoreVenta(List<CE_Usuario> objusuario = null)
        {
            if (objusuario == null)
                usuarioActual = new List<CE_Usuario>
                {
                    new CE_Usuario { Usuario = "ADMIN PREDEFINIDO" }
                };
            else
                usuarioActual = objusuario;
            InitializeComponent();
            AsignarDatosUsuario();
            Autocompletar_txtProducto();
            ListDetalleVenta = new List<CE_GridDetalleVenta>();
        }

        private void CoreVenta_Load(object sender, EventArgs e)
        {
        }
        private void AsignarDatosUsuario() {
            txtIdUsu.Text = usuarioActual[0].IdUsuario.ToString();
            txtNroDocIdeUsu.Text = usuarioActual[0].NroDocIde;
            txtNombreUsu.Text = usuarioActual[0].Nombre;
            txtCargoUsu.Text = usuarioActual[0].CE_Rol.NombreRol;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            VentaBuscarCliente buscarCliente = new VentaBuscarCliente(this);
            buscarCliente.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            VentaBuscarVendedor buscarvend = new VentaBuscarVendedor();
            buscarvend.ShowDialog();
        }       
        private void button5_Click(object sender, EventArgs e)
        {
            VentaBuscarProducto buscarpro = new VentaBuscarProducto();
            buscarpro.ShowDialog();
        }
        private void Autocompletar_txtProducto()
        {
            try
            {
                AutoCompleteStringCollection ProdCollection = new AutoCompleteStringCollection();
                List<CE_Producto> ListProd = new CL_PRODUCTO().Get_List_Producto(txtProducto.Text);

                if (ListProd.Count > 0)
                {
                    foreach (var Prod in ListProd)
                    {
                        ProdCollection.Add(Prod.NombreProd);
                    }
                    txtProducto.AutoCompleteCustomSource = ProdCollection;
                    txtProducto.AutoCompleteMode = AutoCompleteMode.Suggest;
                    txtProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
                else
                {
                    // Limpiar las sugerencias si no hay resultados
                    txtProducto.AutoCompleteCustomSource.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener sugerencias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Obtener_Datos_Producto_Seleccionado(String NomProducto) {
            Int32 Stock = 0;
            List<CE_Producto> ListProd = new CL_PRODUCTO().Get_List_Producto(NomProducto);
            if (ListProd.Count > 0)
            {
                foreach (var Prod in ListProd)
                {
                    txtIdProducto.Text = Prod.IdProducto.ToString();
                    txtStockProducto.Text = Prod.StockProduc.ToString();
                    txtPrecioProducto.Text = Prod.PrecioProduc.ToString();
                    Stock = Convert.ToInt32(Prod.StockProduc.ToString());
                }
                if (Stock == 0)
                {
                    txtCantidadVenta.Enabled = false;
                    btnAgregarDetalle.Focus();
                }
                else {
                    txtCantidadVenta.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show($"Error al obtener datos de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtProducto_Leave(object sender, EventArgs e)
        {
            Obtener_Datos_Producto_Seleccionado(txtProducto.Text);
        }
        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            Validar_Actualizar_dtgDetalleVenta();
        }
        private void Validar_Actualizar_dtgDetalleVenta()
        {
            if (txtCantidadVenta.Text.ToString() == "")
            {
                MessageBox.Show("Debe ingresar cantidad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool productoExiste = false;
                Decimal Cantidad = Convert.ToInt32(txtCantidadVenta.Text.ToString());
                Decimal SubTotalVenta = Convert.ToDecimal(txtSubtotal.Text.ToString());
                Int32 IdProducto = Convert.ToInt32(txtIdProducto.Text.ToString());
                foreach (DataGridViewRow fila in dtgDetalleVenta.Rows)
                {
                    // Verificar si la fila no es nueva (evitar filas vacías)
                    if (!fila.IsNewRow)
                    {
                        // Comparar el ID del producto (columna 0)
                        if (Convert.ToInt32(fila.Cells[1].Value?.ToString()) == IdProducto)
                        {
                            // Si el producto existe, actualizar el stock
                            fila.Cells[4].Value = Cantidad; // Actualizar la columna "stock" (columna 2)
                            fila.Cells[5].Value = SubTotalVenta; // Actualizar la columna "stock" (columna 2)
                            productoExiste = true;
                            break;
                        }
                    }
                }
                if (!productoExiste)
                {
                    IdDetalleVenta++;
                    CE_GridDetalleVenta _DetalleVenta = new CE_GridDetalleVenta();
                    _DetalleVenta.IdDetalleVenta = IdDetalleVenta;
                    _DetalleVenta.IdProducto = Convert.ToInt32(txtIdProducto.Text.ToString());
                    _DetalleVenta.NombreProducto = txtProducto.Text.ToString();
                    _DetalleVenta.CantidadProducto = Convert.ToInt32(txtCantidadVenta.Text.ToString());
                    _DetalleVenta.PrecioProducto = Convert.ToDecimal(txtPrecioProducto.Text.ToString());
                    _DetalleVenta.SubTotalVenta = Convert.ToDecimal(txtSubtotal.Text.ToString());

                    ListDetalleVenta.Add(_DetalleVenta);

                    CargarDetalleVenta();
                }
                CalcularMontoTotalVenta();
            }
            Limpiar();

        }
        private void CargarDetalleVenta() {
            dtgDetalleVenta.DataSource = null;
            dtgDetalleVenta.DataSource = ListDetalleVenta;
            dtgDetalleVenta.Columns[0].Visible = false;
            dtgDetalleVenta.Columns[1].Visible = false;
        }
        private void CalcularMontoTotalVenta() {
            Decimal TotalVenta = 0;
            foreach (DataGridViewRow fila in dtgDetalleVenta.Rows)
            {
                TotalVenta += Convert.ToInt32(fila.Cells[5].Value?.ToString());
            }
            lblMontoTotalVen.Text = TotalVenta.ToString();
        }
        private void Limpiar() {
            txtIdProducto.Clear();
            txtProducto.Clear();
            txtStockProducto.Clear();
            txtCantidadVenta.Clear();
            txtPrecioProducto.Clear();
            txtSubtotal.Clear();
        }

        private void txtCantidadVenta_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCantidadVenta.Text.ToString() != "") {
                txtSubtotal.Text = (Convert.ToDecimal(txtCantidadVenta.Text.ToString()) * Convert.ToDecimal(txtPrecioProducto.Text)).ToString();
            }
            
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            CE_Venta Req_Venta = new CE_Venta();
            Req_Venta.Cliente.IdCliente = Convert.ToInt32(txtIdClienteBus.Text.ToString()); 
            Req_Venta.CE_Usuario.IdUsuario = Convert.ToInt32(txtIdUsu.Text.ToString());
            Req_Venta.Monto = Convert.ToDecimal(lblMontoTotalVen.Text.ToString());

            Int32 IdVenta = CL_VENTA.Instancia.Ins_Venta(Req_Venta);

            foreach (DataGridViewRow fila in dtgDetalleVenta.Rows)
            {
                CE_DetalleVenta Req_DetalleVenta = new CE_DetalleVenta();
                // Verificar si la fila no es nueva (evitar filas vacías)
                if (!fila.IsNewRow)
                {
                    Req_DetalleVenta.IdDetalleVenta = Convert.ToInt32(fila.Cells[0].Value?.ToString());
                    Req_DetalleVenta.CE_Venta.IdVenta = IdVenta;
                    Req_DetalleVenta.CE_Producto.IdProducto = Convert.ToInt32(fila.Cells[1].Value?.ToString());
                    Req_DetalleVenta.PrecioDetVenta = Convert.ToDecimal(fila.Cells[3].Value?.ToString());
                    Req_DetalleVenta.CantidadVenta = Convert.ToInt32(fila.Cells[4].Value?.ToString());

                    CL_DetalleVenta.Instancia.Ins_DetalleVenta(Req_DetalleVenta);
                }
            }


        }
    }
}
