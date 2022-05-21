using System;
using System.Windows.Forms;
using Better_Limited_Project.Admin.PermissionManagement;
using Better_Limited_Project.ProductUtility.ProductList.Forms;

namespace Better_Limited_Project.ProductUtility.ProductList
{
    public class ProductDetailsController
    {
        private readonly ProductDetailsForm _productDetailsForm;
        public delegate void ProductInfoUpdatedEventHandler(object sender, EventArgs e);
        public event ProductInfoUpdatedEventHandler ProductInfoUpdated;
        private readonly string _productId;

        public ProductDetailsController(string productId, string workplaceId)
        {
            _productId = productId;
            _productDetailsForm = new ProductDetailsForm(productId, workplaceId);
        }

        public void OpenForm()
        {
            _productDetailsForm.UpdateProductInfoClicked += OnUpdateProductInfoClicked;
            _productDetailsForm.StartPosition = FormStartPosition.CenterScreen;
            _productDetailsForm.ShowDialog();
        }

        private void OnUpdateProductInfoClicked(object sender, EventArgs e)
        {
            var permission = ProductUpdatePermissionManager.GetCurrentStaffPermission();
            
            if (permission is ProductUpdatePermission.AllowUpdateAll
                or ProductUpdatePermission.AllowUpdatePricePhasingLevelPhasingOut
                or ProductUpdatePermission.AllowUpdatePrice)
            {
                var controller = new UpdateProductInfoController(_productId);
                controller.ProductInfoUpdated += OnProductInfoUpdated;
                controller.OpenForm();
            }
        }

        private void OnProductInfoUpdated(object sender, EventArgs e)
        {
            ProductInfoUpdated?.Invoke(this, EventArgs.Empty);
            _productDetailsForm.RefreshProductInfo();
        }
    }
}