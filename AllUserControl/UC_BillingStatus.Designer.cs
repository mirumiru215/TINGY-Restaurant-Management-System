namespace RMS_TINGY.AllUserControl
{
    partial class UC_BillingStatus
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
            this.components = new System.ComponentModel.Container();
            this.BillingLabel = new System.Windows.Forms.Label();
            this.line1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.itemList = new System.Windows.Forms.Label();
            this.elipseBilling = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // BillingLabel
            // 
            this.BillingLabel.AutoSize = true;
            this.BillingLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillingLabel.Location = new System.Drawing.Point(84, 22);
            this.BillingLabel.Name = "BillingLabel";
            this.BillingLabel.Size = new System.Drawing.Size(63, 28);
            this.BillingLabel.TabIndex = 0;
            this.BillingLabel.Text = "Bill #";
            this.BillingLabel.Click += new System.EventHandler(this.BillingLabel_Click);
            // 
            // line1
            // 
            this.line1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.line1.BorderThickness = 1;
            this.line1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.line1.Location = new System.Drawing.Point(19, 53);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(200, 2);
            this.line1.TabIndex = 1;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.guna2CustomGradientPanel1.BorderThickness = 1;
            this.guna2CustomGradientPanel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(19, 474);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(200, 2);
            this.guna2CustomGradientPanel1.TabIndex = 1;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
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
            this.btnMenu.Location = new System.Drawing.Point(19, 611);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(200, 31);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Print";
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(14, 479);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(51, 19);
            this.TotalLabel.TabIndex = 3;
            this.TotalLabel.Text = "Total: ";
            // 
            // itemList
            // 
            this.itemList.AutoSize = true;
            this.itemList.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemList.Location = new System.Drawing.Point(15, 58);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(156, 19);
            this.itemList.TabIndex = 3;
            this.itemList.Text = "List of items and price";
            // 
            // UC_BillingStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.BillingLabel);
            this.Name = "UC_BillingStatus";
            this.Size = new System.Drawing.Size(241, 766);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BillingLabel;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel line1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnMenu;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label itemList;
        private Guna.UI2.WinForms.Guna2Elipse elipseBilling;
    }
}
