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
        public bool admin = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            uC_Menu1.reset();
            uC_Order1.Visible = false;
            uC_Staff1.Visible = false;
            uC_Statistic1.Visible = false;
            uC_Menu1.Visible = true;
            uC_Menu1.BringToFront();
            
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            if (admin == false)
            {
                MessageBox.Show("You can't access this!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                uC_Menu1.Visible = false;
                uC_Order1.Visible = false;
                uC_Staff1.Visible = false;
                uC_Statistic1.Visible = false;
                uC_Statistic1.Visible = true;
                uC_Statistic1.BringToFront();
            } 
        }
        
        private void btnOrder_Click(object sender, EventArgs e)
        {
            uC_Order1.reset();
            uC_Menu1.Visible = false;
            uC_Order1.Visible = false;
            uC_Staff1.Visible = false;
            uC_Statistic1.Visible = false;

            uC_Order1.Visible = true;
            uC_Order1.BringToFront();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            if (admin == false)
            {
                MessageBox.Show("You can't access this!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                uC_Staff1.reset();
                uC_Menu1.Visible = false;
                uC_Order1.Visible = false;
                uC_Staff1.Visible = false;
                uC_Statistic1.Visible = false;
                uC_Staff1.Visible = true;
                uC_Staff1.BringToFront();
            }    
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnexitnum2.Visible = true;
            sidebarPanel.Visible = false;
            uC_Menu1.Visible = true;
            uC_Order1.Visible = false;
            uC_Staff1.Visible = false;
            uC_Statistic1.Visible = false;
        }

        private void uC_Login1_VisibleChanged(object sender, EventArgs e)
        {
            if (!uC_Login1.Visible) {
                sidebarPanel.Visible = true;
                admin = uC_Login1.adminaccess;
                btnexitnum2.Visible = false;
                if (admin == true)
                {
                    btnMenu.PerformClick();
                    uC_Menu1.adminmenu = true;
                    usernamelabel.Text = "Admin";
                }
                else
                {
                    btnOrder.PerformClick();
                    uC_Menu1.adminmenu = false;
                    usernamelabel.Text = "Staff";
                }
            }
        }

        private void btnexitnum2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            uC_Menu1.reset();
            admin = false;
            uC_Login1.Visible = true;
            uC_Login1.BringToFront();
            sidebarPanel.Visible =false;
            btnexitnum2.Visible = true;
            btnexitnum2.BringToFront();
            
        }

    }
}
