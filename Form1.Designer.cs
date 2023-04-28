namespace RMS_TINGY
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UCPanel = new System.Windows.Forms.Panel();
            this.btnexitnum2 = new Guna.UI2.WinForms.Guna2Button();
            this.uC_Login1 = new RMS_TINGY.AllUserControl.UC_Login();
            this.uC_Statistic1 = new RMS_TINGY.AllUserControl.UC_Statistic();
            this.uC_Staff1 = new RMS_TINGY.AllUserControl.UC_Staff();
            this.uC_Order1 = new RMS_TINGY.AllUserControl.UC_Order();
            this.uC_Menu1 = new RMS_TINGY.AllUserControl.UC_Menu();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.usernameIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnStaff = new Guna.UI2.WinForms.Guna2Button();
            this.btnStatistic = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.UCPanel.SuspendLayout();
            this.sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // UCPanel
            // 
            this.UCPanel.BackColor = System.Drawing.Color.White;
            this.UCPanel.Controls.Add(this.btnexitnum2);
            this.UCPanel.Controls.Add(this.uC_Login1);
            this.UCPanel.Controls.Add(this.uC_Order1);
            this.UCPanel.Controls.Add(this.uC_Menu1);
            this.UCPanel.Controls.Add(this.uC_Staff1);
            this.UCPanel.Controls.Add(this.uC_Statistic1);
            this.UCPanel.Location = new System.Drawing.Point(272, 0);
            this.UCPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UCPanel.Name = "UCPanel";
            this.UCPanel.Size = new System.Drawing.Size(1088, 768);
            this.UCPanel.TabIndex = 1;
            this.UCPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UCPanel_Paint);
            // 
            // btnexitnum2
            // 
            this.btnexitnum2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.btnexitnum2.BorderRadius = 18;
            this.btnexitnum2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnexitnum2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnexitnum2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnexitnum2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnexitnum2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(217)))), ((int)(((byte)(234)))));
            this.btnexitnum2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexitnum2.ForeColor = System.Drawing.Color.White;
            this.btnexitnum2.Location = new System.Drawing.Point(302, 686);
            this.btnexitnum2.Name = "btnexitnum2";
            this.btnexitnum2.Size = new System.Drawing.Size(150, 45);
            this.btnexitnum2.TabIndex = 5;
            this.btnexitnum2.Text = "Exit";
            this.btnexitnum2.Click += new System.EventHandler(this.btnexitnum2_Click);
            // 
            // uC_Login1
            // 
            this.uC_Login1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.uC_Login1.Location = new System.Drawing.Point(0, 0);
            this.uC_Login1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_Login1.Name = "uC_Login1";
            this.uC_Login1.Size = new System.Drawing.Size(1360, 768);
            this.uC_Login1.TabIndex = 4;
            this.uC_Login1.Load += new System.EventHandler(this.uC_Login1_Load);
            this.uC_Login1.VisibleChanged += new System.EventHandler(this.uC_Login1_VisibleChanged);
            // 
            // uC_Statistic1
            // 
            this.uC_Statistic1.AutoSize = true;
            this.uC_Statistic1.BackColor = System.Drawing.Color.White;
            this.uC_Statistic1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_Statistic1.BackgroundImage")));
            this.uC_Statistic1.Location = new System.Drawing.Point(0, 0);
            this.uC_Statistic1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_Statistic1.Name = "uC_Statistic1";
            this.uC_Statistic1.Size = new System.Drawing.Size(1040, 769);
            this.uC_Statistic1.TabIndex = 3;
            this.uC_Statistic1.Load += new System.EventHandler(this.uC_Statistic1_Load);
            // 
            // uC_Staff1
            // 
            this.uC_Staff1.BackColor = System.Drawing.Color.White;
            this.uC_Staff1.Location = new System.Drawing.Point(0, 0);
            this.uC_Staff1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_Staff1.Name = "uC_Staff1";
            this.uC_Staff1.Size = new System.Drawing.Size(1088, 768);
            this.uC_Staff1.TabIndex = 2;
            this.uC_Staff1.Load += new System.EventHandler(this.uC_Staff1_Load);
            // 
            // uC_Order1
            // 
            this.uC_Order1.BackColor = System.Drawing.Color.White;
            this.uC_Order1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_Order1.BackgroundImage")));
            this.uC_Order1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_Order1.Location = new System.Drawing.Point(0, 0);
            this.uC_Order1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uC_Order1.Name = "uC_Order1";
            this.uC_Order1.Size = new System.Drawing.Size(1088, 768);
            this.uC_Order1.TabIndex = 1;
            this.uC_Order1.Load += new System.EventHandler(this.uC_Order1_Load);
            // 
            // uC_Menu1
            // 
            this.uC_Menu1.BackColor = System.Drawing.Color.White;
            this.uC_Menu1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_Menu1.BackgroundImage")));
            this.uC_Menu1.Location = new System.Drawing.Point(0, 0);
            this.uC_Menu1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_Menu1.Name = "uC_Menu1";
            this.uC_Menu1.Size = new System.Drawing.Size(1088, 768);
            this.uC_Menu1.TabIndex = 0;
            this.uC_Menu1.Load += new System.EventHandler(this.uC_Menu1_Load);
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.sidebarPanel.Controls.Add(this.guna2PictureBox1);
            this.sidebarPanel.Controls.Add(this.usernamelabel);
            this.sidebarPanel.Controls.Add(this.usernameIcon);
            this.sidebarPanel.Controls.Add(this.btnLogout);
            this.sidebarPanel.Controls.Add(this.btnExit);
            this.sidebarPanel.Controls.Add(this.btnStaff);
            this.sidebarPanel.Controls.Add(this.btnStatistic);
            this.sidebarPanel.Controls.Add(this.btnOrder);
            this.sidebarPanel.Controls.Add(this.btnMenu);
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(272, 768);
            this.sidebarPanel.TabIndex = 0;
            this.sidebarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebarPanel_Paint);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.BackgroundImage")));
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(66, 25);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(140, 140);
            this.guna2PictureBox1.TabIndex = 10;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.Location = new System.Drawing.Point(107, 575);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(98, 30);
            this.usernamelabel.TabIndex = 9;
            this.usernamelabel.Text = "Login As";
            this.usernamelabel.Click += new System.EventHandler(this.usernamelabel_Click);
            // 
            // usernameIcon
            // 
            this.usernameIcon.Image = ((System.Drawing.Image)(resources.GetObject("usernameIcon.Image")));
            this.usernameIcon.ImageRotate = 0F;
            this.usernameIcon.Location = new System.Drawing.Point(58, 570);
            this.usernameIcon.Name = "usernameIcon";
            this.usernameIcon.Size = new System.Drawing.Size(40, 40);
            this.usernameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usernameIcon.TabIndex = 8;
            this.usernameIcon.TabStop = false;
            this.usernameIcon.Click += new System.EventHandler(this.usernameIcon_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.btnLogout.BorderRadius = 18;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(217)))), ((int)(((byte)(234)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(61, 630);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 45);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.BorderRadius = 18;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(217)))), ((int)(((byte)(234)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(61, 690);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 45);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.btnStaff.BorderRadius = 26;
            this.btnStaff.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStaff.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnStaff.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(127)))));
            this.btnStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStaff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(217)))), ((int)(((byte)(234)))));
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.Black;
            this.btnStaff.Location = new System.Drawing.Point(36, 460);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(200, 60);
            this.btnStaff.TabIndex = 3;
            this.btnStaff.Text = "STAFF";
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.btnStatistic.BorderRadius = 26;
            this.btnStatistic.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStatistic.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnStatistic.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(127)))));
            this.btnStatistic.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStatistic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStatistic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStatistic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStatistic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(217)))), ((int)(((byte)(234)))));
            this.btnStatistic.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistic.ForeColor = System.Drawing.Color.Black;
            this.btnStatistic.Location = new System.Drawing.Point(36, 370);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(200, 60);
            this.btnStatistic.TabIndex = 2;
            this.btnStatistic.Text = "STATISTIC";
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.btnOrder.BorderRadius = 26;
            this.btnOrder.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnOrder.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnOrder.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(127)))));
            this.btnOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(217)))), ((int)(((byte)(234)))));
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Black;
            this.btnOrder.Location = new System.Drawing.Point(36, 280);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(200, 60);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "ORDER";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.btnMenu.BorderRadius = 26;
            this.btnMenu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMenu.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnMenu.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(127)))));
            this.btnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(217)))), ((int)(((byte)(234)))));
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.Location = new System.Drawing.Point(36, 190);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(200, 60);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "MENU";
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 6;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.UCPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.UCPanel.ResumeLayout(false);
            this.UCPanel.PerformLayout();
            this.sidebarPanel.ResumeLayout(false);
            this.sidebarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel UCPanel;
        private System.Windows.Forms.Panel sidebarPanel;
        private Guna.UI2.WinForms.Guna2Button btnMenu;
        private Guna.UI2.WinForms.Guna2Button btnStaff;
        private Guna.UI2.WinForms.Guna2Button btnStatistic;
        private Guna.UI2.WinForms.Guna2Button btnOrder;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private AllUserControl.UC_Menu uC_Menu1;
        private AllUserControl.UC_Order uC_Order1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private AllUserControl.UC_Staff uC_Staff1;
        private AllUserControl.UC_Statistic uC_Statistic1;
        private AllUserControl.UC_Login uC_Login1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnexitnum2;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2PictureBox usernameIcon;
        private System.Windows.Forms.Label usernamelabel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}

