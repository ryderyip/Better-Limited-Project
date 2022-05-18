using System;
using System.Collections.Generic;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Sales.Sales.Payment;

namespace Better_Limited_Project.Sales.Payment
{
    public static class PaymentProcedureFactory
    {
        public static IPaymentProcedure GeneratePaymentProcedure(PaymentMethod method, FormController formController, IEnumerable<ProductQuantity> productQuantities)
        {
            switch (method)
            {
                case PaymentMethod.Cash:
                    return new CashPaymentProcedure(formController, productQuantities);
                case PaymentMethod.Octopus:
                    return new OctopusCardPaymentProcedure(formController, productQuantities);
                case PaymentMethod.CreditCard:
                    return new CreditCardPaymentProcedure(formController, productQuantities);
                default:
                    throw new ArgumentException("Unexpected payment method.");
            }
        }
    }
}