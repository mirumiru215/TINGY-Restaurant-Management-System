﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace RMS_TINGY.AllUserControl
{
    public partial class UC_BillingStatus : UserControl
    {
        SQLControl fn = new SQLControl();
        String query;
        private string _number;

        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }
        public UC_BillingStatus()
        {
            InitializeComponent();
        }

        private void BillingLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon . . .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UC_BillingStatus_Load(object sender, EventArgs e)
        {
            //query = "select * from dishDetails";
            //DataSet ds = fn.getData(query);
            //BillStatusDataView.DataSource = ds.Tables[0];
        }

        private void UC_BillingStatus_Enter(object sender, EventArgs e)
        {
            //query = "select * from dishDetails";
            //DataSet ds = fn.getData(query);
            //BillStatusDataView.DataSource = ds.Tables[0];
        }
        Int64 totalPriceforcloseBill = 0;
        private void UC_BillingStatus_VisibleChanged(object sender, EventArgs e)
        {
            string number = Number;
            tbnlabel.Text = number;
            switch (number)
            {
                case "1":
                    query = "select * from TableBill1";
                    break;
                case "2":
                    query = "select * from TableBill2";
                    break;
                case "3":
                    query = "select * from TableBill3";
                    break;
                case "4":
                    query = "select * from TableBill4";
                    break;
                case "5":
                    query = "select * from TableBill5";
                    break;
                case "6":
                    query = "select * from TableBill6";
                    break;
                default:
                    query = "select * from TableBill1";
                    break;
            }
            DataSet ds = fn.getData(query);
            BillStatusDataView.DataSource = ds.Tables[0];
            BillStatusDataView.Columns[BillStatusDataView.Columns.Count - 5].Visible = false;
            BillStatusDataView.Columns[1].HeaderText = "Name";
            BillStatusDataView.Columns[2].HeaderText = "Amount";
            BillStatusDataView.Columns[3].HeaderText = "Price";
            BillStatusDataView.Columns[4].HeaderText = "MulPrice";

            Int64 totalP = 0;
            foreach (DataGridViewRow row in BillStatusDataView.Rows)
            {
                Int64 price = Convert.ToInt64(row.Cells["dprice"].Value);
                totalP += price;
            }
            totalprice.Text = totalP.ToString();
            totalPriceforcloseBill = totalP;
        }

        private void BillStatusDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string number = Number;
            tbnlabel.Text = number;
            if (MessageBox.Show("Are you sure that you want to close the bill?", "Confirmation",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                DateTime currenttime = DateTime.Now;
                int ngay = currenttime.Day;
                int thang = currenttime.Month;
                int nam = currenttime.Year;
                //query = "insert into statisticBill (tablenumber,totalprice,ngay,thang,nam) values(" + number + "," + totalPriceforcloseBill + "," + ngay + "," + thang + "," + nam + ")";
                //fn.setData(query);
                string query2;
                switch (number)
                {
                    case "1":
                        query2 = "delete  from TableBill1";
                        break;
                    case "2":
                        query2 = "delete from TableBill2";
                        break;
                    case "3":
                        query2 = "delete  from TableBill3";
                        break;
                    case "4":
                        query2 = "delete from TableBill4";
                        break;
                    case "5":
                        query2 = "delete  from TableBill5";
                        break;
                    case "6":
                        query2 = "delete from TableBill6";
                        break;
                    default:
                        query2 = "delete from TableBill1";
                        break;
                }
                query = "insert into statisticBill (tablenumber,totalprice,ngay,thang,nam) values(" + number + "," + totalPriceforcloseBill + "," + ngay + "," + thang + "," + nam + ") " + query2 + "";
                fn.setData(query);
                switch (number)
                {
                    case "1":
                        query = "select * from TableBill1";
                        break;
                    case "2":
                        query = "select * from TableBill2";
                        break;
                    case "3":
                        query = "select * from TableBill3";
                        break;
                    case "4":
                        query = "select * from TableBill4";
                        break;
                    case "5":
                        query = "select * from TableBill5";
                        break;
                    case "6":
                        query = "select * from TableBill6";
                        break;
                    default:
                        query = "select * from TableBill1";
                        break;
                }
                DataSet ds = fn.getData(query);
                BillStatusDataView.DataSource = ds.Tables[0];
            }
        }
    }
}
