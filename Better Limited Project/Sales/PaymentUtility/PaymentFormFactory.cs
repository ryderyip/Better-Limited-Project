using System;
using Better_Limited_Project.Sales.OrderPlacing;

namespace Better_Limited_Project.Sales.PaymentUtility
{
    public static class PaymentFormFactory
    {
        public static IPaymentForm Generate(PaymentMethod method, SalesOrder salesOrder)
        {
            return method switch
            {
                PaymentMethod.Cash => new CashPaymentForm(salesOrder),
                PaymentMethod.CreditCard => new CreditCardPaymentForm(salesOrder),
                PaymentMethod.Octopus => new OctopusCardPaymentForm(salesOrder),
                _ => throw new ArgumentException(
                    $"Unknown payment method \"{method.ToString()}\"")
            };
        }
    }
}