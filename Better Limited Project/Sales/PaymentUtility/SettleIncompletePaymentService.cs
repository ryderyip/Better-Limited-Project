using System;
using Better_Limited_Project.Sales.OrderPlacing.Controller;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.PaymentUtility.UI;

namespace Better_Limited_Project.Sales.PaymentUtility
{
    public class SettleIncompletePaymentService
    {
        public event EventHandler? PaymentSettled;
        private readonly SalesOrder _salesOrder;

        public SettleIncompletePaymentService(SalesOrder salesOrder)
        {
            _salesOrder = salesOrder;
        }

        public void Start()
        {
            var form = new PaymentMethodSelectionForm();
            form.Selected += (_, method) => OpenPaymentForm(method);
            form.ShowDialog();
        }

        private void OpenPaymentForm(PaymentMethod method)
        {
            var calculator = new SalesOrderCalculator(_salesOrder.GetSalesOrderProducts());
            var amountDue = calculator.GetAmountDue();
            var form = PaymentFormFactory.Generate(amountDue, method);
            form.PaymentCompleted += (_, paymentMethod) =>
            {
                var payment = new Payment(amountDue, paymentMethod);
                payment.Save();
                foreach (var salesOrderProduct in _salesOrder.GetIncompletePaymentSalesOrderProducts())
                    new SalesOrderProductPayment(_salesOrder.Id, salesOrderProduct.ProductId, payment.Id,
                        isDeposit: false).Save();
                _salesOrder.Save();
                PaymentSettled?.Invoke(this, EventArgs.Empty);
            };
            form.ShowForm();
        }
    }
}