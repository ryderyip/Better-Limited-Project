using System;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.ProductList
{
    public class UpdateSellingPriceController
    {
        private readonly Product _product;
        public delegate void SellingPriceUpdatedEventHandler(object sender, EventArgs e);
        public event SellingPriceUpdatedEventHandler SellingPriceUpdated;
        
        public UpdateSellingPriceController(Product product)
        {
            _product = product;
        }

        public void OpenForm()
        {
            var form = new UpdateSellingPriceForm(_product.SellingPrice);
            form.UpdateSellingPriceClicked += OnUpdateSellingPriceClicked;
            form.ShowDialog();
        }

        private void OnUpdateSellingPriceClicked(object sender, string newSellingPrice)
        {
            decimal defaultPrice = 0;
            bool isValidInputtedPrice = decimal.TryParse(newSellingPrice, out var sellingPrice);
            if (!isValidInputtedPrice)
                sellingPrice = defaultPrice;

            
            var retailStore = GetRetailStore();
            retailStore.UpdateSellingPrice(_product, sellingPrice);
            SellingPriceUpdated?.Invoke(this, EventArgs.Empty);
            SellingPriceUpdated = null;
        }

        private RetailStore GetRetailStore()
        {
            var settings = UserSettings.GetSettings();
            return (RetailStore) settings.Workplace;
        }
    }
}