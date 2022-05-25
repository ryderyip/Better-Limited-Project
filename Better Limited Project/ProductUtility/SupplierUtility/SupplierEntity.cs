namespace Better_Limited_Project.ProductUtility.SupplierUtility
{
    public class SupplierEntity : IEntity
    {
        public string Id { get; }
        public Supplier Supplier { get; }

        public SupplierEntity(string id, Supplier supplier)
        {
            Id = id;
            Supplier = supplier;
        }
    }
}