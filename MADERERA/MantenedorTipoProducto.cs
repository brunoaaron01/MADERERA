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
        }
        private void Autocompletar_txtDescTipoProd() {
            if (txtDescTipoProd.Text.Length >= 2)
            {
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
        }
        private void txtDescTipoProd_TextChanged(object sender, EventArgs e)
        {
            Autocompletar_txtDescTipoProd();
        }
    }
}
