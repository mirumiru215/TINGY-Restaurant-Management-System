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
        SQLControl fn = new SQLControl();
        String query;
        public UC_Menu()
        {
            InitializeComponent();
        }

        private void UC_Menu_Load(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            uC_Add1.Visible = false;
            MenuPanel.Visible = true;
            //query = "select * from dishDetails";
            //DataSet ds = fn.getData(query);
            //MenuDataView.DataSource = ds.Tables[0];
            //MenuDataView.Columns[MenuDataView.Columns.Count - 1].Visible = false;
            //MenuDataView.Columns[0].HeaderText = "ID";
            //MenuDataView.Columns[1].HeaderText = "Name";
            //MenuDataView.Columns[2].HeaderText = "Type";
            //MenuDataView.Columns[3].HeaderText = "Ingredient";
            //MenuDataView.Columns[4].HeaderText = "Servable Time";
            //MenuDataView.Columns[5].HeaderText = "Price";

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
            //query = "select * from dishDetails";
            //DataSet ds = fn.getData(query);
            //MenuDataView.DataSource = ds.Tables[0];
            //MenuDataView.Columns[MenuDataView.Columns.Count - 1].Visible = false;
            //MenuDataView.Columns[0].HeaderText = "ID";
            //MenuDataView.Columns[1].HeaderText = "Name";
            //MenuDataView.Columns[2].HeaderText = "Type";
            //MenuDataView.Columns[3].HeaderText = "Ingredient";
            //MenuDataView.Columns[4].HeaderText = "Servable Time";
            //MenuDataView.Columns[5].HeaderText = "Price";
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
