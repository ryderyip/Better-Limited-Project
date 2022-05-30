using System;
using Better_Limited_Project.Sales.PaymentUtility.UI;

namespace Better_Limited_Project.Sales.PaymentUtility
{
    public static class PaymentFormFactory
    {
        public static IPaymentForm Generate(decimal amount, PaymentMethod method)
        {
            return method switch
            {
                PaymentMethod.Cash => new CashPaymentForm(amount),
                PaymentMethod.CreditCard => new CreditCardPaymentForm(amount),
                PaymentMethod.Octopus => new OctopusCardPaymentForm(amount),
                _ => throw new ArgumentException(
                    $"Unknown payment method \"{method.ToString()}\"")
            };
        }
    }
}