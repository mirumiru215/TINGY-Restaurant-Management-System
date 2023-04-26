using System;
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
    public partial class UC_Login : UserControl
    {
        public bool adminaccess = false;
        public UC_Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "admin" && passwordTextBox.Text == "admin")
            {
                adminaccess = true;
                this.Hide();
               // timer1.Stop();

            }
            else if (usernameTextBox.Text == "staff" && passwordTextBox.Text == "staff")
            {
                adminaccess = false;
                this.Hide();
              //  timer1.Stop();
            }
            //this.timer1.Start();
            login.Visible = false;
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{

        //    if (usernameTextBox.Text == "admin" && passwordTextBox.Text == "admin")
        //    {
        //        adminaccess = true;
        //        this.Hide();
        //        timer1.Stop();

        //    }
        //    else if (usernameTextBox.Text == "staff" && passwordTextBox.Text == "staff")
        //    {
        //        adminaccess = false;
        //        this.Hide();
        //        timer1.Stop();

        //    }
        //    else
        //    {
        //        login.Visible = true;
        //        timer1.Stop();
        //    }


        //}

        private void UC_Login_VisibleChanged(object sender, EventArgs e)
        {
            //timer1.Stop();
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            login.Visible = true;
            login.BringToFront();
        }
    }
}
