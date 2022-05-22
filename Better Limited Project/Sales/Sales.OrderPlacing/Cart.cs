using System;
using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;

namespace Better_Limited_Project.Sales.Sales.OrderPlacing
{
    public class Cart
    {
        public event EventHandler<IEnumerable<Tuple<Product, int, decimal>>>? Updated;
        private readonly Dictionary<string, Product> _products = new();
        private readonly Dictionary<string, int> _quantities = new();
        private readonly Dictionary<string, decimal> _prices = new();

        public Cart(string retailStoreId)
        {
            StockRepository.GetRetailStoreStocks(retailStoreId).ToList()
                .ForEach(stock => _prices.Add(stock.Product.Id, stock.SellingPrice));
        }

        public void Add(Product product, int quantity)
        {
            if (_quantities.ContainsKey(product.Id))
                _quantities[product.Id] += quantity;
            else
            {
                _products.Add(product.Id, product);
                _quantities.Add(product.Id, quantity);
            }

            Updated?.Invoke(this, ConvertToProductQuantityTuple());
        }

        public void Remove(Product product)
        {
            throw new NotImplementedException("Remove method not implemented");
            /*if (_quantities.ContainsKey(product.Id))
            {
                _products.remo
                _quantities.Remove(product.Id);
            }

            CartUpdated?.Invoke(this, ConvertToProductQuantityTuple());*/
        }

        public void Clear()
        {
            _products.Clear();
            _quantities.Clear();
            Updated?.Invoke(this, ConvertToProductQuantityTuple());
        }

        public bool IsEmpty()
        {
            return _quantities.Count == 0;
        }

        public decimal GetTotalPrice()
        {
            return _quantities.Sum(pair => _prices[pair.Key] * pair.Value);
        }

        private IEnumerable<Tuple<Product, int, decimal>> ConvertToProductQuantityTuple()
        {
            return _quantities.Keys.ToList()
                .Zip(_quantities.Values.ToList(),
                    (prodId, qty) => 
                        new Tuple<Product, int, decimal>(_products[prodId], qty, _prices[prodId]));
        }
    }
}