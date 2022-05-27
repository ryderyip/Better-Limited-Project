using System;
using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;

namespace Better_Limited_Project.Sales.OrderPlacing
{
    public class Cart // TODO redesign this
    {
        private readonly string _retailStoreId;
        public event EventHandler? Updated;
        private readonly List<CartItem> _cartItems = new();
        private readonly List<CartItem> _depositCardItems = new();
        private List<RetailStoreStock> _stocks;

        public Cart(string retailStoreId)
        {
            _retailStoreId = retailStoreId;
            _stocks = GetStocks();
        }

        public void Add(Product product)
        {
            var stock = _stocks.First(s => s.Product.Id == product.Id);

            var cartItem = _cartItems.FirstOrDefault(item => item.Product.Id == product.Id);
            
            // Product already in cart
            if (cartItem != null)
            {
                // Still have stock left
                if (stock.Quantity != 0)
                {
                    cartItem.Quantity++;
                    stock.Quantity--;
                }
                else
                {
                    AddToDepositCart(product, stock);
                }
            }
            // Product not in cart
            else
            {
                if (stock.Quantity != 0)
                {
                    _cartItems.Add(new CartItem(product, 1, stock.SellingPrice, false));
                    stock.Quantity--;
                }
                else
                    AddToDepositCart(product, stock);
            }

            Updated?.Invoke(this, EventArgs.Empty);
        }

        private void AddToDepositCart(Product product, RetailStoreStock stock)
        {
            var depositCartItem = _depositCardItems.FirstOrDefault(item => item.Product.Id == product.Id);
            // If already in deposit cart
            if (depositCartItem != null)
                depositCartItem.Quantity++;
            else
                _depositCardItems.Add(new CartItem(product, 1, stock.SellingPrice, true));
        }

        public IEnumerable<CartItem> GetCartItems()
        {
            return _cartItems.Concat(_depositCardItems);
        }

        public void Clear()
        {
            _cartItems.Clear();
            _depositCardItems.Clear();
            _stocks = GetStocks();

            Updated?.Invoke(this, EventArgs.Empty);
        }

        public bool IsEmpty()
        {
            return _cartItems.Count == 0 && _depositCardItems.Count == 0;
        }

        public decimal GetTotalPrice()
        {
            decimal deposit = GetCartItems()
                .Where(item => _stocks.Find(stock => stock.Product.Id == item.Product.Id)
                    .Quantity == 0)
                .Sum(item => item.Price * item.Quantity * Product.DepositPricePercentage);
            decimal ordinary = GetCartItems()
                .Where(item => _stocks.Find(stock => stock.Product.Id == item.Product.Id)
                    .Quantity != 0)
                .Sum(item => item.Price * item.Quantity);
            return deposit + ordinary;
        }
        
        private List<RetailStoreStock> GetStocks()
        {
            return StockRepository.GetStocks(_retailStoreId).Cast<RetailStoreStock>().ToList();
        }
    }
}