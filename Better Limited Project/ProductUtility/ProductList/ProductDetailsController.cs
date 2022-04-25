using Better_Limited_Project.ProductUtility.Entity;

namespace Better_Limited_Project.ProductUtility.ProductList
{
    public class ProductDetailsController
    {
        private readonly ProductQuantity _productQuantity;

        public ProductDetailsController(ProductQuantity productQuantity)
        {
            _productQuantity = productQuantity;
        }

        public void OpenForm()
        {
            var form = new ProductDetailsForm(_productQuantity);
            form.ShowDialog();
            
        }
    }
}