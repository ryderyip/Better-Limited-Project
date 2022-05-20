using System;
using Better_Limited_Project.Admin.PermissionManagement;

namespace Better_Limited_Project.ProductUtility.ProductList
{
    public class UpdateProductInfoController
    {
        public delegate void ProductInfoUpdatedEventHandler(object sender, EventArgs e);
        public event ProductInfoUpdatedEventHandler? ProductInfoUpdated;
        private readonly string _productId;
        
        public UpdateProductInfoController(string productId)
        {
            _productId = productId;
        }
        
        public void OpenForm()
        {
            var permission = ProductUpdatePermissionManager.GetCurrentStaffPermission();

            switch (permission)
            {
                case ProductUpdatePermission.AllowUpdatePrice:
                    OpenEditSellingPriceForm();
                    break;
                case ProductUpdatePermission.AllowUpdatePricePhasingLevelPhasingOut
                    or ProductUpdatePermission.AllowUpdateAll:
                    OpenEditAllForm();
                    break;
            }
        }

        private void OpenEditSellingPriceForm()
        {
            var form = new UpdateSellingPriceForm(_productId);
            form.UpdateSellingPriceClicked += OnUpdateProductInfoClicked;
            form.ShowDialog();
        }
        
        private void OpenEditAllForm()
        {
            var form = new UpdateProductInfoForm(_productId);
            form.UpdateProductInfoClicked += OnUpdateProductInfoClicked;
            form.ShowDialog();
        }
        
        private void OnUpdateProductInfoClicked(object sender, EventArgs args)
        {
            ProductInfoUpdated?.Invoke(this, EventArgs.Empty);
            ProductInfoUpdated = null;
        }
    }
}