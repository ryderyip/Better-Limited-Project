using System;
using System.Windows.Forms;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.SettingsUtility;

namespace Better_Limited_Project.ProductUtility.ProductList
{
    public class ProductListController
    {
        private readonly FormController _formController;
        private ProductListForm _productListForm;
        
        public ProductListController(FormController formController)
        {
            _formController = formController;
        }

        public void OpenForm()
        {
            var workplace = UserSettings.GetSettings().Workplace;
            
            if (workplace == null)
            {
                MessageBox.Show("Please first select your workplace in settings!");
                return;
            }

            _productListForm = new ProductListForm();
            _productListForm.ProductClicked += OnProductClicked;
            _productListForm.UpdateStockLevelClicked += OnUpdateStockLevelClicked;
            _formController.OpenContentForm(_productListForm);
        }

        private void OnUpdateStockLevelClicked(object sender, EventArgs e)
        {
            var controller = new UpdateStockLevelController(_formController);
            controller.StockLevelUpdated += OnStockLevelUpdated;
            controller.OpenForm();
        }

        private void OnStockLevelUpdated(object sender, EventArgs e)
        {
            RefreshUiStock();
        }

        private void OnProductClicked(object sender, string productId)
        {
            var controller = new ProductDetailsController(productId);
            controller.ProductInfoUpdated += OnProductInfoUpdated;
            controller.OpenForm();
        }

        private void OnProductInfoUpdated(object sender, EventArgs e)
        {
            RefreshUiStock();
        }

        private void RefreshUiStock()
        {
            if (_productListForm == null)
                throw new Exception("Product list form is null when trying to access it");

            _productListForm.RefreshStock();
        }
    }
}