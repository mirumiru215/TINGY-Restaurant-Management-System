using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Media;

namespace RMS_TINGY.AllUserControl
{
    public partial class UC_Statistic : UserControl
    {
        SQLControl fn = new SQLControl();
        String query;
        public UC_Statistic()
        {
            InitializeComponent();
        }

        private void Statictis_Day(object sender, EventArgs e)
        {
            chartDay.Visible = true;
            chartDay.BringToFront();
            chartDay.Series.Clear();
            chartDay.Series.Add("Total Revenue Per Day");

            DateTime currentTime = DateTime.Now;
            int firstDayofcurrentWeek = currentTime.Day - 6;
            int runner1 = firstDayofcurrentWeek;
            int runner2 = firstDayofcurrentWeek;

            query = "select * from statisticBill";
            DataSet ds = fn.getData(query);

            DataTable mainTable = ds.Tables[0];
            DataTable subTable = mainTable.Clone();
            int currentMonth = currentTime.Month;
            int currentYear = currentTime.Year;
            DataRow[] rows = mainTable.Select("thang = " + currentMonth.ToString() + " AND nam = " + currentYear.ToString() + "");
            foreach (DataRow row in rows)
            {
                subTable.ImportRow(row);
            }

            DataView dataView = subTable.DefaultView;
            dataView.Sort = "ngay DESC";
            DataTable sortedTable = dataView.ToTable();
            Int64[] doanhthu = new Int64[7];
            for (int i = 0; i < 7; i++)
            {
                foreach (DataRow row in sortedTable.Rows)
                {
                    if (Convert.ToInt64(row["ngay"]) == runner1)
                    {
                        doanhthu[i] += Convert.ToInt64(row["totalprice"]);
                    }
                }
                runner1++;
            }

            for (int i = 0; i < 7; i++, runner2++)
            {
                string temp = runner2.ToString();
                chartDay.Series["Total Revenue Per Day"].Points.AddXY(temp, doanhthu[i]);
            }
            textToday.Text = doanhthu[6].ToString();
        }

        private void Statictis_Month(object sender, EventArgs e)
        {
            chartMonth.Visible = true;
            chartMonth.BringToFront();
            chartMonth.Series.Clear();
            chartMonth.Series.Add("Total Revenue Per Month");

            DateTime currentTime = DateTime.Now;
            int curentYear = currentTime.Year;

            query = "select * from statisticBill";
            DataSet ds = fn.getData(query);

            DataTable mainTable = ds.Tables[0];
            DataTable subTable = mainTable.Clone();
            DataRow[] rows = mainTable.Select("nam = " + curentYear.ToString() + "");
            foreach (DataRow row in rows)
            {
                subTable.ImportRow(row);
            }

            DataView dataView = subTable.DefaultView;
            dataView.Sort = "thang ASC";
            DataTable sortedTable = dataView.ToTable();
            Int64[] doanhthu = new Int64[12];
            for (int i = 1; i < 13; i++)
            {
                foreach (DataRow row in sortedTable.Rows)
                {
                    if (Convert.ToInt64(row["thang"]) == i)
                    {
                        doanhthu[i-1] += Convert.ToInt64(row["totalprice"]);
                    }
                }
            }
            Int64 totalre = 0;
            for (int i = 1; i <= currentTime.Month; i++)
            {
                string temp = i.ToString();
                chartMonth.Series["Total Revenue Per Month"].Points.AddXY(temp, doanhthu[i-1]);
                totalre += doanhthu[i - 1];
            }
            textMonth.Text = doanhthu[currentTime.Month-1].ToString();
            textYear.Text = totalre.ToString();
        }

        private void UC_Statistic_Load(object sender, EventArgs e)
        {
            Statictis_Day(sender, e);
            Statictis_Month(sender,e);
            DateTime current = DateTime.Now;
            chartmonthlabel.Text += current.Year.ToString();
            switch (current.Month)
            {
                case 1:
                    chartdaylabel.Text += "January";
                    break;
                case 2:
                    chartdaylabel.Text += "February";
                    break;
                case 3:
                    chartdaylabel.Text += "March";
                    break;
                case 4:
                    chartdaylabel.Text += "April";
                    break;
                case 5:
                    chartdaylabel.Text += "May";
                    break;
                case 6:
                    chartdaylabel.Text += "June";
                    break;
                case 7:
                    chartdaylabel.Text += "July";
                    break;
                case 8:
                    chartdaylabel.Text += "August";
                    break;
                case 9:
                    chartdaylabel.Text += "September";
                    break;
                case 10:
                    chartdaylabel.Text += "October";
                    break;
                case 11:
                    chartdaylabel.Text += "November";
                    break;
                case 12:
                    chartdaylabel.Text += "December";
                    break;
                default:
                    chartdaylabel.Text += "Invalid month value";
                    break;
            }
        }

        private void UC_Statistic_VisibleChanged(object sender, EventArgs e)
        {
            Statictis_Day(sender, e);
            Statictis_Month(sender, e);
        }
    }
}
