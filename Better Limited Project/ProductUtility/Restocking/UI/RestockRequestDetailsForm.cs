using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.ProductList.Forms;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.ProductUtility.Restocking.Controller;
using Better_Limited_Project.ProductUtility.Restocking.Entity;
using Better_Limited_Project.ProductUtility.Restocking.Repository;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.Restocking.UI
{
    public partial class RestockRequestDetailsForm : Form
    {
        private RestockRequest _restockRequest;

        public RestockRequestDetailsForm(RestockRequest restockRequest)
        {
            _restockRequest = restockRequest;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Shown += (_, _) => Initialize();
        }

        public event EventHandler? Updated;

        private void Initialize()
        {
            btnUnsendRequest.Click += BtnUnsendRequestOnClick;
            btnSetAsReceived.Click += BtnSetAsReceivedOnClick;
            if (LoginSession.GetSession().CurrentStaff.Department is not Department.Sales)
            {
                btnSetAsReceived.Visible = false;
                btnUnsendRequest.Visible = false;
            }

            if (_restockRequest.IsReceived())
                btnSetAsReceived.Visible = false;
            dgvRequestedGoods.CellDoubleClick += dgvRequestedGoods_CellDoubleClick;
            if (_restockRequest.IsArranged())
                btnUnsendRequest.Visible = false;
            FillFields();
        }

        private void BtnSetAsReceivedOnClick(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Confirm receiving goods?", "Confirmation", MessageBoxButtons.OKCancel);
            if (result is not DialogResult.OK)
                return;

            RestockStockUpdateService.Receive(_restockRequest.RequestedForRetailStore, _restockRequest);
            _restockRequest = RestockRequestRepository.FindById(_restockRequest.Id);
            Updated?.Invoke(this, EventArgs.Empty);
            Initialize();
        }

        private void BtnUnsendRequestOnClick(object sender, EventArgs e)
        {
            if (_restockRequest.IsArranged())
                return;
            var result = MessageBox.Show("Confirm unsending request?", "Confirmation", MessageBoxButtons.OKCancel);
            if (result is not DialogResult.OK)
                return;

            _restockRequest.Remove();
            Updated?.Invoke(this, EventArgs.Empty);
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
            if (LoginSession.GetSession().CurrentStaff.Department is not Department.Sales)
                btnUnsendRequest.Visible = false;

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