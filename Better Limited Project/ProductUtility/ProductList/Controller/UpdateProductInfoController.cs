using System;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.ProductList.Forms;
using Better_Limited_Project.ProductUtility.ProductList.PermissionManagement;

namespace Better_Limited_Project.ProductUtility.ProductList.Controller
{
    public class UpdateProductInfoController
    {
        public delegate void ProductInfoUpdatedEventHandler(object sender, EventArgs e);
        public event ProductInfoUpdatedEventHandler? ProductInfoUpdated;
        private readonly string _productId;
        private readonly string _workplaceId;

        public UpdateProductInfoController(string productId, string workplaceId)
        {
            _productId = productId;
            _workplaceId = workplaceId;
        }
        
        public void OpenForm()
        {
            var permission = ProductInfoEditPermissionManager.GetCurrentStaffPermission();

            switch (permission)
            {
                case ProductInfoEditPermission.AllowUpdatePrice:
                    OpenEditSellingPriceForm();
                    break;
                case ProductInfoEditPermission.AllowUpdatePricePhasingLevelPhasingOut
                    or ProductInfoEditPermission.AllowUpdateAll:
                    OpenEditAllForm();
                    break;
            }
        }

        private void OpenEditSellingPriceForm()
        {
            var form = new UpdateSellingPriceForm(_productId);
            form.UpdateSellingPriceClicked += OnUpdateProductInfoClicked;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }
        
        private void OpenEditAllForm()
        {
            var form = new UpdateProductInfoForm(_productId, _workplaceId);
            form.UpdateProductInfoClicked += OnUpdateProductInfoClicked;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }
        
        private void OnUpdateProductInfoClicked(object sender, EventArgs args)
        {
            ProductInfoUpdated?.Invoke(this, EventArgs.Empty);
            ProductInfoUpdated = null;
        }
    }
}