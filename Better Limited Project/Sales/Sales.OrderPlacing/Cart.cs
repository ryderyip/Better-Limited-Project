using System;
using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.ProductUtility.Entity;

namespace Better_Limited_Project.Sales.Sales.OrderPlacing
{
    public class Cart
    {
        public event EventHandler<IEnumerable<Tuple<Product, int>>>? CartUpdated;
        private readonly Dictionary<Product, int> _items = new();
        
        public void Add(Product product, int quantity)
        {
            if (_items.ContainsKey(product))
                _items[product] += quantity;
            else
                _items.Add(product, quantity);
            
            CartUpdated?.Invoke(this, ConvertToProductQuantityTuple());
        }

        public void Remove(Product product)
        {
            if (_items.ContainsKey(product))
                _items.Remove(product);
            
            CartUpdated?.Invoke(this, ConvertToProductQuantityTuple());
        }

        public void Clear()
        {
            _items.Clear();
            CartUpdated?.Invoke(this, ConvertToProductQuantityTuple());
        }

        public bool IsEmpty()
        {
            return _items.Count == 0;
        }

        private IEnumerable<Tuple<Product, int>> ConvertToProductQuantityTuple()
        {
            return _items.Keys.ToList()
                .Zip(_items.Values.ToList(),
                    (prod, qty) => new Tuple<Product, int>(prod, qty));
        }
    }
}