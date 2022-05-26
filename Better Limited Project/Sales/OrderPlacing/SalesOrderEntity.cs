namespace Better_Limited_Project.Sales.OrderPlacing
{
    public class SalesOrderEntity : IEntity
    {
        public string Id { get; }
        public SalesOrder SalesOrder { get; }

        public SalesOrderEntity(string id, SalesOrder salesOrder)
        {
            Id = id;
            SalesOrder = salesOrder;
        }
    }
}