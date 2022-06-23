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

        public void FillPageWithProducts(IReadOnlyList<RetailStoreStock> stocks)
        {
            ShowAllProductControls();
            for (var i = 0; i < stocks.Count; i++)
            {
                var controlCollection = _controlCollections[i];
                var stock = stocks[i];
                var product = stock.Product;
                controlCollection.Name.Text = product.Name;
                controlCollection.Price.Text = stock.SellingPrice.ToString("C", new CultureInfo("zh-HK"));
                controlCollection.Quantity.Text = stock.Quantity.ToString();
                controlCollection.Picture.SizeMode = PictureBoxSizeMode.Zoom;
                controlCollection.Picture.Image = product.GetImage();
            }

            HideProductControls(_controlCollections.Count - stocks.Count);
        }

        private void ShowAllProductControls()
        {
            foreach (var controls in _controlCollections)
                controls.Panel.Visible = true;
        }

        private void HideProductControls(int noOfControlsToHide)
        {
            for (var i = 0; i < noOfControlsToHide; i++)
                _controlCollections[_controlCollections.Count - i - 1].Panel.Visible = false;
        }
    }
}