using System.Collections.Generic;

namespace Better_Limited_Project.ProductUtility.ProductList
{
    public class RetailStoreStock
    {
        public string Id { get; set; }
        public List<ProductQuantityPair> Stock { get; set; }


        public static RetailStoreStock GetStock(string retailStoreId)
        {
            
        }
    }
    
}