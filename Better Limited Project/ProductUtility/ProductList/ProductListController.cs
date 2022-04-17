using System.Collections.Generic;
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
                OpenFormEmptyList();
                return;
            }

            OpenFormNormal(workplace.GetStock());
        }

        private void OpenFormEmptyList()
        {
            var form = new ProductListForm();
            _formController.OpenContentForm(form);
        }

        private void OpenFormNormal(List<ProductQuantity> stock)
        {
            var form = new ProductListForm(stock);
            _formController.OpenContentForm(form);
        }
    }
}