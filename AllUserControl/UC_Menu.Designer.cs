namespace RMS_TINGY.AllUserControl
{
    partial class UC_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Menu));
            this.uC_Add1 = new RMS_TINGY.AllUserControl.UC_Add();
            this.elipseMenu = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.funcPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.uC_Homepage1 = new RMS_TINGY.AllUserControl.UC_Homepage();
            this.funcPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // uC_Add1
            // 
            this.uC_Add1.BackColor = System.Drawing.Color.White;
            this.uC_Add1.Location = new System.Drawing.Point(3, 62);
            this.uC_Add1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_Add1.Name = "uC_Add1";
            this.uC_Add1.Size = new System.Drawing.Size(1088, 768);
            this.uC_Add1.TabIndex = 81;
            // 
            // elipseMenu
            // 
            this.elipseMenu.BorderRadius = 0;
            this.elipseMenu.TargetControl = this;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.btnAdd.BorderRadius = 24;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.btnAdd.Location = new System.Drawing.Point(20, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(250, 50);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add New Dish";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.btnBack.BorderRadius = 45;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageSize = new System.Drawing.Size(50, 50);
            this.btnBack.Location = new System.Drawing.Point(20, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 50);
            this.btnBack.TabIndex = 1;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // funcPanel
            // 
            this.funcPanel.BackColor = System.Drawing.Color.White;
            this.funcPanel.BorderColor = System.Drawing.Color.Black;
            this.funcPanel.Controls.Add(this.btnBack);
            this.funcPanel.Controls.Add(this.btnAdd);
            this.funcPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.funcPanel.Location = new System.Drawing.Point(0, 0);
            this.funcPanel.Margin = new System.Windows.Forms.Padding(2);
            this.funcPanel.Name = "funcPanel";
            this.funcPanel.Size = new System.Drawing.Size(1088, 60);
            this.funcPanel.TabIndex = 80;
            this.funcPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.funcPanel_Paint);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.uC_Homepage1);
            this.MenuPanel.Location = new System.Drawing.Point(0, 60);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1088, 708);
            this.MenuPanel.TabIndex = 82;
            this.MenuPanel.Enter += new System.EventHandler(this.MenuPanel_Enter);
            // 
            // uC_Homepage1
            // 
            this.uC_Homepage1.BackColor = System.Drawing.Color.White;
            this.uC_Homepage1.Location = new System.Drawing.Point(0, 0);
            this.uC_Homepage1.Name = "uC_Homepage1";
            this.uC_Homepage1.Size = new System.Drawing.Size(1088, 768);
            this.uC_Homepage1.TabIndex = 0;
            // 
            // UC_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.funcPanel);
            this.Controls.Add(this.uC_Add1);
            this.Name = "UC_Menu";
            this.Size = new System.Drawing.Size(1088, 768);
            this.Load += new System.EventHandler(this.UC_Menu_Load);
            this.VisibleChanged += new System.EventHandler(this.UC_Menu_Enter);
            this.Click += new System.EventHandler(this.UC_Menu_Enter);
            this.Enter += new System.EventHandler(this.UC_Menu_Enter);
            this.funcPanel.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UC_Add uC_Add1;
        private Guna.UI2.WinForms.Guna2Elipse elipseMenu;
        private Guna.UI2.WinForms.Guna2Panel funcPanel;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Panel MenuPanel;
        private UC_Homepage uC_Homepage1;
    }
}
