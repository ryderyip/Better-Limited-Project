namespace Better_Limited_Project.Sales.Sales.SalesOrder
{
    public class PlaceOrderController
    {
        public void OpenForm()
        {
            var form = new PlaceOrderForm();
            // TODO sub to form events
            form.ShowDialog();
        }
    }
}