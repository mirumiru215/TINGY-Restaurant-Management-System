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
            }
            else if (usernameTextBox.Text == "staff" && passwordTextBox.Text == "staff")
            {
                adminaccess = false;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            login.Visible = false;
        }


        private void UC_Login_VisibleChanged(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            login.Visible = true;
            login.BringToFront();
        }
    }
}
