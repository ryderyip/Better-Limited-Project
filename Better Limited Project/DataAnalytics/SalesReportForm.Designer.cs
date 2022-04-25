namespace Better_Limited_Project.DataAnalytics
{
    partial class SalesReportForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.SearchDateFrom = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.lblSearchDateTo = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartNumberOfSalesMade = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDistrict = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNumberOfSalesMade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistrict)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchDateFrom
            // 
            this.SearchDateFrom.AutoSize = true;
            this.SearchDateFrom.Location = new System.Drawing.Point(32, 22);
            this.SearchDateFrom.Name = "SearchDateFrom";
            this.SearchDateFrom.Size = new System.Drawing.Size(80, 12);
            this.SearchDateFrom.TabIndex = 0;
            this.SearchDateFrom.Text = "Sales Data From";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(34, 47);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFrom.TabIndex = 1;
            // 
            // lblSearchDateTo
            // 
            this.lblSearchDateTo.AutoSize = true;
            this.lblSearchDateTo.Location = new System.Drawing.Point(354, 22);
            this.lblSearchDateTo.Name = "lblSearchDateTo";
            this.lblSearchDateTo.Size = new System.Drawing.Size(18, 12);
            this.lblSearchDateTo.TabIndex = 2;
            this.lblSearchDateTo.Text = "To";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(356, 47);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTo.TabIndex = 3;
            // 
            // chartRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(34, 85);
            this.chartRevenue.Name = "chartRevenue";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Revenue";
            this.chartRevenue.Series.Add(series1);
            this.chartRevenue.Size = new System.Drawing.Size(294, 111);
            this.chartRevenue.TabIndex = 4;
            this.chartRevenue.Text = "chart1";
            // 
            // chartNumberOfSalesMade
            // 
            chartArea2.Name = "ChartArea1";
            this.chartNumberOfSalesMade.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartNumberOfSalesMade.Legends.Add(legend2);
            this.chartNumberOfSalesMade.Location = new System.Drawing.Point(356, 85);
            this.chartNumberOfSalesMade.Name = "chartNumberOfSalesMade";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Number of Sales Made";
            this.chartNumberOfSalesMade.Series.Add(series2);
            this.chartNumberOfSalesMade.Size = new System.Drawing.Size(371, 111);
            this.chartNumberOfSalesMade.TabIndex = 5;
            this.chartNumberOfSalesMade.Text = "chart2";
            // 
            // chartCity
            // 
            chartArea3.Name = "ChartArea1";
            this.chartCity.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartCity.Legends.Add(legend3);
            this.chartCity.Location = new System.Drawing.Point(34, 212);
            this.chartCity.Name = "chartCity";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "city";
            this.chartCity.Series.Add(series3);
            this.chartCity.Size = new System.Drawing.Size(294, 214);
            this.chartCity.TabIndex = 6;
            this.chartCity.Text = "chart3";
            title1.Name = "city";
            title1.Text = "Sales by Hong Kong";
            this.chartCity.Titles.Add(title1);
            // 
            // chartDistrict
            // 
            chartArea4.Name = "ChartArea1";
            this.chartDistrict.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartDistrict.Legends.Add(legend4);
            this.chartDistrict.Location = new System.Drawing.Point(356, 212);
            this.chartDistrict.Name = "chartDistrict";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Legend1";
            series4.Name = "district";
            this.chartDistrict.Series.Add(series4);
            this.chartDistrict.Size = new System.Drawing.Size(371, 214);
            this.chartDistrict.TabIndex = 7;
            this.chartDistrict.Text = "chart1";
            title2.Name = "district";
            title2.Text = "Sales by District";
            this.chartDistrict.Titles.Add(title2);
            // 
            // SalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartDistrict);
            this.Controls.Add(this.chartCity);
            this.Controls.Add(this.chartNumberOfSalesMade);
            this.Controls.Add(this.chartRevenue);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.lblSearchDateTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.SearchDateFrom);
            this.Name = "SalesReportForm";
            this.Text = "SalesReportForm";
            this.Load += new System.EventHandler(this.SalesReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNumberOfSalesMade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistrict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchDateFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label lblSearchDateTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNumberOfSalesMade;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDistrict;
    }
}