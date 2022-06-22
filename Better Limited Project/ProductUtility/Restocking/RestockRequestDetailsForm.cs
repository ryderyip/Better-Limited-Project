using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.ProductList.Forms;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.SettingsUtility;

namespace Better_Limited_Project.ProductUtility.Restocking
{
    public partial class RestockRequestDetailsForm : Form
    {
        public event EventHandler? RequestRemoved;
        private readonly RestockRequest _restockRequest;

        public RestockRequestDetailsForm(RestockRequest restockRequest)
        {
            _restockRequest = restockRequest;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Shown += (_, _) => Initialize();
        }

        private void Initialize()
        {
            btnUnsendRequest.Click += BtnUnsendRequestOnClick;
            dgvRequestedGoods.CellDoubleClick += dgvRequestedGoods_CellDoubleClick;
            if (_restockRequest.IsArranged())
                btnUnsendRequest.Visible = false;
            FillFields();
        }

        private void BtnUnsendRequestOnClick(object sender, EventArgs e)
        {
            if (_restockRequest.IsArranged())
                return;
            var result = MessageBox.Show("Confirm unsending request?", "Confirmation", MessageBoxButtons.OKCancel);
            if (result is not DialogResult.OK)
                return;
            
            _restockRequest.Remove();
            RequestRemoved?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private void FillFields()
        {
            tbRequestNumber.Text = _restockRequest.RequestNumber;
            tbRequestedOn.Text = _restockRequest.RequestedOn.ToString("f");
            tbWarehouseName.Text = _restockRequest.RequestedForRetailStore.Name;
            tbRequestedByStaffName.Text = _restockRequest.RequestedByStaff.Name;
            tbIsArranged.Text = _restockRequest.IsArranged() ? "Yes" : "No";
            if (_restockRequest.IsArranged())
            {
                tbArrangedByStaffName.Text = _restockRequest.ArrangedByStaff!.Name;
                tbArrangedOn.Text = _restockRequest.ArrangedOn!.Value.ToString("f");
            }

            if (_restockRequest.ReceivedOn != null)
                tbGoodsReceivedOn.Text = _restockRequest.ReceivedOn.Value.ToString("f");

            var requestedProducts = _restockRequest.RequestedProducts.ToList();
            tbNoOfProducts.Text = requestedProducts.Count.ToString();
            PopulateRequestedGoodsDgv(requestedProducts);
        }

        private void PopulateRequestedGoodsDgv(List<RestockRequestProduct> requestedProducts)
        {
            dgvRequestedGoods.Rows.Clear();
            requestedProducts.ForEach(rp => dgvRequestedGoods.Rows.Add(rp.ProductId,
                rp.Product.Name, rp.Quantity, rp.Product.Category.Name));
        }

        private void dgvRequestedGoods_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new ProductDetailsForm(StockRepository.FindByIds(UserSettings.GetSettings().Workplace!.Id,
                dgvRequestedGoods.Rows[e.RowIndex].Cells[requestedProductIdColumn.Name].Value.ToString())).ShowDialog();
        }
    }
}
