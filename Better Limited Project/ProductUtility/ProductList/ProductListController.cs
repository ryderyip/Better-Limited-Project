using System;
using System.Windows.Forms;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.SettingsUtility;

namespace Better_Limited_Project.ProductUtility.ProductList
{
    public class ProductListController
    {
        private readonly FormController _formController;
        
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
            var form = new ProductListForm(stock);
            form.ProductClicked += OnProductClicked;
            _formController.OpenContentForm(form);
        }

        private void OnProductClicked(object sender, ProductQuantity productQuantity)
        {
            var controller = new ProductDetailsController(productQuantity);
            controller.OpenForm();
        }
    }
}