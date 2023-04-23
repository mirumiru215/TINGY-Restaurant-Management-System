using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RMS_TINGY.AllUserControl
{
    public partial class UC_StaffWorkCount : UserControl
    {
        SQLControl fn = new SQLControl();
        String query;
        public UC_StaffWorkCount()
        {
            InitializeComponent();
        }

        private void StaffWCGridDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_StaffWorkCount_Load(object sender, EventArgs e)
        {
            query = "select * from staffDetails";
            DataSet ds = fn.getData(query);
            StaffWCGridDataView.DataSource = ds.Tables[0];
            StaffWCGridDataView.Columns[StaffWCGridDataView.Columns.Count - 1].Visible = false;
            StaffWCGridDataView.Columns[0].HeaderText = "ID";
            StaffWCGridDataView.Columns[1].HeaderText = "Name";
            StaffWCGridDataView.Columns[5].HeaderText = "Work Count";
            StaffWCGridDataView.Columns[6].HeaderText = "Salary";
        }
        int bid;
        Int64 salaryperhour;
        private void StaffWCGridDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && StaffWCGridDataView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(StaffWCGridDataView.Rows[e.RowIndex].Cells[0].Value.ToString());

                query = "select * from staffDetails where staffid = " + bid + "";
                DataSet ds = fn.getData(query);
                namelabeld.Text = ds.Tables[0].Rows[0][1].ToString();
                wclabel.Text = ds.Tables[0].Rows[0][5].ToString();
                labelwc.Text = wclabel.Text;
                labelsph.Text = ds.Tables[0].Rows[0][6].ToString();
                labelsalary.Text = (Int64.Parse(labelwc.Text) * Int64.Parse(labelsph.Text)).ToString();
                byte[] picture = (byte[])ds.Tables[0].Rows[0][7];
                String position = ds.Tables[0].Rows[0][4].ToString();
                switch (position)
                {
                    case "Chef":
                        salaryperhour = 100000;
                        break;
                    case "Waiter":
                        salaryperhour = 70000;
                        break;
                    case "Busser":
                        salaryperhour = 50000;
                        break;
                    case "Laborer":
                        salaryperhour = 30000;
                        break;
                    default:
                        salaryperhour = 20000;
                        break;
                }
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

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Int64 temp = Int64.Parse(wclabel.Text);
            temp++;
            wclabel.Text = temp.ToString();
            labelwc.Text = wclabel.Text;
            labelsalary.Text = (Int64.Parse(labelwc.Text) * salaryperhour).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Int64 temp = int.Parse(wclabel.Text);
            temp--;
            wclabel.Text = temp.ToString();
            labelwc.Text = wclabel.Text;
            labelsalary.Text = (Int64.Parse(labelwc.Text) * salaryperhour).ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Int64.Parse(wclabel.Text) >= 1)
            {
                Int64 workcount = Int64.Parse(wclabel.Text);
                Int64 salary = Int64.Parse(labelsalary.Text);
                query = "update staffDetails set workcount = " + workcount + ", salary =" + salary + " where staffid = " + bid + "";
                fn.setData(query); 
                //query = "update staffDetails set salary = " + salary + " where staffid = " + bid + "";
                //fn.setData(query);
            }
            else if (Int64.Parse(wclabel.Text) == 0)
            {
                MessageBox.Show("Nothing changed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid WorkCount.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }
    }
}
