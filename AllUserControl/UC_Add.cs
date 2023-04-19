using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


    }
}
