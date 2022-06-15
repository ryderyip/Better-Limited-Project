using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.InwardGoodsUtility.Entity;

namespace Better_Limited_Project.ProductUtility.InwardGoodsUtility.UI
{
    public partial class InwardGoodsDetailsForm : Form
    {
        private readonly InwardGoods _inwardGoods;

        public InwardGoodsDetailsForm(InwardGoods inwardGoods)
        {
            StartPosition = FormStartPosition.CenterScreen;
            _inwardGoods = inwardGoods;
            InitializeComponent();
            Load += (_, _) => Initialize();
        }

        private void Initialize()
        {
            FillFields();
            PopulateDgv();
        }

        private void PopulateDgv()
        {
            foreach (var inwardProduct in _inwardGoods.InwardProducts)
                dgvReceivedGoods.Rows.Add(inwardProduct.ProductId, 
                    inwardProduct.Product.Name, 
                    inwardProduct.Quantity);
        }

        private void FillFields()
        {
            tbPurchaseOrderNumber.Text = _inwardGoods.PurchaseOrder.PurchaseOrderNumber;
            tbReceivedOn.Text = _inwardGoods.ReceivedOn.ToString("f");
            // tbReceivedByStaff.Text = TODO 
        }
    }
}