using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.Sales.PaymentUtility.Repository;
using Better_Limited_Project.StaffUtility.Repository;

namespace Better_Limited_Project.DataAnalytics.UI
{
    public partial class SalesAnalyticsForm : Form
    {
        private readonly List<SalesOrder> _salesOrders = new();

        public SalesAnalyticsForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Load += (_, _) => Initialize();
        }

        private async void Initialize()
        {
            dtpSalesDataFrom.ValueChanged += (_, _) => RefreshGraphs();
            dtpSalesDataTo.ValueChanged += (_, _) => RefreshGraphs();
            dtpSalesDataFrom.ValueChanged += (_, _) => dtpSalesDataTo.MinDate = dtpSalesDataFrom.Value.Date;
            dtpSalesDataTo.ValueChanged += (_, _) => dtpSalesDataFrom.MaxDate = dtpSalesDataTo.Value.Date;
            AutoScroll = false;
            SetAllControlsVisibility(false);
            progressBar.Enabled = progressBar.Visible = true;

            var cancellationToken = new CancellationTokenSource();
            Closing += (_, _) => cancellationToken.Cancel();
            await Task.Run(LoadSalesOrders, cancellationToken.Token);
            if (cancellationToken.IsCancellationRequested)
                return;
            SetAllControlsVisibility(true);
            progressBar.Enabled = progressBar.Visible = false;
            AutoScroll = true;
            dtpSalesDataFrom.MinDate = _salesOrders.Min(so => so.CreatedOn.Date);
            dtpSalesDataTo.MaxDate = _salesOrders.Max(so => so.CreatedOn.Date);
            dtpSalesDataFrom.Value = dtpSalesDataFrom.MinDate;
            dtpSalesDataTo.Value = dtpSalesDataTo.MaxDate;

            LoadNoOfSalesGraph(_salesOrders);
            LoadRevenueChart();
            LoadSalesByDistrict(_salesOrders);
        }

        private void SetAllControlsVisibility(bool isVisible)
        {
            foreach (var control in Controls.Cast<Control>())
                control.Visible = isVisible;
        }

        private void RefreshGraphs()
        {
            var fromDate = dtpSalesDataFrom.Value.Date;
            var toDate = dtpSalesDataTo.Value.Date;
            var salesOrders = _salesOrders.Where(so => so.CreatedOn.Date > fromDate && so.CreatedOn.Date < toDate)
                .ToList();
            
            LoadNoOfSalesGraph(salesOrders);
            LoadRevenueChart();
            LoadSalesByDistrict(salesOrders);
        }

        private void LoadSalesByDistrict(List<SalesOrder> salesOrders)
        {
            chartSalesByDistrict.Series["district"].Points.Clear();
            var kowloonRetailStore = new RetailStoreRepository().GetById("KB01");
            var tsuenWanRetailStore = new RetailStoreRepository().GetById("TW01");
            int kowloonBayNoOfSales = salesOrders
                .Count(so => so.RetailStore.Id == kowloonRetailStore.Id);
            int tsuenWanNoOfSales = salesOrders
                .Count(so => so.RetailStore.Id == tsuenWanRetailStore.Id);
            chartSalesByDistrict.Series["district"].Points.AddXY("Kowloon Bay", kowloonBayNoOfSales);
            chartSalesByDistrict.Series["district"].Points.AddXY("Tsuen Wan", tsuenWanNoOfSales);
        }

        private void LoadRevenueChart()
        {
            chartRevenue.Series["revenue"].Points.Clear();
            var fromDate = dtpSalesDataFrom.Value.Date;
            var toDate = dtpSalesDataTo.Value.Date;
            var payments = PaymentRepository.FindAll(p => p.PaidOn.Date > fromDate.Date && p.PaidOn.Date < toDate.Date).ToList();
            tbTotalRevenue.Text = payments.Sum(p => p.Amount).ToString("C0", new CultureInfo("zh-HK"));
            var isSameMonth = fromDate.Month == toDate.Month;
            if (isSameMonth)
            {
                var weekRevenueTuples = payments.GroupBy(p => p.PaidOn.Day / 7 + 1)
                    .Select(weekRevenue => new Tuple<int, double>(weekRevenue.Key, (double) weekRevenue.Sum(p => p.Amount)));
                chartRevenue.Titles[0].Text = "Revenue by Week";
                foreach (var weekRevenueTuple in weekRevenueTuples)
                    chartRevenue.Series["revenue"].Points.AddXY($"Week {weekRevenueTuple.Item1}",
                        weekRevenueTuple.Item2);
            }
            else
            {
                var monthRevenueTuples = payments.GroupBy(p => p.PaidOn.Month)
                    .Select(monthRevenue => new Tuple<int, double>(monthRevenue.Key, (double) monthRevenue.Sum(p => p.Amount)))
                    .OrderBy(monthRevenue => monthRevenue.Item1);
                chartRevenue.Titles[0].Text = "Revenue by Month";
                foreach (var monthRevenueTuple in monthRevenueTuples)
                {
                    string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthRevenueTuple.Item1);
                    chartRevenue.Series["revenue"].Points.AddXY(monthName, monthRevenueTuple.Item2);
                }
            }
        }

        private async Task LoadSalesOrders()
        {
            _salesOrders.AddRange(await new SalesOrderRepository().GetAllAsync());
        }

        private void LoadNoOfSalesGraph(List<SalesOrder> salesOrders)
        {
            noOfSalesMadeLineGraph.Series["sales1"].Points.Clear();
            noOfSalesMadeLineGraph.Series["sales2"].Points.Clear();
            var kowloonRetailStore = new RetailStoreRepository().GetById("KB01");
            var tsuenWanRetailStore = new RetailStoreRepository().GetById("TW01");

            var dateNoOfSalesKowloonRetailTuple = salesOrders
                .Where(so => so.RetailStore.Id == kowloonRetailStore.Id)
                .GroupBy(so => so.CreatedOn.Date)
                .Select(dateOrder => new Tuple<DateTime, int>(dateOrder.Key, dateOrder.Count()))
                .OrderBy(tuple => tuple.Item1)
                .ToList();
            var dateNoOfSalesTsuenRetailTuple = salesOrders
                .Where(so => so.RetailStore.Id == tsuenWanRetailStore.Id)
                .GroupBy(so => so.CreatedOn.Date)
                .Select(dateOrder => new Tuple<DateTime, int>(dateOrder.Key, dateOrder.Count()))
                .OrderBy(tuple => tuple.Item1)
                .ToList();

            dateNoOfSalesKowloonRetailTuple.ForEach(tuple =>
                noOfSalesMadeLineGraph.Series["sales1"].Points.AddXY(tuple.Item1.ToString("MM/dd"), tuple.Item2));

            dateNoOfSalesTsuenRetailTuple.ForEach(tuple =>
                noOfSalesMadeLineGraph.Series["sales2"].Points.AddXY(tuple.Item1.ToString("MM/dd"), tuple.Item2));
        }
    }
}