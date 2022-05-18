using System.Collections.Generic;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.ProductUtility.Entity;

namespace Better_Limited_Project.Sales.Payment
{
    public class OctopusCardPaymentProcedure : IPaymentProcedure
    {
        private readonly FormController _formController;
        private readonly IEnumerable<ProductQuantity> _selectedProducts;

        public OctopusCardPaymentProcedure(FormController formController, IEnumerable<ProductQuantity> productQuantities)
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