using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace POS_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Pen LinePenelMenu = new Pen(Color.Gray);
            float x1 = 10.0F, y1 = 150.0F;
            float x2 = 220.0F, y2 = 150.0F;
            e.Graphics.DrawLine(LinePenelMenu, x1, y1, x2, y2);
            LinePenelMenu.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }
    }
}
