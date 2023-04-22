namespace RMS_TINGY.AllUserControl
{
    partial class UC_Statistic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Statistic));
            this.StatisticLabel = new System.Windows.Forms.Label();
            this.picStatistic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ElipseStatistic = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // StatisticLabel
            // 
            this.StatisticLabel.BackColor = System.Drawing.Color.White;
            this.StatisticLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatisticLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatisticLabel.Location = new System.Drawing.Point(95, 20);
            this.StatisticLabel.Name = "StatisticLabel";
            this.StatisticLabel.Size = new System.Drawing.Size(185, 50);
            this.StatisticLabel.TabIndex = 0;
            this.StatisticLabel.Text = "Statistic";
            this.StatisticLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picStatistic
            // 
            this.picStatistic.Image = ((System.Drawing.Image)(resources.GetObject("picStatistic.Image")));
            this.picStatistic.ImageRotate = 0F;
            this.picStatistic.Location = new System.Drawing.Point(40, 20);
            this.picStatistic.Margin = new System.Windows.Forms.Padding(2);
            this.picStatistic.Name = "picStatistic";
            this.picStatistic.Size = new System.Drawing.Size(50, 50);
            this.picStatistic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStatistic.TabIndex = 1;
            this.picStatistic.TabStop = false;
            // 
            // ElipseStatistic
            // 
            this.ElipseStatistic.BorderRadius = 0;
            // 
            // UC_Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picStatistic);
            this.Controls.Add(this.StatisticLabel);
            this.Name = "UC_Statistic";
            this.Size = new System.Drawing.Size(1088, 768);
            this.Load += new System.EventHandler(this.UC_Statistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStatistic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label StatisticLabel;
        private Guna.UI2.WinForms.Guna2PictureBox picStatistic;
        private Guna.UI2.WinForms.Guna2Elipse ElipseStatistic;
    }
}
