namespace Better_Limited_Project.DataAnalytics.UI
{
    partial class SalesAnalyticsForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lblSalesDataFrom = new System.Windows.Forms.Label();
            this.dtpSalesDataFrom = new System.Windows.Forms.DateTimePicker();
            this.lblSalesDataTo = new System.Windows.Forms.Label();
            this.dtpSalesDataTo = new System.Windows.Forms.DateTimePicker();
            this.noOfSalesMadeLineGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSalesByDistrict = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbTotalRevenue = new System.Windows.Forms.TextBox();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.noOfSalesMadeLineGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesByDistrict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalesDataFrom
            // 
            this.lblSalesDataFrom.AutoSize = true;
            this.lblSalesDataFrom.Location = new System.Drawing.Point(23, 22);
            this.lblSalesDataFrom.Name = "lblSalesDataFrom";
            this.lblSalesDataFrom.Size = new System.Drawing.Size(85, 13);
            this.lblSalesDataFrom.TabIndex = 0;
            this.lblSalesDataFrom.Text = "Sales Data From";
            // 
            // dtpSalesDataFrom
            // 
            this.dtpSalesDataFrom.Location = new System.Drawing.Point(25, 49);
            this.dtpSalesDataFrom.Name = "dtpSalesDataFrom";
            this.dtpSalesDataFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpSalesDataFrom.TabIndex = 1;
            // 
            // lblSalesDataTo
            // 
            this.lblSalesDataTo.AutoSize = true;
            this.lblSalesDataTo.Location = new System.Drawing.Point(355, 22);
            this.lblSalesDataTo.Name = "lblSalesDataTo";
            this.lblSalesDataTo.Size = new System.Drawing.Size(20, 13);
            this.lblSalesDataTo.TabIndex = 2;
            this.lblSalesDataTo.Text = "To";
            // 
            // dtpSalesDataTo
            // 
            this.dtpSalesDataTo.Location = new System.Drawing.Point(357, 49);
            this.dtpSalesDataTo.Name = "dtpSalesDataTo";
            this.dtpSalesDataTo.Size = new System.Drawing.Size(200, 20);
            this.dtpSalesDataTo.TabIndex = 3;
            // 
            // noOfSalesMadeLineGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.noOfSalesMadeLineGraph.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Legend1";
            this.noOfSalesMadeLineGraph.Legends.Add(legend1);
            this.noOfSalesMadeLineGraph.Location = new System.Drawing.Point(26, 430);
            this.noOfSalesMadeLineGraph.Name = "noOfSalesMadeLineGraph";
            this.noOfSalesMadeLineGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.LegendText = "Kowloon Bay";
            series1.Name = "sales1";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.LegendText = "Tsuen Wan";
            series2.Name = "sales2";
            this.noOfSalesMadeLineGraph.Series.Add(series1);
            this.noOfSalesMadeLineGraph.Series.Add(series2);
            this.noOfSalesMadeLineGraph.Size = new System.Drawing.Size(531, 233);
            this.noOfSalesMadeLineGraph.TabIndex = 5;
            this.noOfSalesMadeLineGraph.Text = "chart2";
            title1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "No. of Sales Made";
            this.noOfSalesMadeLineGraph.Titles.Add(title1);
            // 
            // chartSalesByDistrict
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSalesByDistrict.ChartAreas.Add(chartArea2);
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend2.Name = "Legend1";
            this.chartSalesByDistrict.Legends.Add(legend2);
            this.chartSalesByDistrict.Location = new System.Drawing.Point(26, 692);
            this.chartSalesByDistrict.Name = "chartSalesByDistrict";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "district";
            this.chartSalesByDistrict.Series.Add(series3);
            this.chartSalesByDistrict.Size = new System.Drawing.Size(371, 232);
            this.chartSalesByDistrict.TabIndex = 7;
            this.chartSalesByDistrict.Text = "chart1";
            title2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "district";
            title2.Text = "Sales by District";
            this.chartSalesByDistrict.Titles.Add(title2);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(175, 208);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(236, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 8;
            // 
            // chartRevenue
            // 
            chartArea3.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea3);
            this.chartRevenue.Location = new System.Drawing.Point(26, 174);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.IsVisibleInLegend = false;
            series4.LegendText = "Revenue";
            series4.Name = "revenue";
            this.chartRevenue.Series.Add(series4);
            this.chartRevenue.Size = new System.Drawing.Size(531, 233);
            this.chartRevenue.TabIndex = 9;
            title3.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            title3.Name = "chartRevenueTitle";
            this.chartRevenue.Titles.Add(title3);
            // 
            // tbTotalRevenue
            // 
            this.tbTotalRevenue.Location = new System.Drawing.Point(26, 111);
            this.tbTotalRevenue.Name = "tbTotalRevenue";
            this.tbTotalRevenue.ReadOnly = true;
            this.tbTotalRevenue.Size = new System.Drawing.Size(194, 20);
            this.tbTotalRevenue.TabIndex = 140;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTotalRevenue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotalRevenue.Location = new System.Drawing.Point(23, 93);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(156, 15);
            this.lblTotalRevenue.TabIndex = 139;
            this.lblTotalRevenue.Text = "Total Revenue As of Today";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(367, 845);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 141;
            // 
            // SalesAnalyticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(596, 924);
            this.Controls.Add(this.tbTotalRevenue);
            this.Controls.Add(this.lblTotalRevenue);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.chartRevenue);
            this.Controls.Add(this.chartSalesByDistrict);
            this.Controls.Add(this.noOfSalesMadeLineGraph);
            this.Controls.Add(this.dtpSalesDataTo);
            this.Controls.Add(this.lblSalesDataTo);
            this.Controls.Add(this.dtpSalesDataFrom);
            this.Controls.Add(this.lblSalesDataFrom);
            this.Controls.Add(this.panel1);
            this.Name = "SalesAnalyticsForm";
            this.Text = "SalesAnalyticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.noOfSalesMadeLineGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesByDistrict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalesDataFrom;
        private System.Windows.Forms.DateTimePicker dtpSalesDataFrom;
        private System.Windows.Forms.Label lblSalesDataTo;
        private System.Windows.Forms.DateTimePicker dtpSalesDataTo;
        private System.Windows.Forms.DataVisualization.Charting.Chart noOfSalesMadeLineGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSalesByDistrict;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.TextBox tbTotalRevenue;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Panel panel1;
    }
}