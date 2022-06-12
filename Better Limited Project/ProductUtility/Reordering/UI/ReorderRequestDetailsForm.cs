using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.GoodsPurchasing.Controller;
using Better_Limited_Project.ProductUtility.ProductList.Forms;
using Better_Limited_Project.ProductUtility.Reordering.Entity;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.Reordering.UI
{
    public partial class ReorderRequestDetailsForm : Form
    {
        private readonly ReorderRequest _reorderRequest;

        public ReorderRequestDetailsForm(ReorderRequest reorderRequest)
        {
            _reorderRequest = reorderRequest;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Shown += (_, _) => Initialize();
        }

        private void Initialize()
        {
            if (LoginSession.GetSession().CurrentStaff.Department is Department.Purchase)
                btnApproveRequestAndCreatePurchaseOrder.Visible = true;
            else
                btnUnsendRequest.Visible = true;
            if (_reorderRequest.IsApproved())
            {
                btnApproveRequestAndCreatePurchaseOrder.Visible = false;
                btnUnsendRequest.Visible = false;
            }
            FillFields();
        }

        private void FillFields()
        {
            tbRequestNumber.Text = _reorderRequest.RequestNumber;
            tbRequestedOn.Text = _reorderRequest.RequestedOn.ToString("f");
            tbWarehouseName.Text = _reorderRequest.Warehouse.Name;
            tbRequestedByStaffName.Text = _reorderRequest.RequestedByStaff.Name;
            tbIsApproved.Text = _reorderRequest.IsApproved() ? "Yes" : "No";
            if (_reorderRequest.IsApproved())
            {
                tbApprovedByStaffName.Text = _reorderRequest.ApprovedByStaff!.Name;
                tbApprovedOn.Text = _reorderRequest.ApprovedOn!.Value.ToString("f");
            }

            var requestedProducts = _reorderRequest.RequestedProducts.ToList();
            tbNoOfProducts.Text = requestedProducts.Count.ToString();
            tbEstimatedTotalCost.Text = requestedProducts.Sum(sp => sp.Product.OriginalPrice * sp.Quantity)
                .ToString("C", new CultureInfo("zh-HK"));
            PopulateRequestedGoodsDgv(requestedProducts);
        }

        private void PopulateRequestedGoodsDgv(List<ReorderRequestProduct> requestedProducts)
        {
            dgvRequestedGoods.Rows.Clear();
            requestedProducts.ForEach(rp => dgvRequestedGoods.Rows.Add(rp.ProductId,
                rp.Product.Name, rp.Product.OriginalPrice.ToString("C", new CultureInfo("zh-HK")),
                rp.Quantity, rp.Product.Category.Name));
        }

        private void btnUnsendRequest_Click(object sender, EventArgs e)
        {
            if (_reorderRequest.IsApproved())
                return;
            var result = MessageBox.Show("Confirm unsending request?", "Confirmation", MessageBoxButtons.OKCancel);
            if (result is not DialogResult.OK)
                return;
            
            _reorderRequest.Remove();
            DialogResult = DialogResult.OK;
        }

        private void dgvRequestedGoods_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new ProductDetailsForm(StockRepository.FindByIds(UserSettings.GetSettings().Workplace!.Id,
                dgvRequestedGoods.Rows[e.RowIndex].Cells[requestedProductIdColumn.Name].Value.ToString())).ShowDialog();
        }

        private void btnApproveRequestAndCreatePurchaseOrder_Click(object sender, System.EventArgs e)
        {
            var result = MessageBox.Show("Confirm approving request and create purchase order?", "Confirmation", MessageBoxButtons.YesNo);
            if (result is not DialogResult.Yes)
                return;
            
            var service = new PurchaseOrderCreationService(_reorderRequest);
            service.AddRangeOrderProducts(_reorderRequest.RequestedProducts);
            service.Create();
            Initialize();
        }
    }
}
