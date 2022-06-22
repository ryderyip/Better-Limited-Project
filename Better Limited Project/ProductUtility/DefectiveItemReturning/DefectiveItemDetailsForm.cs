using System;
using System.Windows.Forms;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.ProductList.Forms;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.ProductUtility.SupplierUtility;
using Better_Limited_Project.Properties;
using Better_Limited_Project.Sales.OrderPlacing.UI;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.DefectiveItemReturning
{
    public partial class DefectiveItemDetailsForm : Form
    {
        private readonly DefectiveItem _defectiveItem;

        public DefectiveItemDetailsForm(DefectiveItem defectiveItem)
        {
            _defectiveItem = defectiveItem;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Shown += (_, _) => Initialize();
        }

        private void Initialize()
        {
            var currentStaffDepartment = LoginSession.GetSession().CurrentStaff.Department;
            if (_defectiveItem.SalesOrder.Customer == null)
                btnCustomerDetailedInfo.Visible = false;
            if (_defectiveItem.IsReturnedToWarehouse())
                btnSetAsReceivedItem.Visible = false;
            if (_defectiveItem.IsReturnApproved() || currentStaffDepartment is not Department.Accounting)
                btnApproveItemReturn.Visible = false;
            if (currentStaffDepartment is not Department.Inventory)
            {
                btnSetAsReceivedItem.Visible = false;
                btnSetAsReturnedToSupplier.Visible = false;
            }

            btnSetAsReturnedToSupplier.Visible = currentStaffDepartment is Department.Inventory &&
                                                 !_defectiveItem.IsReturnedToSupplier() &&
                                                 _defectiveItem.IsReturnedToWarehouse() &&
                                                 _defectiveItem.IsReturnApproved();
            FillFields();
        }

        private void FillFields()
        {
            tbOrderNumber.Text = _defectiveItem.SalesOrder.OrderNumber;
            tbReturnedToRetailStoreOn.Text = _defectiveItem.ReturnedToRetailStoreOn.ToString("g");
            tbDescription.Text = _defectiveItem.Description;
            tbRetailStoreName.Text = _defectiveItem.RetailStore.Name;
            if (_defectiveItem.ReturnedToWarehouseOn != null)
                tbReturnedToWarehouseOn.Text = _defectiveItem.ReturnedToWarehouseOn.Value.ToString("g");
            if (_defectiveItem.ReturnedToSupplierOn != null)
                tbReturnedToSupplierOn.Text = _defectiveItem.ReturnedToSupplierOn.Value.ToString("g");
            if (_defectiveItem.Image != null)
                pbImageEvidence.Image = _defectiveItem.Image;
            tbCreatedByStaffName.Text = _defectiveItem.CreatedByStaff.Name;
            if (_defectiveItem.ReturnApprovedOn != null)
                tbReturnApprovedOn.Text = _defectiveItem.ReturnApprovedOn.Value.ToString("g");
            if (_defectiveItem.SalesOrder.Customer != null)
            {
                tbCustomerName.Text = _defectiveItem.SalesOrder.Customer.Name;
                tbCustomerPhone.Text = _defectiveItem.SalesOrder.Customer.Phone;
            }

            if (_defectiveItem.Warehouse != null)
                tbWarehouse.Text = _defectiveItem.Warehouse.Name;
            if (_defectiveItem.ReturnApprovedOn != null)
                tbReturnApprovedOn.Text = _defectiveItem.ReturnApprovedOn.Value.ToString("g");
            pbImageEvidence.Image = _defectiveItem.Image ?? Resources.no_image;
        }

        private void btnSalesOrder_Click(object sender, EventArgs e)
        {
            var form = new SalesOrderDetailsForm(_defectiveItem.SalesOrder);
            form.ShowDialog();
        }

        private void btnCustomerDetailedInfo_Click(object sender, EventArgs e)
        {
            var form = new CustomerDetailsForm(_defectiveItem.SalesOrder.Customer!);
            form.ShowDialog();
        }

        private void btnApproveItemReturn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Confirm approving return of item(s)?", "Confirmation",
                MessageBoxButtons.YesNo);
            if (result is not DialogResult.Yes)
                return;
            _defectiveItem.ReturnApprovedOn = DateTime.Now;
            _defectiveItem.Save();
            Initialize();
        }

        private void btnViewProductInfo_Click(object sender, EventArgs e)
        {
            var productStock =
                StockRepository.FindByIds(UserSettings.GetSettings().Workplace!.Id, _defectiveItem.ProductId);
            var form = new ProductDetailsForm(productStock);
            form.ShowDialog();
        }

        private void btnViewSupplierInfo_Click(object sender, EventArgs e)
        {
            var form = new SupplierDetailsForm(_defectiveItem.Product.Supplier);
            form.ShowDialog();
        }

        private void btnSetAsReceivedItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Confirm receiving defective item(s) from retail store?", "Confirmation",
                MessageBoxButtons.YesNo);
            if (result is not DialogResult.Yes)
                return;
            _defectiveItem.ReturnedToWarehouseOn = DateTime.Now;
            _defectiveItem.WarehouseId = UserSettings.GetSettings().Workplace!.Id;
            _defectiveItem.Save();
            Initialize();
        }

        private void btnSetAsReturnedToSupplier_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Confirm setting record as returned to supplier?", "Confirmation",
                MessageBoxButtons.YesNo);
            if (result is not DialogResult.Yes)
                return;
            _defectiveItem.ReturnedToSupplierOn = DateTime.Now;
            _defectiveItem.Save();
            Initialize();
        }
    }
}