using System;

namespace Better_Limited_Project.ProductUtility.ProductList
{
    public class ProductDetailsController
    {
        private readonly ProductDetailsForm _productDetailsForm;
        public delegate void ProductInfoUpdatedEventHandler(object sender, EventArgs e);
        public event ProductInfoUpdatedEventHandler ProductInfoUpdated;
        private readonly string _productId;

        public ProductDetailsController(string productId)
        {
            _productId = productId;
            _productDetailsForm = new ProductDetailsForm(productId);
        }

        public void OpenForm()
        {
            _productDetailsForm.UpdateProductInfoClicked += OnUpdateProductInfoClicked;
            _productDetailsForm.ShowDialog();
        }

        private void OnUpdateProductInfoClicked(object sender, EventArgs e)
        {
            var controller = new UpdateSellingPriceController(_productId);
            controller.SellingPriceUpdated += OnSellingPriceUpdated;
            controller.OpenForm();
        }

        private void OnSellingPriceUpdated(object sender, EventArgs e)
        {
            ProductInfoUpdated?.Invoke(this, EventArgs.Empty);
            _productDetailsForm.RefreshProductInfo(_productId);
        }
    }
}