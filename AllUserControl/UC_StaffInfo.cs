using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_TINGY.AllUserControl
{
    public partial class UC_StaffInfo : UserControl
    {
        SQLControl fn = new SQLControl();
        String query;
        public UC_StaffInfo()
        {
            InitializeComponent();
        }

        private void StaffGridDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_StaffInfo_Load(object sender, EventArgs e)
        {
            searchTextBox.Text = "Search by name";
            query = "select * from staffDetails";
            DataSet ds = fn.getData(query);
            StaffGridDataView.DataSource = ds.Tables[0];
            StaffGridDataView.Columns[StaffGridDataView.Columns.Count - 1].Visible = false;
            StaffGridDataView.Columns[0].HeaderText = "ID";
            StaffGridDataView.Columns[1].HeaderText = "Name";
            StaffGridDataView.Columns[2].HeaderText = "D.O.B";
            StaffGridDataView.Columns[3].HeaderText = "Phone Number";
            StaffGridDataView.Columns[4].HeaderText = "Position";
            StaffGridDataView.Columns[5].HeaderText = "Work Count";
            StaffGridDataView.Columns[6].HeaderText = "Salary";
        }
        int bid;
        private void StaffGridDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && StaffGridDataView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(StaffGridDataView.Rows[e.RowIndex].Cells[0].Value.ToString());

                query = "select * from staffDetails where staffid = " + bid + "";
                DataSet ds = fn.getData(query);
                namelabeld.Text = ds.Tables[0].Rows[0][1].ToString();
                domlabeld.Text = ds.Tables[0].Rows[0][2].ToString();
                phonelabeld.Text = ds.Tables[0].Rows[0][3].ToString();
                positionlabeld.Text = ds.Tables[0].Rows[0][4].ToString();

                byte[] picture = (byte[])ds.Tables[0].Rows[0][7];
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
                query = "select * from staffDetails";
                DataSet ds = fn.getData(query);
                StaffGridDataView.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select * from staffDetails where sname like '" + searchTextBox.Text + "%'";
                DataSet ds = fn.getData(query);
                StaffGridDataView.DataSource = ds.Tables[0];
            }
        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = string.Empty;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            query = "select * from staffDetails where sname like '" + searchTextBox.Text + "%'";
            DataSet ds = fn.getData(query);
            StaffGridDataView.DataSource = ds.Tables[0];
        }
    }
}
