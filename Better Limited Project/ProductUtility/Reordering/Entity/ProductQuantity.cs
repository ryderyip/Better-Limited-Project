using System;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;

namespace Better_Limited_Project.ProductUtility.Reordering.Entity
{
    public class ProductQuantity : IProductQuantity, IEquatable<ProductQuantity>
    {
        public ProductQuantity(string productId, int quantity)
        {
            ProductId = productId;
            Quantity = quantity;
        }

        public bool Equals(ProductQuantity other)
        {
            return ProductId == other.ProductId && Quantity == other.Quantity;
        }

        public string ProductId { get; }
        public Product Product => ProductRepository.FindById(ProductId);
        public int Quantity { get; set; }

        public override int GetHashCode()
        {
            throw new NotSupportedException($"{nameof(ProductQuantity)} does not support GetHashCode().");
        }

        public static bool operator ==(ProductQuantity x, ProductQuantity y)
        {
            return x.Equals(y);
        }

        public static bool operator !=(ProductQuantity x, ProductQuantity y)
        {
            return !x.Equals(y);
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((ProductQuantity) obj);
        }
    }
}