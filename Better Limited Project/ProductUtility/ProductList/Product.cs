using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Better_Limited_Project.ProductUtility.ProductList
{
    public class Product
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string Price { get; set; }
        public string SellingPrice { get; set; }
        public string Description { get; set; }
        public string Supplier { get; set; }
        public bool IsPhasingOut { get; set; }
    }
}
