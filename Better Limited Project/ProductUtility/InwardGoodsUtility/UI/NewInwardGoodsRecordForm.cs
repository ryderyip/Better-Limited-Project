using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.GoodsPurchasing.Entity;
using Better_Limited_Project.ProductUtility.InwardGoodsUtility.Controller;
using Better_Limited_Project.ProductUtility.Reordering.Entity;
using Better_Limited_Project.ProductUtility.UI;

namespace Better_Limited_Project.ProductUtility.InwardGoodsUtility.UI
{
    public partial class NewInwardGoodsRecordForm : Form
    {
        private readonly List<IProductQuantity> _inwardGoodsProducts = new();
        private PurchaseOrder? _selectedPurchaseOrder;

        public NewInwardGoodsRecordForm(PurchaseOrder? purchaseOrder = null)
        {
            _selectedPurchaseOrder = purchaseOrder;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Load += (_, _) => Initialize();
        }

        private void Initialize()
        {
            tbPurchaseOrder.TextChanged += (_, _) => btnChooseReceivedGoods.Enabled = true;
            if (_selectedPurchaseOrder is not null)
            {
                tbPurchaseOrder.Text = _selectedPurchaseOrder.PurchaseOrderNumber;
                PopulatePurchasedGoodsDgv(_selectedPurchaseOrder.OrderProducts);
                PopulateMissingGoodsDgv(FindMissingGoods(_selectedPurchaseOrder.GetNotYetReceivedProducts()));
            }

            tbDateReceived.Text = DateTime.Today.ToString("D");
            /*_inwardGoodsProducts.ForEach(
                igp => dgvReceivedGoods.Rows.Add(igp.ProductId, igp.Product.Name, igp.Quantity));*/
        }

        private void btnChoosePurchaseOrder_Click(object sender, EventArgs e)
        {
            var form = new PurchaseOrderPickerForm(_selectedPurchaseOrder);
            var result = form.ShowDialog();
            if (result is not DialogResult.OK || form.SelectedPurchaseOrder == null)
                return;

            _selectedPurchaseOrder = form.SelectedPurchaseOrder;
            tbPurchaseOrder.Text = _selectedPurchaseOrder.PurchaseOrderNumber;
            dgvReceivedGoods.Rows.Clear();
            PopulatePurchasedGoodsDgv(_selectedPurchaseOrder.OrderProducts);
            PopulateMissingGoodsDgv(FindMissingGoods(_selectedPurchaseOrder.GetNotYetReceivedProducts()));
        }

        private void PopulateMissingGoodsDgv(IEnumerable<IProductQuantity> missingGoods)
        {
            dgvMissingGoods.Rows.Clear();
            foreach (IProductQuantity missingGood in missingGoods)
                dgvMissingGoods.Rows.Add(missingGood.ProductId, missingGood.Product.Name, missingGood.Quantity);
        }

        private IEnumerable<IProductQuantity> FindMissingGoods(IEnumerable<PurchaseOrderProduct> orderedProducts)
        {
            return from orderedProduct in orderedProducts
                let receivedProduct = _inwardGoodsProducts.Find(gp => gp.ProductId == orderedProduct.ProductId)
                let missingQuantity = orderedProduct.Quantity - (receivedProduct?.Quantity ?? 0)
                where receivedProduct == null || receivedProduct.Quantity < orderedProduct.Quantity
                select new ProductQuantity(orderedProduct.ProductId, missingQuantity > 0 ? missingQuantity : 0);
        }

        private void PopulatePurchasedGoodsDgv(IEnumerable<PurchaseOrderProduct> orderProducts)
        {
            dgvPurchasedGoods.Rows.Clear();
            foreach (var orderProduct in orderProducts)
                dgvPurchasedGoods.Rows.Add(orderProduct.ProductId, orderProduct.Product.Name, orderProduct.Quantity);
        }

        private void btnChooseReceivedGoods_Click(object sender, EventArgs e)
        {
            if (_selectedPurchaseOrder == null)
                return;
            var form = new GoodsPickerForm(_inwardGoodsProducts,
                _selectedPurchaseOrder.GetNotYetReceivedProducts().Select(pop => pop.Product));
            var result = form.ShowDialog();
            if (result is not DialogResult.OK)
                return;

            _inwardGoodsProducts.Clear();
            _inwardGoodsProducts.AddRange(form.SelectedProducts);
            PopulateReceivedGoodsDgv(_inwardGoodsProducts);
            btnCreate.Enabled = _inwardGoodsProducts.Any();
            PopulateMissingGoodsDgv(FindMissingGoods(_selectedPurchaseOrder.GetNotYetReceivedProducts()));
        }

        private void PopulateReceivedGoodsDgv(List<IProductQuantity> inwardGoodsProducts)
        {
            dgvReceivedGoods.Rows.Clear();
            inwardGoodsProducts.ForEach(
                igp => dgvReceivedGoods.Rows.Add(igp.ProductId, igp.Product.Name, igp.Quantity));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (_selectedPurchaseOrder == null || !_inwardGoodsProducts.Any())
                return;

            if (dgvMissingGoods.Rows.Count != 0)
            {
                var result = MessageBox.Show("There are some missing goods. Proceed to create an inward goods record?",
                    "Confirmation", MessageBoxButtons.YesNo);
                if (result is not DialogResult.Yes)
                    return;
            }

            var service = new InwardGoodsService(_selectedPurchaseOrder.Id);
            service.AddRangeGoods(_inwardGoodsProducts);
            service.CreateRecord();
            DialogResult = DialogResult.OK;
        }
    }
}