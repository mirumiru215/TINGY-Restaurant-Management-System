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
    public partial class UC_AddToBill : UserControl
    {
        SQLControl fn = new SQLControl();
        String query;
        public UC_AddToBill()
        {
            InitializeComponent();
        }

        private void UC_AddToBill_Enter(object sender, EventArgs e)
        {
            query = "select * from dishDetails";
            DataSet ds = fn.getData(query);
            AddToBillDataView.DataSource = ds.Tables[0];
            AddToBillDataView.Columns[AddToBillDataView.Columns.Count - 1].Visible = false;

        }
        int bid;
        private void AddToBillDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AddToBillDataView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(AddToBillDataView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            query = "select * from dishDetails where mid = " + bid + "";
            DataSet ds = fn.getData(query);
            namelabel.Text = ds.Tables[0].Rows[0][1].ToString();
            pricelabel.Text = ds.Tables[0].Rows[0][5].ToString();

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
}
