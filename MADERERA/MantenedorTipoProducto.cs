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
    public partial class MantenedorTipoProducto : Form
    {
        public MantenedorTipoProducto()
        {
            InitializeComponent();
        }

        private void MantenedorTipoProducto_Load(object sender, EventArgs e)
        {
            Autocompletar_txtDescTipoProd();
            List_TipoProducto();
        }
        private void List_TipoProducto() {
            List<CE_TipoProducto> ListTipoProd = new CL_TipoProducto().Get_List_TipoProducto(txtDescTipoProd.Text);
            dataGridView1.DataSource = ListTipoProd;
        }
        private void Autocompletar_txtDescTipoProd() {
            try
            {
                AutoCompleteStringCollection TipoProdCollection = new AutoCompleteStringCollection();
                List<CE_TipoProducto> ListTipoProd = new CL_TipoProducto().Get_List_TipoProducto(txtDescTipoProd.Text);
                
                if (ListTipoProd.Count > 0)
                {
                    foreach (var tipoProd in ListTipoProd)
                    {
                        TipoProdCollection.Add(tipoProd.Descripcion);
                    }
                    txtDescTipoProd.AutoCompleteCustomSource = TipoProdCollection;
                    txtDescTipoProd.AutoCompleteMode = AutoCompleteMode.Suggest;
                    txtDescTipoProd.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
                else
                {
                    // Limpiar las sugerencias si no hay resultados
                    txtDescTipoProd.AutoCompleteCustomSource.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener sugerencias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRegistrarTipProd_Click(object sender, EventArgs e)
        {
            CE_TipoProducto Req_TipoProducto = new CE_TipoProducto();
            Req_TipoProducto.Descripcion = txtDescTipoProd.Text;
            Req_TipoProducto.FecRegTipoProd = DateTime.Now;
            Int32 Rpta = CL_TipoProducto.Instancia.Ins_TipoProducto(Req_TipoProducto);
            if (Rpta == 1)
            {
                MessageBox.Show($"Tipo de producto registrado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescTipoProd.Text = "";
                List_TipoProducto();
            }
            else {
                MessageBox.Show($"Error al registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
