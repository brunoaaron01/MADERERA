using CAPADEENTIDAD;
using CAPADELOGICA;
using CAPAPRESENTACION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MADERERA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            EntUsuarios ousuario = new LogUsuarios().ListarUsuarios().Where(u => u.Dni == textBox2.Text && u.Clave == txtContraseña.Text).FirstOrDefault();


            if (ousuario != null)
            {

                PresentacionMenu pm = new PresentacionMenu(ousuario);
                this.Hide();
                pm.Show();

                pm.FormClosing += frm_closing;

            }
            else
            {
                MessageBox.Show("no se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void frm_closing(object sender, FormClosingEventArgs e)
        {

            textBox2.Text = "";
            txtContraseña.Text = "";
            this.Show();
        }
    }
}
