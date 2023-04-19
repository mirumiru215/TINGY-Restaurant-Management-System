using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RMS_TINGY.AllUserControl
{
    public partial class UC_Add : UserControl
    {
        SQLControl fn = new SQLControl();
        String query;
        public UC_Add()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textDish.Clear();
            textIngre.Clear();
            textPrice.Clear();
            textServe.StartIndex = -1;
            textType.StartIndex = -1;
            picsDisplay.Image = null;
        }

        string imgLocation = null;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textDish.Text != "" && textIngre.Text != "" && textType.Text != "" && textServe.Text != "" && textPrice.Text != "")
            {
                String cname = textDish.Text;
                String type = textType.Text;
                String ingredient = textIngre.Text;
                String stime = textServe.Text;
                Int64 price = Int64.Parse(textPrice.Text);

                byte[] images = null;
                FileStream streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(streem);
                images = brs.ReadBytes((int)streem.Length);
                query = "insert into dishDetails (cname,ntype,ingredient,stime,price,picture) values('" + cname + "','" + type + "','" + ingredient + "','" + stime + "'," + price + ",@images)";
                fn.setData(query, images);
            }
            else
            {
                MessageBox.Show("Fill All Data Please", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
