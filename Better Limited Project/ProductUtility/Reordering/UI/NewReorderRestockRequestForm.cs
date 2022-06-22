using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Reordering.Controller;
using Better_Limited_Project.ProductUtility.Reordering.Entity;
using Better_Limited_Project.ProductUtility.UI;

namespace Better_Limited_Project.ProductUtility.Reordering.UI
{
    public partial class NewReorderRestockRequestForm : Form
    {
        private List<IProductQuantity> _selectedProducts = new();
        private readonly IReorderRestockService _reorderRestockService;

        public NewReorderRestockRequestForm(IReorderRestockService reorderRestockService)
        {
            _reorderRestockService = reorderRestockService;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Load += (_, _) => Initialize();
        }

        private void Initialize()
        {
            dgvRequestedGoods.RowsAdded += (_, _) => DisableSubmitButtonIfNoProductSelected();
            dgvRequestedGoods.RowsRemoved += (_, _) => DisableSubmitButtonIfNoProductSelected();
        }

        private void CalculateMetaData()
        {
            if (_selectedProducts.Count == 0)
            {
                tbNoOfProducts.Text = "-";
                tbEstimatedTotalCost.Text = "-";
            }

            tbNoOfProducts.Text = _selectedProducts.Count.ToString();
            if (_reorderRestockService is ReorderService)
                tbEstimatedTotalCost.Text =
                    _selectedProducts.Sum(sp => sp.Product.OriginalPrice * sp.Quantity)
                        .ToString("C", new CultureInfo("zh-HK"));
        }

        private void DisableSubmitButtonIfNoProductSelected()
        {
            btnSendRequest.Enabled = dgvRequestedGoods.RowCount != 0;
        }

        private void btnSelectGoods_Click(object sender, EventArgs e)
        {
            var form = new GoodsPickerForm(_selectedProducts);
            var result = form.ShowDialog();
            if (result is not DialogResult.OK)
                return;
            dgvRequestedGoods.Rows.Clear();
            form.SelectedProducts.ForEach(sp =>
                dgvRequestedGoods.Rows.Add(sp.ProductId, sp.Product.Name, sp.Product.OriginalPrice, sp.Quantity,
                    sp.Product.Category.Name));
            _selectedProducts = form.SelectedProducts;
            CalculateMetaData();
        }

        private void btnSendReorderRequest_Click(object sender, EventArgs e)
        {
            if (_selectedProducts.Count == 0)
                return;

            var result = MessageBox.Show("Confirm Sending Reorder/Restock Request?", "Confirmation",
                MessageBoxButtons.OKCancel);
            if (result is not DialogResult.OK) return;

            _reorderRestockService.AddRange(_selectedProducts);
            _reorderRestockService.Submit();

            DialogResult = DialogResult.OK;
        }
    }
}