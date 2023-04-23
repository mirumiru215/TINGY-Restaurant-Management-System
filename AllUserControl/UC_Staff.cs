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
    public partial class UC_Staff : UserControl
    {
        public UC_Staff()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            uC_StaffAddEmployee1.Visible = true;
            btnBack.Visible = true;
            uC_StaffAddEmployee1.BringToFront();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            uC_StaffAddEmployee1.Visible=false;
            uC_StaffInfo1.Visible=false;
            uC_StaffWorkCount1.Visible=false;
            btnBack.Visible=false;
        }

        private void UC_Staff_Load(object sender, EventArgs e)
        {
            uC_StaffAddEmployee1.Visible = false;
            uC_StaffInfo1.Visible = false;
            btnBack.Visible = false;
            uC_StaffWorkCount1.Visible = false;
        }

        private void btnStaffInfo_Click(object sender, EventArgs e)
        {
            uC_StaffInfo1.Visible = true;
            uC_StaffInfo1.BringToFront();
            btnBack.Visible = true;
        }

        private void btnWorkSched_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon . . .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCntWrkday_Click(object sender, EventArgs e)
        {
            uC_StaffWorkCount1.Visible = true;
            uC_StaffWorkCount1.BringToFront();
            btnBack.Visible = true;
        }
    }
}
