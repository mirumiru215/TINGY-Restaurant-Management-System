using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace RMS_TINGY.AllUserControl
{

    public partial class UC_Homepage : UserControl
    {
        SQLControl fn = new SQLControl();
        String query;

        public UC_Homepage()
        {
            InitializeComponent();
        }
        private void UC_Homepage_Load(object sender, EventArgs e)
        {
            query = "select * from dishDetails";
            DataSet ds = fn.getData(query);
            MenuGridDataView.DataSource = ds.Tables[0];
            MenuGridDataView.Columns[MenuGridDataView.Columns.Count - 1].Visible = false;
            MenuGridDataView.Columns[0].HeaderText = "ID"; 
            MenuGridDataView.Columns[1].HeaderText = "Name"; 
            MenuGridDataView.Columns[2].HeaderText = "Type"; 
            MenuGridDataView.Columns[3].HeaderText = "Ingredient"; 
            MenuGridDataView.Columns[4].HeaderText = "Servable Time"; 
            MenuGridDataView.Columns[5].HeaderText = "Price"; 
        }

        int bid;
        private void MenuGridDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0 && e.ColumnIndex >=0 && MenuGridDataView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(MenuGridDataView.Rows[e.RowIndex].Cells[0].Value.ToString());

                query = "select * from dishDetails where mid = " + bid + "";
                DataSet ds = fn.getData(query);
                labelNameDisplay.Text = ds.Tables[0].Rows[0][1].ToString();
                labelTypeDisplay.Text = ds.Tables[0].Rows[0][2].ToString();
                labelIngreDisplay.Text = ds.Tables[0].Rows[0][3].ToString();
                labelTimeDisplay.Text = ds.Tables[0].Rows[0][4].ToString();
                labelPriceDisplay.Text = ds.Tables[0].Rows[0][5].ToString();
                byte[] picture = (byte[])ds.Tables[0].Rows[0][6];
                if (picture == null)
                {
                    picsDisplay.Image = null;
                }
                else
                {
                    MemoryStream mstream = new MemoryStream(picture);
                    picsDisplay.Image = Image.FromStream(mstream);
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Search by name" || searchTextBox.Text == "")
            {
                searchTextBox.Text = "Search by name";
                query = "select * from dishDetails";
                DataSet ds = fn.getData(query);
                MenuGridDataView.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select * from dishDetails where cname like '" + searchTextBox.Text + "%'";
                DataSet ds = fn.getData(query);
                MenuGridDataView.DataSource = ds.Tables[0];
            }
        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = string.Empty;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            query = "select * from dishDetails where cname like '" + searchTextBox.Text + "%'";
            DataSet ds = fn.getData(query);
            MenuGridDataView.DataSource = ds.Tables[0];
        }

        private void UC_Homepage_Click(object sender, EventArgs e)
        {
           //searchTextBox.Text = "Search by name";
        }
    }
}
