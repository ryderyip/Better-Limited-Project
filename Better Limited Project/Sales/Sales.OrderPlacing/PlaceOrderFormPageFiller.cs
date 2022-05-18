using System.Collections.Generic;
using System.Globalization;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Sales.Sales.SalesOrder.SalesOrderPager;

namespace Better_Limited_Project.Sales.Sales.SalesOrder
{
    public class PlaceOrderFormPageFiller
    {
        private readonly List<PlaceOrderItemControlCollection> _controlCollections = new();

        public void AddControlCollection(PlaceOrderItemControlCollection controls)
        {
            _controlCollections.Add(controls);
        }

        public void FillPageWithProducts(IReadOnlyList<ProductQuantity> products)
        {
            ShowAllProductControls();
            for (int i = 0; i < products.Count; i++)
            {
                var controlCollection = _controlCollections[i];
                var productQuantity = products[i];
                controlCollection.Name.Text = productQuantity.Product.Name;
                controlCollection.Price.Text = productQuantity.Product.SellingPrice.ToString("C", new CultureInfo("zh-HK"));
                controlCollection.Quantity.Text = productQuantity.Quantity.ToString();
            }
            HideProductControls(6-products.Count);
        }

        private void ShowAllProductControls()
        {
            foreach (var controls in _controlCollections)
                controls.Panel.Visible = true;
        }
        
        private void HideProductControls(int noOfControlsToHide)
        {
            for (int i = 0; i < noOfControlsToHide; i++)
                _controlCollections[6-i-1].Panel.Visible = false;
        }
    }
}