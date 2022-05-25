using System.Collections.Generic;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.ProductUtility.Entity;

namespace Better_Limited_Project.Sales.PaymentUtility.PaymentProcesses
{
    public class CreditCardPaymentProcedure : IPaymentProcedure
    {
        private readonly FormController _formController;
        private readonly IEnumerable<RetailStoreStock> _selectedProducts;

        public CreditCardPaymentProcedure(FormController formController, IEnumerable<RetailStoreStock> productQuantities)
        {
            _formController = formController;
            _selectedProducts = productQuantities;
        }

        public event IPaymentProcedure.PaymentCompletedEventHandler? PaymentCompleted;

        public void Start()
        {
            throw new System.NotImplementedException();
        }
    }
}