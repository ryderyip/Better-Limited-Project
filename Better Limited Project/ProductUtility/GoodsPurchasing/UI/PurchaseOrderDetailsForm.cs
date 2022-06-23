using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.GoodsPurchasing.Entity;
using Better_Limited_Project.ProductUtility.InwardGoodsUtility.UI;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.GoodsPurchasing.UI
{
    public partial class PurchaseOrderDetailsForm : Form
    {
        private readonly List<PurchaseOrderProduct> _orderProducts;
        private readonly PurchaseOrder _purchaseOrder;

        public PurchaseOrderDetailsForm(PurchaseOrder purchaseOrder)
        {
            StartPosition = FormStartPosition.CenterScreen;
            _purchaseOrder = purchaseOrder;
            _orderProducts = _purchaseOrder.OrderProducts.ToList();
            InitializeComponent();
            Load += (_, _) => Initialize();
        }

        private void Initialize()
        {
            var currentStaff = LoginSession.GetSession().CurrentStaff;
            if (currentStaff.Department is not Department.Accounting
                || _purchaseOrder.IsApproved())
                btnApproveAndSend.Visible = false;
            if (currentStaff.Title is StaffTitle.ReceivingClerk
                && _purchaseOrder.GetNotYetReceivedProducts().Any())
                btnCreateInwardGoodsRecord.Visible = true;
            FillFields();
            PopulateDgv();
        }

        private void FillFields()
        {
            tbPurchaseOrderNumber.Text = _purchaseOrder.PurchaseOrderNumber;
            tbCreatedOn.Text = _purchaseOrder.CreatedOn.ToString("f");
            tbCreatedByStaff.Text = _purchaseOrder.CreatedByStaff.Name;
            tbWarehouseName.Text = _purchaseOrder.ReorderRequest.Warehouse.Name;
            tbIsApproved.Text = _purchaseOrder.IsApproved() ? "Yes" : "No";
            if (_purchaseOrder.ApprovedByStaff != null)
                tbApprovedByStaffName.Text = _purchaseOrder.ApprovedByStaff.Name;
            if (_purchaseOrder.ApprovedOn != null)
                tbApprovedOn.Text = _purchaseOrder.ApprovedOn.Value.ToString("f");
            if (_purchaseOrder.SentToSupplierOn != null)
                tbSentToSupplierOn.Text = _purchaseOrder.SentToSupplierOn.Value.ToString("f");
            tbNoOfProducts.Text = _orderProducts.Count.ToString();
            tbEstimatedTotalCost.Text = _purchaseOrder.GetTotalCost().ToString("C", new CultureInfo("zh-HK"));
        }

        private void PopulateDgv()
        {
            dgvGoodsToOrder.Rows.Clear();
            foreach (var orderProduct in _purchaseOrder.OrderProducts)
                dgvGoodsToOrder.Rows.Add(orderProduct.ProductId,
                    orderProduct.Product.Name,
                    orderProduct.Product.OriginalPrice.ToString("C", new CultureInfo("zh-HK")),
                    orderProduct.Quantity,
                    orderProduct.Product.Category.Name);
        }

        private void btnApproveAndSend_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Confirm approving purchase order and sending it to the supplier(s)?",
                "Confirmation", MessageBoxButtons.YesNo);
            if (result is not DialogResult.Yes)
                return;

            _purchaseOrder.ApprovedByStaffId = LoginSession.GetSession().CurrentStaff.Id;
            _purchaseOrder.ApprovedOn = DateTime.Now;
            _purchaseOrder.SentToSupplierOn = DateTime.Now;
            _purchaseOrder.Save();
            Initialize();
        }

        private void btnCreateInwardGoodsRecord_Click(object sender, EventArgs e)
        {
            var form = new NewInwardGoodsRecordForm();
            var result = form.ShowDialog();
            if (result is DialogResult.OK)
                Initialize();
        }
    }
}