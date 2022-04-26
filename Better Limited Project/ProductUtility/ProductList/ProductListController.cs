using System;
using System.Windows.Forms;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;

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

            var stock = workplace.GetStock();
            _productListForm = new ProductListForm(stock);
            _productListForm.ProductClicked += OnProductClicked;
            _formController.OpenContentForm(_productListForm);
        }

        private void OnProductClicked(object sender, ProductQuantity productQuantity)
        {
            var controller = new ProductDetailsController(productQuantity);
            controller.ProductInfoUpdated += OnProductInfoUpdated;
            controller.OpenForm();
        }

        private void OnProductInfoUpdated(object sender, EventArgs e)
        {
            var retailStore = (RetailStore) UserSettings.GetSettings().Workplace;
            if (retailStore == null)
                return;
            
            _productListForm.RefreshStock(retailStore.GetStock());
        }
    }
}