﻿using System;
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
    public partial class MantenedorHerramientas : Form
    {
        public MantenedorHerramientas()
        {
            InitializeComponent();
        }

        private void MantenedorHerramientas_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BuscarHerramienta buscarHerramienta = new BuscarHerramienta();
            buscarHerramienta.ShowDialog();
        }
    }
}
