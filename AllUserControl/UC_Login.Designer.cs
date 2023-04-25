namespace RMS_TINGY.AllUserControl
{
    partial class UC_Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Login));
            this.loading = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.loadLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.login = new Guna.UI2.WinForms.Guna2Panel();
            this.welcome = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.amiya = new Guna.UI2.WinForms.Guna2PictureBox();
            this.username = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.password = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.usernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.passwordIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.loginBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.welcome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amiya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // loading
            // 
            this.loading.CircleSize = 3F;
            this.loading.Location = new System.Drawing.Point(471, 242);
            this.loading.Name = "loading";
            this.loading.ProgressColor = System.Drawing.Color.White;
            this.loading.Size = new System.Drawing.Size(134, 135);
            this.loading.TabIndex = 1;
            // 
            // loadLabel
            // 
            this.loadLabel.BackColor = System.Drawing.Color.Transparent;
            this.loadLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadLabel.ForeColor = System.Drawing.Color.White;
            this.loadLabel.Location = new System.Drawing.Point(430, 410);
            this.loadLabel.Name = "loadLabel";
            this.loadLabel.Size = new System.Drawing.Size(246, 26);
            this.loadLabel.TabIndex = 2;
            this.loadLabel.Text = "Validation in progress...";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.White;
            this.login.BorderRadius = 10;
            this.login.BorderThickness = 5;
            this.login.Controls.Add(this.loginBtn);
            this.login.Controls.Add(this.passwordIcon);
            this.login.Controls.Add(this.usernameIcon);
            this.login.Controls.Add(this.passwordTextBox);
            this.login.Controls.Add(this.usernameTextBox);
            this.login.Controls.Add(this.password);
            this.login.Controls.Add(this.username);
            this.login.Controls.Add(this.welcome);
            this.login.Controls.Add(this.guna2TextBox1);
            this.login.Controls.Add(this.amiya);
            this.login.Location = new System.Drawing.Point(148, 156);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(810, 394);
            this.login.TabIndex = 3;
            this.login.Paint += new System.Windows.Forms.PaintEventHandler(this.loginPanel_Paint);
            // 
            // welcome
            // 
            this.welcome.Image = ((System.Drawing.Image)(resources.GetObject("welcome.Image")));
            this.welcome.ImageRotate = 0F;
            this.welcome.Location = new System.Drawing.Point(423, 3);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(313, 138);
            this.welcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.welcome.TabIndex = 2;
            this.welcome.TabStop = false;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(1161, 272);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(486, 72);
            this.guna2TextBox1.TabIndex = 1;
            // 
            // amiya
            // 
            this.amiya.Image = ((System.Drawing.Image)(resources.GetObject("amiya.Image")));
            this.amiya.ImageRotate = 0F;
            this.amiya.Location = new System.Drawing.Point(3, 0);
            this.amiya.Name = "amiya";
            this.amiya.Size = new System.Drawing.Size(345, 394);
            this.amiya.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.amiya.TabIndex = 0;
            this.amiya.TabStop = false;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(449, 133);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(96, 24);
            this.username.TabIndex = 3;
            this.username.Text = "Username";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(449, 240);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(90, 24);
            this.password.TabIndex = 4;
            this.password.Text = "Password";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextBox.DefaultText = "";
            this.usernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextBox.Location = new System.Drawing.Point(449, 163);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PasswordChar = '\0';
            this.usernameTextBox.PlaceholderText = "";
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.Size = new System.Drawing.Size(276, 36);
            this.usernameTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.usernameTextBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.DefaultText = "";
            this.passwordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.Location = new System.Drawing.Point(449, 272);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '\0';
            this.passwordTextBox.PlaceholderText = "";
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.Size = new System.Drawing.Size(276, 36);
            this.passwordTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.passwordTextBox.TabIndex = 6;
            // 
            // usernameIcon
            // 
            this.usernameIcon.Image = ((System.Drawing.Image)(resources.GetObject("usernameIcon.Image")));
            this.usernameIcon.ImageRotate = 0F;
            this.usernameIcon.Location = new System.Drawing.Point(395, 126);
            this.usernameIcon.Name = "usernameIcon";
            this.usernameIcon.Size = new System.Drawing.Size(42, 39);
            this.usernameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usernameIcon.TabIndex = 7;
            this.usernameIcon.TabStop = false;
            // 
            // passwordIcon
            // 
            this.passwordIcon.Image = ((System.Drawing.Image)(resources.GetObject("passwordIcon.Image")));
            this.passwordIcon.ImageRotate = 0F;
            this.passwordIcon.Location = new System.Drawing.Point(395, 227);
            this.passwordIcon.Name = "passwordIcon";
            this.passwordIcon.Size = new System.Drawing.Size(42, 40);
            this.passwordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passwordIcon.TabIndex = 8;
            this.passwordIcon.TabStop = false;
            // 
            // loginBtn
            // 
            this.loginBtn.BorderRadius = 25;
            this.loginBtn.BorderThickness = 1;
            this.loginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(217)))), ((int)(((byte)(234)))));
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(490, 334);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(180, 45);
            this.loginBtn.TabIndex = 9;
            this.loginBtn.Text = "LOGIN";
            // 
            // UC_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.Controls.Add(this.login);
            this.Controls.Add(this.loadLabel);
            this.Controls.Add(this.loading);
            this.Name = "UC_Login";
            this.Size = new System.Drawing.Size(1088, 768);
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.welcome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amiya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2WinProgressIndicator loading;
        private Guna.UI2.WinForms.Guna2HtmlLabel loadLabel;
        private Guna.UI2.WinForms.Guna2Panel login;
        private Guna.UI2.WinForms.Guna2PictureBox amiya;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2PictureBox welcome;
        private Guna.UI2.WinForms.Guna2HtmlLabel password;
        private Guna.UI2.WinForms.Guna2HtmlLabel username;
        private Guna.UI2.WinForms.Guna2GradientButton loginBtn;
        private Guna.UI2.WinForms.Guna2PictureBox passwordIcon;
        private Guna.UI2.WinForms.Guna2PictureBox usernameIcon;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox usernameTextBox;
    }
}
