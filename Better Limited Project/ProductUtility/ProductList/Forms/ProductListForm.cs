using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Login;
using Better_Limited_Project.PermissionManagement.Permissions;
using Better_Limited_Project.PermissionManagement.Repository;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.ProductUtility.ProductList.Forms
{
    public partial class ProductListForm : Form
    {
        private readonly List<IWorkplace> _workplaces;
        private readonly Staff _currentStaff;
        private List<IStock> _stocks;

        public ProductListForm()
        {
            _workplaces = WorkplaceRepository.GetWorkplaces().ToList();
            _currentStaff = LoginSession.GetSession().CurrentStaff;
            _stocks = GetStockByWorkplaceType();
            Shown += (_, _) => Initialize();
            InitializeComponent();
        }

        private List<IStock> GetStockByWorkplaceType()
        {
            return _currentStaff.Department is Department.Sales
                ? StockRepository.GetStocks(UserSettings.GetSettings().Workplace!.Id).ToList()
                : StockRepository.GetStocks(_workplaces.First(w => w is Warehouse).Id).ToList();
        }

        private void Initialize()
        {
            var currentStaffTitle = LoginSession.GetSession().CurrentStaff.Title;
            btnNewProduct.Visible = PermissionRepository
                .FindBy(Permission.CanStaffCreateProduct).PermissionMap(currentStaffTitle);
            if (PermissionRepository.FindBy(Permission.CanStaffViewAllWorkplaceProductStocksInProductListView)
                .PermissionMap(currentStaffTitle))
            {
                gpWorkplaceSelect.Visible = true;
                _workplaces.ForEach(workplace => cbWorkplaceSelect.Items.Add(workplace.Name));
                cbWorkplaceSelect.SelectedIndex = 0;
            }
            else
                gpWorkplaceSelect.Visible = false;

            PopulateProductDgv(_stocks);

            cbCategoryFilter.Items.Add(string.Empty);
            cbCategoryFilter.SelectedIndex = 0;
            CategoryRepository.GetAll().ToList().ForEach(c => cbCategoryFilter.Items.Add(c.Name));
        }

        private void PopulateProductDgv(List<IStock> stocks)
        {
            dgvProductList.Rows.Clear();
            if (stocks.Count == 0)
                return;

            if (stocks.First() is RetailStoreStock)
                PopulateProductDgvWithSellingPrice(stocks);
            else
                PopulateProductDgvNoSellingPrice(stocks);

            // if stock is lower than restock level set color
            dgvProductList.Rows.Cast<DataGridViewRow>()
                .Where(row =>
                {
                    var product = stocks
                        .Find(s => s.Product.Name == row.Cells[name.Name].Value.ToString());
                    return product.Quantity <= product.RestockLevel;
                }).ToList()
                .ForEach(row => row.DefaultCellStyle.BackColor = FormColors.DgvRowAttentionWeak);

            // if stock is 0 set color
            dgvProductList.Rows.Cast<DataGridViewRow>()
                .Where(row =>
                {
                    var product = stocks
                        .Find(s => s.Product.Name == row.Cells[name.Name].Value.ToString());
                    return product.Quantity == 0;
                }).ToList()
                .ForEach(row => row.DefaultCellStyle.BackColor = FormColors.DgvRowAttention);
        }

        private void PopulateProductDgvNoSellingPrice(List<IStock> stocks)
        {
            dgvProductList.Columns["selling_price"]!.Visible = false;
            stocks.ForEach(stock => dgvProductList.Rows.Add(stock.Product.Name,
                $"{stock.Quantity} ({stock.RestockLevel})", 0, stock.Product.Category.Name));
        }

        private void PopulateProductDgvWithSellingPrice(List<IStock> stocks)
        {
            dgvProductList.Columns["selling_price"]!.Visible = true;
            stocks.Cast<RetailStoreStock>().ToList()
                .ForEach(stock => dgvProductList.Rows.Add(stock.Product.Name,
                    $"{stock.Quantity} ({stock.RestockLevel})",
                    stock.SellingPrice == decimal.Zero
                        ? "-"
                        : stock.SellingPrice.ToString("C", new CultureInfo("zh-HK")),
                    stock.Product.Category.Name));
        }

        private IWorkplace GetSelectedWorkplace()
        {
            return _workplaces[cbWorkplaceSelect.SelectedIndex];
        }

        private void dgvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedProductName = dgvProductList.Rows[e.RowIndex].Cells["name"].Value.ToString();
            var selectedProductStock = _stocks.Find(stock => stock.Product.Name == selectedProductName);
            var form = new ProductDetailsForm(selectedProductStock);
            form.ProductUpdated += (_, _) => RefreshProductDgv();
            form.ProductUpdated += (_, _) => FilterProductDgv();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            var form = new NewProductForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ProductCreated += (_, _) => RefreshProductDgv();
            form.ProductCreated += (_, _) => FilterProductDgv();
            form.ShowDialog();
        }

        private void RefreshProductDgv()
        {
            _stocks = GetStockByWorkplaceType();
            PopulateProductDgv(_stocks);
            tbSearchBox.Text = string.Empty;
        }

        private void ProductListForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().Equals("/"))
                tbSearchBox.Focus();
        }

        private void tbSearchBox_TextChanged(object sender, EventArgs e)
        {
            FilterProductDgv();
        }

        private void cbCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterProductDgv();
        }

        private void FilterProductDgv()
        {
            PopulateProductDgv(GetFilteredStock());
        }

        private List<IStock> GetFilteredStock()
        {
            _stocks = _currentStaff.Department is Department.Sales or Department.Inventory
                ? _stocks
                : StockRepository.GetStocks(GetSelectedWorkplace().Id).ToList();

            string keyword = tbSearchBox.Text.ToLower();

            if (cbCategoryFilter.SelectedItem == null)
                return _stocks.Where(s => s.Product.Name.ToLower().Contains(keyword)).ToList();
            string selectedCategoryName = cbCategoryFilter.SelectedItem.ToString();
            return _stocks.Where(s => s.Product.Category.Name.Contains(selectedCategoryName)
                                      && s.Product.Name.ToLower().Contains(keyword)).ToList();
        }

        private void cbWorkplaceSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterProductDgv();
        }
    }
}