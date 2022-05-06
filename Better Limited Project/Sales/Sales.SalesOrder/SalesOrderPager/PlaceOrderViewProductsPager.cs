using System.Collections.Generic;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.Sales.Sales.SalesOrder.SalesOrderPager
{
    public class PlaceOrderViewProductsPager
    {
        private const int PageSize = 6;
        private readonly Pager<ProductQuantity> _pager;

        public PlaceOrderViewProductsPager()
        {
            _pager = new Pager<ProductQuantity>(PageSize);
        }

        public void AddProduct(ProductQuantity product)
        {
            _pager.AddItem(product);
        }

        public IEnumerable<ProductQuantity> GetCurrentPageProducts()
        {
            return _pager.GetCurrentPage();
        }
        
        public IEnumerable<ProductQuantity> GetNextPageProducts()
        {
            return _pager.GetNextPage();
        }
        
        public IEnumerable<ProductQuantity> GetPreviousPageProducts()
        {
            return _pager.GetPreviousPage();
        }
    }
}