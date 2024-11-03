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
    public partial class PanelMenu : Form
    {
        public PanelMenu()
        {
            InitializeComponent();

           
        }
        Panel p=new Panel();
        private void btnMouseEner(object sender,EventArgs e)
        {
            Button btn=sender as Button;
            pMenu.Controls.Add(p);
            p.BackColor = Color.FromArgb(90,210,2);
            p.Size = new Size(226, 98);
            p.Location = new Point(btn.Location.X, btn.Location.Y); 
        }
        private void btnMouseLeave (object sender,EventArgs e)
        {
            pMenu.Controls.Remove(p);
        }

        private void pMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Panonimo.Visible)
            {
                Panonimo.Visible = true;

            }
            else { 
                    Panonimo.Visible=false;
            }
        }
    }
}
