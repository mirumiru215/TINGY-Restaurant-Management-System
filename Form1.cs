using RMS_TINGY.AllUserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_TINGY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UCPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void functionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            uC_Menu1.Visible = true;
            uC_Menu1.BringToFront();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            uC_Order1.Visible = true;
            uC_Order1.BringToFront();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            uC_Staff1.Visible = true;
            uC_Staff1.BringToFront(); 
        }

        private void uC_Menu1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uC_Menu1.Visible = true;
            uC_Order1.Visible = false;
            uC_Staff1.Visible = false;
        }

        private void uC_Order1_Load(object sender, EventArgs e)
        {

        }
    }
}
