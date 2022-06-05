using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Entity;

namespace Better_Limited_Project.Sales.OrderPlacing.Controller.SalesOrderPager
{
    public class PlaceOrderFormPageFiller
    {
        private readonly List<PlaceOrderItemControlCollection> _controlCollections = new();

        public void AddControlCollection(PlaceOrderItemControlCollection controls)
        {
            _controlCollections.Add(controls);
        }

        public void FillPageWithProducts(IReadOnlyList<RetailStoreStock> products)
        {
            ShowAllProductControls();
            for (int i = 0; i < products.Count; i++)
            {
                var controlCollection = _controlCollections[i];
                var stock = products[i];
                controlCollection.Name.Text = stock.Product.Name;
                controlCollection.Price.Text = stock.SellingPrice.ToString("C", new CultureInfo("zh-HK"));
                controlCollection.Quantity.Text = stock.Quantity.ToString();
                controlCollection.Picture.SizeMode = PictureBoxSizeMode.Zoom;
                controlCollection.Picture.Image = stock.Product.GetImage();
            }
            HideProductControls(_controlCollections.Count-products.Count);
        }

        private void ShowAllProductControls()
        {
            foreach (var controls in _controlCollections)
                controls.Panel.Visible = true;
        }
        
        private void HideProductControls(int noOfControlsToHide)
        {
            for (int i = 0; i < noOfControlsToHide; i++)
                _controlCollections[_controlCollections.Count-i-1].Panel.Visible = false;
        }
    }
}