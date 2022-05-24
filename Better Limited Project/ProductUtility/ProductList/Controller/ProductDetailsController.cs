using System;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.ProductList.Forms;
using Better_Limited_Project.ProductUtility.ProductList.PermissionManagement;

namespace Better_Limited_Project.ProductUtility.ProductList.Controller
{
    public class ProductDetailsController
    {
        private readonly ProductDetailsForm _productDetailsForm;
        public event EventHandler? ProductInfoUpdated;
        public event EventHandler? ProductRemoved;
        private readonly string _productId;
        private readonly string _workplaceId;

        public ProductDetailsController(string productId, string workplaceId)
        {
            _productId = productId;
            _workplaceId = workplaceId;
            _productDetailsForm = new ProductDetailsForm(productId, workplaceId);
        }

        public void OpenForm()
        {
            _productDetailsForm.UpdateProductInfoClicked += OnUpdateProductInfoClicked;
            _productDetailsForm.ProductRemoved += (_, _) => ProductRemoved?.Invoke(this, EventArgs.Empty);
            _productDetailsForm.StartPosition = FormStartPosition.CenterScreen;
            _productDetailsForm.ShowDialog();
        }

        private void OnUpdateProductInfoClicked(object sender, EventArgs e)
        {
            var permission = ProductInfoEditPermissionManager.GetCurrentStaffPermission();
            
            if (permission is ProductInfoEditPermission.AllowUpdateAll
                or ProductInfoEditPermission.AllowUpdatePricePhasingLevelPhasingOut
                or ProductInfoEditPermission.AllowUpdatePrice)
            {
                var controller = new UpdateProductInfoController(_productId, _workplaceId);
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