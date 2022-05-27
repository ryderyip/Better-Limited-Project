using System;
using Better_Limited_Project.Sales.PaymentUtility.Repository;

namespace Better_Limited_Project.Sales.PaymentUtility
{
    public class Payment : IEntity
    {
        private string? _id;

        public string Id
        {
            get => _id ?? throw new InvalidOperationException("Id is not initialized.");
            set => _id = value;
        }

        public decimal Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public DateTime PaidOn { get; set; } = DateTime.MinValue;

        public void Save()
        {
            var repo = new PaymentRepository();
            if (_id == null)
                repo.Insert(this);
        }
    }
}