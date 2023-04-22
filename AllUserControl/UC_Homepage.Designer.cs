namespace RMS_TINGY.AllUserControl
{
    partial class UC_Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Homepage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picsDisplay = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelIngre = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelNameDisplay = new System.Windows.Forms.Label();
            this.labelTypeDisplay = new System.Windows.Forms.Label();
            this.labelPriceDisplay = new System.Windows.Forms.Label();
            this.labelTimeDisplay = new System.Windows.Forms.Label();
            this.labelIngreDisplay = new System.Windows.Forms.Label();
            this.picBoxName = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picBoxIngre = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picBoxType = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picBoxTime = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picBoxMoney = new Guna.UI2.WinForms.Guna2PictureBox();
            this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchButton = new Guna.UI2.WinForms.Guna2Button();
            this.homepageElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.MenuGridDataView = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picsDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIngre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuGridDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // picsDisplay
            // 
            this.picsDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picsDisplay.ImageRotate = 0F;
            this.picsDisplay.Location = new System.Drawing.Point(130, 450);
            this.picsDisplay.Name = "picsDisplay";
            this.picsDisplay.Size = new System.Drawing.Size(170, 140);
            this.picsDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picsDisplay.TabIndex = 1;
            this.picsDisplay.TabStop = false;
            this.picsDisplay.Click += new System.EventHandler(this.picsDisplay_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(390, 450);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 21);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(390, 510);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(48, 21);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Type:";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelType.Click += new System.EventHandler(this.labelType_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(540, 570);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(50, 21);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Price:";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPrice.Click += new System.EventHandler(this.labelPrice_Click);
            // 
            // labelIngre
            // 
            this.labelIngre.AutoSize = true;
            this.labelIngre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngre.Location = new System.Drawing.Point(690, 450);
            this.labelIngre.Name = "labelIngre";
            this.labelIngre.Size = new System.Drawing.Size(88, 21);
            this.labelIngre.TabIndex = 5;
            this.labelIngre.Text = "Ingredient:";
            this.labelIngre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelIngre.Click += new System.EventHandler(this.labelIngredient_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(690, 510);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(115, 21);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "Servable Time:";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTime.Click += new System.EventHandler(this.labelServableTime_Click);
            // 
            // labelNameDisplay
            // 
            this.labelNameDisplay.AutoSize = true;
            this.labelNameDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameDisplay.Location = new System.Drawing.Point(452, 450);
            this.labelNameDisplay.Name = "labelNameDisplay";
            this.labelNameDisplay.Size = new System.Drawing.Size(38, 21);
            this.labelNameDisplay.TabIndex = 7;
            this.labelNameDisplay.Text = "____";
            this.labelNameDisplay.Click += new System.EventHandler(this.labelNameDisplay_Click);
            // 
            // labelTypeDisplay
            // 
            this.labelTypeDisplay.AutoSize = true;
            this.labelTypeDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeDisplay.Location = new System.Drawing.Point(443, 510);
            this.labelTypeDisplay.Name = "labelTypeDisplay";
            this.labelTypeDisplay.Size = new System.Drawing.Size(38, 21);
            this.labelTypeDisplay.TabIndex = 8;
            this.labelTypeDisplay.Text = "____";
            this.labelTypeDisplay.Click += new System.EventHandler(this.labelTypeDisplay_Click);
            // 
            // labelPriceDisplay
            // 
            this.labelPriceDisplay.AutoSize = true;
            this.labelPriceDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceDisplay.Location = new System.Drawing.Point(595, 570);
            this.labelPriceDisplay.Name = "labelPriceDisplay";
            this.labelPriceDisplay.Size = new System.Drawing.Size(38, 21);
            this.labelPriceDisplay.TabIndex = 9;
            this.labelPriceDisplay.Text = "____";
            this.labelPriceDisplay.Click += new System.EventHandler(this.labelPriceDisplay_Click);
            // 
            // labelTimeDisplay
            // 
            this.labelTimeDisplay.AutoSize = true;
            this.labelTimeDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeDisplay.Location = new System.Drawing.Point(810, 510);
            this.labelTimeDisplay.Name = "labelTimeDisplay";
            this.labelTimeDisplay.Size = new System.Drawing.Size(38, 21);
            this.labelTimeDisplay.TabIndex = 10;
            this.labelTimeDisplay.Text = "____";
            this.labelTimeDisplay.Click += new System.EventHandler(this.labelServableTimeDisplay_Click);
            // 
            // labelIngreDisplay
            // 
            this.labelIngreDisplay.AutoSize = true;
            this.labelIngreDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngreDisplay.Location = new System.Drawing.Point(783, 450);
            this.labelIngreDisplay.Name = "labelIngreDisplay";
            this.labelIngreDisplay.Size = new System.Drawing.Size(38, 21);
            this.labelIngreDisplay.TabIndex = 11;
            this.labelIngreDisplay.Text = "____";
            this.labelIngreDisplay.Click += new System.EventHandler(this.labelIngredientDisplay_Click);
            // 
            // picBoxName
            // 
            this.picBoxName.Image = ((System.Drawing.Image)(resources.GetObject("picBoxName.Image")));
            this.picBoxName.ImageRotate = 0F;
            this.picBoxName.Location = new System.Drawing.Point(350, 445);
            this.picBoxName.Name = "picBoxName";
            this.picBoxName.Size = new System.Drawing.Size(30, 30);
            this.picBoxName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxName.TabIndex = 81;
            this.picBoxName.TabStop = false;
            this.picBoxName.Click += new System.EventHandler(this.picBoxName_Click);
            // 
            // picBoxIngre
            // 
            this.picBoxIngre.Image = ((System.Drawing.Image)(resources.GetObject("picBoxIngre.Image")));
            this.picBoxIngre.ImageRotate = 0F;
            this.picBoxIngre.Location = new System.Drawing.Point(650, 445);
            this.picBoxIngre.Name = "picBoxIngre";
            this.picBoxIngre.Size = new System.Drawing.Size(30, 30);
            this.picBoxIngre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxIngre.TabIndex = 82;
            this.picBoxIngre.TabStop = false;
            this.picBoxIngre.Click += new System.EventHandler(this.picBoxIngre_Click);
            // 
            // picBoxType
            // 
            this.picBoxType.Cursor = System.Windows.Forms.Cursors.Default;
            this.picBoxType.Image = ((System.Drawing.Image)(resources.GetObject("picBoxType.Image")));
            this.picBoxType.ImageRotate = 0F;
            this.picBoxType.Location = new System.Drawing.Point(350, 505);
            this.picBoxType.Name = "picBoxType";
            this.picBoxType.Size = new System.Drawing.Size(30, 30);
            this.picBoxType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxType.TabIndex = 83;
            this.picBoxType.TabStop = false;
            this.picBoxType.Click += new System.EventHandler(this.picBoxType_Click);
            // 
            // picBoxTime
            // 
            this.picBoxTime.Image = ((System.Drawing.Image)(resources.GetObject("picBoxTime.Image")));
            this.picBoxTime.ImageRotate = 0F;
            this.picBoxTime.Location = new System.Drawing.Point(650, 505);
            this.picBoxTime.Name = "picBoxTime";
            this.picBoxTime.Size = new System.Drawing.Size(30, 30);
            this.picBoxTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxTime.TabIndex = 84;
            this.picBoxTime.TabStop = false;
            this.picBoxTime.Click += new System.EventHandler(this.picBoxTime_Click);
            // 
            // picBoxMoney
            // 
            this.picBoxMoney.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMoney.Image")));
            this.picBoxMoney.ImageRotate = 0F;
            this.picBoxMoney.Location = new System.Drawing.Point(500, 565);
            this.picBoxMoney.Name = "picBoxMoney";
            this.picBoxMoney.Size = new System.Drawing.Size(30, 30);
            this.picBoxMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMoney.TabIndex = 85;
            this.picBoxMoney.TabStop = false;
            this.picBoxMoney.Click += new System.EventHandler(this.picBoxMoney_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderRadius = 12;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.DefaultText = "   Search by name";
            this.searchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextBox.Location = new System.Drawing.Point(730, 20);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PlaceholderText = "";
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.Size = new System.Drawing.Size(250, 30);
            this.searchTextBox.TabIndex = 86;
            this.searchTextBox.Click += new System.EventHandler(this.searchTextBox_Click);
            // 
            // searchButton
            // 
            this.searchButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchButton.FillColor = System.Drawing.Color.White;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageSize = new System.Drawing.Size(30, 30);
            this.searchButton.Location = new System.Drawing.Point(980, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(50, 50);
            this.searchButton.TabIndex = 87;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // homepageElipse
            // 
            this.homepageElipse.BorderRadius = 0;
            this.homepageElipse.TargetControl = this;
            // 
            // MenuGridDataView
            // 
            this.MenuGridDataView.AllowUserToAddRows = false;
            this.MenuGridDataView.AllowUserToDeleteRows = false;
            this.MenuGridDataView.AllowUserToResizeColumns = false;
            this.MenuGridDataView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.MenuGridDataView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MenuGridDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MenuGridDataView.DefaultCellStyle = dataGridViewCellStyle6;
            this.MenuGridDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.MenuGridDataView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MenuGridDataView.Location = new System.Drawing.Point(0, 100);
            this.MenuGridDataView.Name = "MenuGridDataView";
            this.MenuGridDataView.ReadOnly = true;
            this.MenuGridDataView.RowHeadersVisible = false;
            this.MenuGridDataView.RowHeadersWidth = 51;
            this.MenuGridDataView.Size = new System.Drawing.Size(1088, 250);
            this.MenuGridDataView.TabIndex = 88;
            this.MenuGridDataView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.MenuGridDataView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MenuGridDataView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MenuGridDataView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MenuGridDataView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MenuGridDataView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.MenuGridDataView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MenuGridDataView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MenuGridDataView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MenuGridDataView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuGridDataView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MenuGridDataView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.MenuGridDataView.ThemeStyle.HeaderStyle.Height = 23;
            this.MenuGridDataView.ThemeStyle.ReadOnly = true;
            this.MenuGridDataView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MenuGridDataView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MenuGridDataView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuGridDataView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MenuGridDataView.ThemeStyle.RowsStyle.Height = 22;
            this.MenuGridDataView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MenuGridDataView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MenuGridDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MenuGridDataView_CellClick);
            // 
            // UC_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MenuGridDataView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.picBoxMoney);
            this.Controls.Add(this.picBoxTime);
            this.Controls.Add(this.picBoxType);
            this.Controls.Add(this.picBoxIngre);
            this.Controls.Add(this.picBoxName);
            this.Controls.Add(this.labelIngreDisplay);
            this.Controls.Add(this.labelTimeDisplay);
            this.Controls.Add(this.labelPriceDisplay);
            this.Controls.Add(this.labelTypeDisplay);
            this.Controls.Add(this.labelNameDisplay);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelIngre);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.picsDisplay);
            this.Name = "UC_Homepage";
            this.Size = new System.Drawing.Size(1088, 768);
            this.Load += new System.EventHandler(this.UC_Homepage_Load);
            this.Enter += new System.EventHandler(this.UC_Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picsDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIngre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuGridDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox picsDisplay;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelIngre;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelNameDisplay;
        private System.Windows.Forms.Label labelTypeDisplay;
        private System.Windows.Forms.Label labelPriceDisplay;
        private System.Windows.Forms.Label labelTimeDisplay;
        private System.Windows.Forms.Label labelIngreDisplay;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxName;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxIngre;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxType;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxTime;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxMoney;
        private Guna.UI2.WinForms.Guna2TextBox searchTextBox;
        private Guna.UI2.WinForms.Guna2Button searchButton;
        private Guna.UI2.WinForms.Guna2Elipse homepageElipse;
        private Guna.UI2.WinForms.Guna2DataGridView MenuGridDataView;
    }
}
