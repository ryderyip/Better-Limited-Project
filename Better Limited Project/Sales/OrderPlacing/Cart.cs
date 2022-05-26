using System;
using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;

namespace Better_Limited_Project.Sales.OrderPlacing
{
    public class Cart // TODO redesign this
    {
        public event EventHandler? Updated;
        private readonly Dictionary<string, Product> _products = new();
        private readonly Dictionary<string, int> _quantities = new();
        private readonly Dictionary<string, decimal> _prices = new();
        private readonly List<RetailStoreStock> _stock;

        public Cart(string retailStoreId)
        {
            _stock = StockRepository.GetRetailStoreStocks(retailStoreId).ToList();
            _stock.ForEach(stock => _prices.Add(stock.Product.Id, stock.SellingPrice));
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

            Updated?.Invoke(this, EventArgs.Empty);
        }

        public IEnumerable<CartItem> GetCartItems()
        {
            return _quantities.Keys.ToList()
                .Zip(_quantities.Values.ToList(),
                    (prodId, qty) =>
                    {
                        var product = _products[prodId];
                        decimal price = _prices[prodId];
                        return new CartItem(product, qty, price, IsDeposit(product, qty));
                    });
        }

        private bool IsDeposit(Product product, int qtyRequired)
        {
            var productStock = _stock.Find(stock => stock.Product.Id == product.Id);
            return productStock.Quantity < qtyRequired && productStock.SellingPrice >= Product.DepositThreshold;
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
            Updated?.Invoke(this, EventArgs.Empty);
        }

        public bool IsEmpty()
        {
            return _quantities.Count == 0;
        }

        public decimal GetTotalPrice()
        {
            return GetCartItems().Sum(item => item.Price * item.Quantity);
        }

        public decimal GetTotalDepositPrice()
        {
            decimal deposit = GetCartItems()
                .Where(item => _stock.Find(stock => stock.Product.Id == item.Product.Id)
                        .Quantity == 0)
                .Sum(item => item.Price * item.Quantity * Product.DepositPricePercentage);
            decimal ordinary = GetCartItems()
                .Where(item => _stock.Find(stock => stock.Product.Id == item.Product.Id)
                    .Quantity != 0)
                .Sum(item => item.Price * item.Quantity);
            return deposit + ordinary;
        }

        public bool HasNeedDepositItem()
        {
            return GetCartItems().Any(item =>
                _stock.Any(stock => stock.Product.Id == item.Product.Id 
                                    && stock.Quantity == 0
                                    && stock.SellingPrice >= Product.DepositThreshold));
        }
    }
}