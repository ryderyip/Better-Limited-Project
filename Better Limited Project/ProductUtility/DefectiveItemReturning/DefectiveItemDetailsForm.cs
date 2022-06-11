using System.Windows.Forms;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.Sales.OrderPlacing.UI;

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
            if (_defectiveItem.SalesOrder.Customer == null)
                btnCustomerDetailedInfo.Visible = false;
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
            tbStaffName.Text = _defectiveItem.Staff.Name;
            if (_defectiveItem.SalesOrder.Customer != null)
            {
                tbCustomerName.Text = _defectiveItem.SalesOrder.Customer.Name;
                tbCustomerPhone.Text = _defectiveItem.SalesOrder.Customer.Phone;
            }
        }

        private void btnSalesOrder_Click(object sender, System.EventArgs e)
        {
            var form = new SalesOrderDetailsForm(_defectiveItem.SalesOrder);
            form.ShowDialog();
        }

        private void btnCustomerDetailedInfo_Click(object sender, System.EventArgs e)
        {
            var form = new CustomerDetailsForm(_defectiveItem.SalesOrder.Customer!);
            form.ShowDialog();
        }
    }
}
