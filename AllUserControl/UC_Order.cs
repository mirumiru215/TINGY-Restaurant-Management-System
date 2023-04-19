using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            OrderPanel.Visible = false;
            uC_BillingStatus1.Visible = false;
            uC_AddToBill1.Visible = false;
            btnAddToBill.Visible = false;
            btnBack.Visible = false;
        }

        private void Table_1_Click(object sender, EventArgs e)
        {
            uC_BillingStatus1.Visible = true;
            uC_BillingStatus1.BringToFront();
            btnAddToBill.Visible = true;
        }

        private void btnAddToBill_Click(object sender, EventArgs e)
        {
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
            OrderPanel.Visible = false;
            uC_AddToBill1.Visible = false;
            btnAddToBill.Visible = false;
            btnBack.Visible = false;
        }
    }
}
