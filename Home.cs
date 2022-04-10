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
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelSubAdmin.Visible = false;
            panelSubCustomer.Visible = false;
            panelSubItem.Visible = false;
            panelSubReport.Visible = false;
        }
        private void hideSubPannel()
        {
            if (panelSubAdmin.Visible == true)
                panelSubAdmin.Visible = false;
            if (panelSubCustomer.Visible == true)
                panelSubCustomer.Visible = false;
            if (panelSubItem.Visible == true)
                panelSubItem.Visible = false;
            if (panelSubReport.Visible == true)
                panelSubReport.Visible = false;
        }
        private void showSubPanel(Panel subPanel)
        {
            if (subPanel.Visible == false)
            {
                hideSubPannel();
                subPanel.Visible = true;
            }
            else
                subPanel.Visible = false;
                
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void PannelUser_Paint(object sender, PaintEventArgs e)
        {
            Pen LinePenelMenu = new Pen(Color.Gray);
            float x1 = 10.0F, y1 = 115.0F;
            float x2 = 230.0F, y2 = 115.0F;
            e.Graphics.DrawLine(LinePenelMenu, x1, y1, x2, y2);
            LinePenelMenu.Dispose();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            showSubPanel(panelSubAdmin);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            showSubPanel(panelSubItem);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            showSubPanel(panelSubCustomer);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            showSubPanel(panelSubReport);
        }
        private Form activeForm = null;
        private void openFunctionForm(Form functionForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = functionForm;
            functionForm.TopLevel = false;
            functionForm.FormBorderStyle = FormBorderStyle.None;
            panelFunctionForm.Controls.Add(functionForm);
            panelFunctionForm.Tag = functionForm;
            functionForm.BringToFront();
            functionForm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openFunctionForm(new Users());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }
    }
}
