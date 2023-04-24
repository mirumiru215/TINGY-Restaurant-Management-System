using System;
using System.Collections;
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
    public partial class UC_Menu : UserControl
    {
        public UC_Menu()
        {
            InitializeComponent();
        }

        private void UC_Menu_Load(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            uC_Add1.Visible = false;
            uC_Homepage1.Visible = true;
            uC_Homepage1.BringToFront();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnBack.Visible = true;
            btnAdd.Visible = false;
            MenuPanel.Visible = false;
            uC_Add1.Visible =true;
            uC_Add1.BringToFront();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            btnBack.Visible = false;
            uC_Add1.Visible = false;
            MenuPanel.Visible = false;
            MenuPanel.Visible = true;
            MenuPanel.BringToFront();
        }

        private void UC_Menu_Enter(object sender, EventArgs e)
        {
        }

        private void MenuPanel_Enter(object sender, EventArgs e)
        {

        }

        private void MenuDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void funcPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
