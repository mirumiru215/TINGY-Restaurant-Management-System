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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.StatisticLabel = new System.Windows.Forms.Label();
            this.picStatistic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ElipseStatistic = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.chartDay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartdaylabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.chartmonthlabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.textYear = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.textMonth = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.textToday = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.chartMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.picStatistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDay)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // StatisticLabel
            // 
            this.StatisticLabel.BackColor = System.Drawing.Color.White;
            this.StatisticLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatisticLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatisticLabel.Location = new System.Drawing.Point(127, 25);
            this.StatisticLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatisticLabel.Name = "StatisticLabel";
            this.StatisticLabel.Size = new System.Drawing.Size(247, 62);
            this.StatisticLabel.TabIndex = 0;
            this.StatisticLabel.Text = "Statistic";
            this.StatisticLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picStatistic
            // 
            this.picStatistic.Image = ((System.Drawing.Image)(resources.GetObject("picStatistic.Image")));
            this.picStatistic.ImageRotate = 0F;
            this.picStatistic.Location = new System.Drawing.Point(53, 25);
            this.picStatistic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picStatistic.Name = "picStatistic";
            this.picStatistic.Size = new System.Drawing.Size(67, 62);
            this.picStatistic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStatistic.TabIndex = 1;
            this.picStatistic.TabStop = false;
            // 
            // ElipseStatistic
            // 
            this.ElipseStatistic.BorderRadius = 0;
            this.ElipseStatistic.TargetControl = this;
            // 
            // chartDay
            // 
            chartArea2.AxisX.Title = "Day";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY.Title = "Revenue";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.Name = "ChartArea1";
            this.chartDay.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDay.Legends.Add(legend2);
            this.chartDay.Location = new System.Drawing.Point(53, 146);
            this.chartDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartDay.Name = "chartDay";
            this.chartDay.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartDay.Series.Add(series2);
            this.chartDay.Size = new System.Drawing.Size(913, 369);
            this.chartDay.TabIndex = 0;
            this.chartDay.Text = "chart1";
            // 
            // chartdaylabel
            // 
            this.chartdaylabel.BackColor = System.Drawing.Color.Transparent;
            this.chartdaylabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartdaylabel.Location = new System.Drawing.Point(139, 107);
            this.chartdaylabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartdaylabel.Name = "chartdaylabel";
            this.chartdaylabel.Size = new System.Drawing.Size(428, 34);
            this.chartdaylabel.TabIndex = 84;
            this.chartdaylabel.Text = "Chart depicting total revenue by day in ";
            // 
            // chartmonthlabel
            // 
            this.chartmonthlabel.BackColor = System.Drawing.Color.Transparent;
            this.chartmonthlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartmonthlabel.Location = new System.Drawing.Point(139, 534);
            this.chartmonthlabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartmonthlabel.Name = "chartmonthlabel";
            this.chartmonthlabel.Size = new System.Drawing.Size(458, 34);
            this.chartmonthlabel.TabIndex = 85;
            this.chartmonthlabel.Text = "Chart depicting total revenue by month in ";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.guna2Panel1.BorderRadius = 16;
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel6);
            this.guna2Panel1.Controls.Add(this.textYear);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel1.Controls.Add(this.textMonth);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Controls.Add(this.textToday);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Location = new System.Drawing.Point(975, 641);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(407, 255);
            this.guna2Panel1.TabIndex = 86;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(16, 22);
            this.guna2HtmlLabel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(244, 34);
            this.guna2HtmlLabel6.TabIndex = 108;
            this.guna2HtmlLabel6.Text = "Current Total Revenue";
            // 
            // textYear
            // 
            this.textYear.BackColor = System.Drawing.Color.Transparent;
            this.textYear.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textYear.Location = new System.Drawing.Point(216, 183);
            this.textYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(43, 34);
            this.textYear.TabIndex = 107;
            this.textYear.Text = "____";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(16, 183);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(109, 34);
            this.guna2HtmlLabel5.TabIndex = 106;
            this.guna2HtmlLabel5.Text = "This Year:";
            // 
            // textMonth
            // 
            this.textMonth.BackColor = System.Drawing.Color.Transparent;
            this.textMonth.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMonth.Location = new System.Drawing.Point(216, 126);
            this.textMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textMonth.Name = "textMonth";
            this.textMonth.Size = new System.Drawing.Size(43, 34);
            this.textMonth.TabIndex = 105;
            this.textMonth.Text = "____";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(16, 126);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(129, 34);
            this.guna2HtmlLabel3.TabIndex = 104;
            this.guna2HtmlLabel3.Text = "This Month:";
            // 
            // textToday
            // 
            this.textToday.BackColor = System.Drawing.Color.Transparent;
            this.textToday.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textToday.Location = new System.Drawing.Point(216, 75);
            this.textToday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textToday.Name = "textToday";
            this.textToday.Size = new System.Drawing.Size(43, 34);
            this.textToday.TabIndex = 103;
            this.textToday.Text = "____";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(16, 75);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(75, 34);
            this.guna2HtmlLabel1.TabIndex = 102;
            this.guna2HtmlLabel1.Text = "Today:";
            // 
            // chartMonth
            // 
            chartArea1.AxisX.Title = "Month";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.Title = "Revenue";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.chartMonth.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMonth.Legends.Add(legend1);
            this.chartMonth.Location = new System.Drawing.Point(53, 574);
            this.chartMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartMonth.Name = "chartMonth";
            this.chartMonth.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMonth.Series.Add(series1);
            this.chartMonth.Size = new System.Drawing.Size(913, 369);
            this.chartMonth.TabIndex = 87;
            this.chartMonth.Text = "chart1";
            // 
            // UC_Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.chartMonth);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.chartmonthlabel);
            this.Controls.Add(this.chartdaylabel);
            this.Controls.Add(this.chartDay);
            this.Controls.Add(this.picStatistic);
            this.Controls.Add(this.StatisticLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_Statistic";
            this.Size = new System.Drawing.Size(1900, 1184);
            this.Load += new System.EventHandler(this.UC_Statistic_Load);
            this.VisibleChanged += new System.EventHandler(this.UC_Statistic_VisibleChanged);
            this.Enter += new System.EventHandler(this.UC_Statistic_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picStatistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDay)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label StatisticLabel;
        private Guna.UI2.WinForms.Guna2PictureBox picStatistic;
        private Guna.UI2.WinForms.Guna2Elipse ElipseStatistic;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDay;
        private Guna.UI2.WinForms.Guna2HtmlLabel chartdaylabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel chartmonthlabel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel textYear;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel textMonth;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel textToday;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonth;
    }
}
