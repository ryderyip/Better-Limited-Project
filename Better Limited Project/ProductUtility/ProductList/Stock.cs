using System.Collections.Generic;
using Better_Limited_Project.ProductUtility.Entity;

namespace Better_Limited_Project.ProductUtility.ProductList
{
    public class Stock
    {
        public List<ProductQuantity> ProductStock { get; set; }

        public List<ProductQuantity> SearchByKeyword(string keywords)
        {
            return ProductStock.FindAll(
                productQuantity => productQuantity.Product.Name.ToLower().Contains(keywords.ToLower()));
        }
    }
}