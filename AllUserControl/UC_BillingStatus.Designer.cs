﻿namespace RMS_TINGY.AllUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BillingLabel = new System.Windows.Forms.Label();
            this.line1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.itemList = new System.Windows.Forms.Label();
            this.elipseBilling = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.BillStatusDataView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tbnlabel = new System.Windows.Forms.Label();
            this.totalprice = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.BillStatusDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // BillingLabel
            // 
            this.BillingLabel.AutoSize = true;
            this.BillingLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillingLabel.Location = new System.Drawing.Point(80, 20);
            this.BillingLabel.Name = "BillingLabel";
            this.BillingLabel.Size = new System.Drawing.Size(66, 30);
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
            this.btnMenu.BorderRadius = 15;
            this.btnMenu.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnMenu.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(127)))));
            this.btnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(217)))), ((int)(((byte)(234)))));
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.Location = new System.Drawing.Point(54, 582);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(175, 30);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Print";
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(15, 480);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(55, 20);
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
            // BillStatusDataView
            // 
            this.BillStatusDataView.AllowUserToAddRows = false;
            this.BillStatusDataView.AllowUserToDeleteRows = false;
            this.BillStatusDataView.AllowUserToResizeColumns = false;
            this.BillStatusDataView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.BillStatusDataView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillStatusDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillStatusDataView.DefaultCellStyle = dataGridViewCellStyle6;
            this.BillStatusDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.BillStatusDataView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillStatusDataView.Location = new System.Drawing.Point(0, 60);
            this.BillStatusDataView.Name = "BillStatusDataView";
            this.BillStatusDataView.ReadOnly = true;
            this.BillStatusDataView.RowHeadersVisible = false;
            this.BillStatusDataView.RowHeadersWidth = 51;
            this.BillStatusDataView.Size = new System.Drawing.Size(285, 380);
            this.BillStatusDataView.TabIndex = 83;
            this.BillStatusDataView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BillStatusDataView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BillStatusDataView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BillStatusDataView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BillStatusDataView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BillStatusDataView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BillStatusDataView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillStatusDataView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BillStatusDataView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BillStatusDataView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillStatusDataView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BillStatusDataView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BillStatusDataView.ThemeStyle.HeaderStyle.Height = 23;
            this.BillStatusDataView.ThemeStyle.ReadOnly = true;
            this.BillStatusDataView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BillStatusDataView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillStatusDataView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillStatusDataView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BillStatusDataView.ThemeStyle.RowsStyle.Height = 22;
            this.BillStatusDataView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillStatusDataView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BillStatusDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillStatusDataView_CellContentClick);
            // 
            // tbnlabel
            // 
            this.tbnlabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnlabel.Location = new System.Drawing.Point(140, 20);
            this.tbnlabel.Name = "tbnlabel";
            this.tbnlabel.Size = new System.Drawing.Size(43, 28);
            this.tbnlabel.TabIndex = 84;
            this.tbnlabel.Text = "_";
            // 
            // totalprice
            // 
            this.totalprice.AutoSize = true;
            this.totalprice.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalprice.Location = new System.Drawing.Point(65, 480);
            this.totalprice.Name = "totalprice";
            this.totalprice.Size = new System.Drawing.Size(33, 20);
            this.totalprice.TabIndex = 85;
            this.totalprice.Text = "____";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 15;
            this.btnClose.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnClose.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(127)))));
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(54, 645);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(175, 30);
            this.btnClose.TabIndex = 86;
            this.btnClose.Text = "Close Bill";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // UC_BillingStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.totalprice);
            this.Controls.Add(this.tbnlabel);
            this.Controls.Add(this.BillStatusDataView);
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.BillingLabel);
            this.Name = "UC_BillingStatus";
            this.Size = new System.Drawing.Size(285, 768);
            this.Load += new System.EventHandler(this.UC_BillingStatus_Load);
            this.VisibleChanged += new System.EventHandler(this.UC_BillingStatus_VisibleChanged);
            this.Enter += new System.EventHandler(this.UC_BillingStatus_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.BillStatusDataView)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView BillStatusDataView;
        private System.Windows.Forms.Label tbnlabel;
        private System.Windows.Forms.Label totalprice;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}
