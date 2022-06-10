using System.Drawing;
using System.Windows.Forms;
using Better_Limited_Project.DocumentUtility;
using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.PickerForms;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.ProductUtility.DefectiveItemReturning
{
    public partial class NewDefectiveItem : Form
    {
        private Product? _selectedProduct;
        private SalesOrder? _selectedSalesOrder;
        private Image? _selectedImage;

        public NewDefectiveItem()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void btnChooseProduct_Click(object sender, System.EventArgs e)
        {
            if (_selectedSalesOrder == null)
            {
                MessageBox.Show("Please first select the sales order.");
                return;
            }

            var form = new SalesOrderProductPickerForm(_selectedSalesOrder.GetSalesOrderProducts());
            var result = form.ShowDialog();
            if (result is not DialogResult.OK || form.SelectedProduct == null)
                return;
            _selectedProduct = form.SelectedProduct.GetProduct();
            tbProduct.Text = _selectedProduct.Name;
        }

        private void btnChooseSalesOrder_Click(object sender, System.EventArgs e)
        {
            var form = new SalesOrderPickerForm();
            var result = form.ShowDialog();
            if (result is not DialogResult.OK || form.SelectedSalesOrder == null)
                return;
            btnChooseProduct.Enabled = true;
            _selectedSalesOrder = form.SelectedSalesOrder;
            tbSalesOrderNumber.Text = _selectedSalesOrder.OrderNumber;
        }

        private void btnChooseImage_Click(object sender, System.EventArgs e)
        {
            string browserDescription = "Select an image as an evidence";
            var path = ImageFileBrowser.Browse(browserDescription);
            if (path == null) return;

            var image = ImageRetriever.Retrieve(path);
            if (image == null) return;

            pbEvidenceImage.Image = image;
            _selectedImage = image;
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            string description = tbDescription.Text.Trim();
            int quantity = (int) nudQuantity.Value;
            var currentRetailStore = (RetailStore) UserSettings.GetSettings().Workplace!;
            var staff = LoginSession.GetSession().CurrentStaff;
            if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show(
                    "Please enter the description of the defective item. E.g. what part of the item is defective?");
                return;
            }

            if (_selectedProduct == null)
            {
                MessageBox.Show("Please choose the defective item!");
                return;
            }

            if (_selectedSalesOrder == null)
            {
                MessageBox.Show("Please choose the sales order to which the defective(s) item belong!");
                return;
            }

            var defectiveItem = new DefectiveItem(_selectedProduct.Id, quantity, description,
                currentRetailStore.Id, staff.Id, _selectedSalesOrder.Id)
            {
                Image = _selectedImage
            };

            defectiveItem.Save();
            DialogResult = DialogResult.OK;
        }
    }
}