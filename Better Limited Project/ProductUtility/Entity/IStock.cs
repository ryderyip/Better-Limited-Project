using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.Entity
{
    public interface IStock
    {
        public Product Product { get; }
        public IWorkplace Workplace { get; }
        public int Quantity { get; }
        public int RestockLevel { get; }
    }
}