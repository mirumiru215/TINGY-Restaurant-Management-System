using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace RMS_TINGY.AllUserControl
{
    public partial class UC_Order : UserControl
    {
        public UC_Order()
        {
            InitializeComponent();
        }

        private void UC_Order_Load(object sender, EventArgs e)
        {
            btnRefresh.Visible = false;
            OrderPanel.Visible = false;
            uC_BillingStatus1.Visible = false;
            uC_AddToBill1.Visible = false;
            btnAddToBill.Visible = false;
            btnBack.Visible = false;
        }

        private void Table_1_Click(object sender, EventArgs e)
        {
            uC_BillingStatus1.Number ="1";
            uC_AddToBill1.tableNumber = "1";
            uC_BillingStatus1.Visible = false;
            uC_BillingStatus1.Visible = true;
            uC_BillingStatus1.BringToFront();
            btnAddToBill.Visible = true;
            btnRefresh.Visible = false;
        }

        private void btnAddToBill_Click(object sender, EventArgs e)
        {
            btnRefresh.Visible = true;
            OrderPanel.Visible = true;
            uC_AddToBill1.Visible = true;
            uC_AddToBill1.BringToFront();
            btnAddToBill.Visible = false;
            btnBack.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //uC_BillingStatus1.Visible = false;
            uC_BillingStatus1.Visible = false;
            uC_BillingStatus1.Visible = true;
            OrderPanel.Visible = false;
            uC_AddToBill1.Visible = false;
            btnAddToBill.Visible = false;
            btnBack.Visible = false;
            btnRefresh.Visible = false;
        }

        private void Table_2_Click(object sender, EventArgs e)
        {
            uC_BillingStatus1.Number = "2";
            uC_AddToBill1.tableNumber = "2";
            uC_BillingStatus1.Visible = false;
            uC_BillingStatus1.Visible = true;
            uC_BillingStatus1.BringToFront();
            btnAddToBill.Visible = true;
            btnRefresh.Visible = false;
        }

        private void Table_3_Click(object sender, EventArgs e)
        {
            uC_BillingStatus1.Number = "3";
            uC_AddToBill1.tableNumber = "3";
            uC_BillingStatus1.Visible = false;
            uC_BillingStatus1.Visible = true;
            uC_BillingStatus1.BringToFront();
            btnAddToBill.Visible = true;
            btnRefresh.Visible = false;
        }

        private void Table_4_Click(object sender, EventArgs e)
        {
            uC_BillingStatus1.Number = "4";
            uC_AddToBill1.tableNumber = "4";
            uC_BillingStatus1.Visible = false;
            uC_BillingStatus1.Visible = true;
            uC_BillingStatus1.BringToFront();
            btnAddToBill.Visible = true;
            btnRefresh.Visible = false;
        }

        private void Table_5_Click(object sender, EventArgs e)
        {
            uC_BillingStatus1.Number = "5";
            uC_AddToBill1.tableNumber = "5";
            uC_BillingStatus1.Visible = false;
            uC_BillingStatus1.Visible = true;
            uC_BillingStatus1.BringToFront();
            btnAddToBill.Visible = true;
            btnRefresh.Visible = false;
        }

        private void Table_6_Click(object sender, EventArgs e)
        {
            uC_BillingStatus1.Number = "6";
            uC_AddToBill1.tableNumber = "6";
            uC_BillingStatus1.Visible = false;
            uC_BillingStatus1.Visible = true;
            uC_BillingStatus1.BringToFront();
            btnAddToBill.Visible = true;
            btnRefresh.Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            uC_BillingStatus1.Visible = false;
            uC_BillingStatus1.Visible = true;
        }

        private void uC_BillingStatus1_Load(object sender, EventArgs e)
        {

        }
    }
}
