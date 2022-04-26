using System;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.ProductList
{
    public class ProductDetailsController
    {
        private readonly ProductQuantity _productQuantity;
        private readonly ProductDetailsForm _productDetailsForm;
        public delegate void ProductInfoUpdatedEventHandler(object sender, EventArgs e);
        public event ProductInfoUpdatedEventHandler ProductInfoUpdated;

        public ProductDetailsController(ProductQuantity productQuantity)
        {
            _productQuantity = productQuantity;
            _productDetailsForm = new ProductDetailsForm(productQuantity);
        }

        public void OpenForm()
        {
            _productDetailsForm.UpdateProductInfoClicked += OnUpdateProductInfoClicked;
            _productDetailsForm.ShowDialog();
        }

        private void OnUpdateProductInfoClicked(object sender, EventArgs e)
        {
            var controller = new UpdateSellingPriceController(_productQuantity.Product);
            controller.SellingPriceUpdated += OnSellingPriceUpdated;
            controller.OpenForm();
        }

        private void OnSellingPriceUpdated(object sender, EventArgs e)
        {
            var newProductInfo = GetNewProductInfo();
            if (newProductInfo == null)
                return;
            ProductInfoUpdated?.Invoke(this, EventArgs.Empty);
            _productDetailsForm.RefreshProductInfo(newProductInfo.Value);
        }

        private ProductQuantity? GetNewProductInfo()
        {
            var retailStore = (RetailStore) UserSettings.GetSettings().Workplace;
            return retailStore?.GetStock(_productQuantity.Product.Id);
        }
    }
}