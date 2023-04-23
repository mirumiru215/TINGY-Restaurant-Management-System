using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_TINGY.AllUserControl
{
    public partial class UC_StaffAddEmployee : UserControl
    {
        string imgLocation = null;
        string dom = null;
        SQLControl fn = new SQLControl();
        String query;
        public UC_StaffAddEmployee()
        {
            InitializeComponent();
        }
        private void DayOfBirth_ValueChanged(object sender, EventArgs e)
        {
            dom = DayOfBirth.Value.ToString();
            string[] parts = dom.Split(' ');
            dom = parts[0];
            dom = dom.Replace('/', '-');
        }


        private void picBoxImg_Click(object sender, EventArgs e)
        {

        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textName.Text != "" && textPhone.Text != "" && textPosition.Text != "")
            {
                String sname = textName.Text;
                String phonenum = textPhone.Text;
                String position = textPosition.Text;
                Int64 workcount = 0;
                Int64 salary;
                switch (position)
                {
                    case "Chef":
                        salary = 100000;
                        break;
                    case "Waiter":
                        salary = 70000;
                        break;
                    case "Busser":
                        salary = 50000;
                        break;
                    case "Laborer":
                        salary = 30000;
                        break;
                    default:
                        salary = 20000;
                        break;
                }    
                byte[] images = null;
                FileStream streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(streem);
                images = brs.ReadBytes((int)streem.Length);
                query = "insert into staffDetails (sname,dom,phonenum,position,workcount,salary,picture) values('" + sname + "','" + dom + "','" + phonenum + "','" + position + "'," + workcount + "," + salary*workcount + ",@images)";
                fn.setData(query, images);
            }
            else
            {
                MessageBox.Show("Fill All Data Please", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All files(*.*)|*.*|png files(*.png)|*.png|jpg files(*.jpg)|*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                picsDisplay.ImageLocation = imgLocation;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textName.Clear();
            textPhone.Clear();
            textPosition.StartIndex = -1;
            picsDisplay.Image = null;
        }
    }
}
