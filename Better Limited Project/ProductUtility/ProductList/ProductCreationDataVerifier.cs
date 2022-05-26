using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;

namespace Better_Limited_Project.ProductUtility.ProductList
{
    public class ProductCreationDataVerifier
    {
        private readonly List<Product> _products;

        public ProductCreationDataVerifier()
        {
            _products = ProductRepository.GetProducts().ToList();
        }

        public bool IsNameValid(string name)
        {
            return name.Length >= 4 && Regex.IsMatch(name, "^[a-zA-Z0-9_ ]*$");
        }

        public bool IsNameUnique(string name)
        {
            return _products.All(product => product.Name != name);
        }
    }
}