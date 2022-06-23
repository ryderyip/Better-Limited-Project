using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.Entity
{
    public interface IStock
    {
        string ProductId { get; }
        Product Product { get; }
        IWorkplace Workplace { get; }
        int Quantity { get; set; }
        int RestockLevel { get; set; }
        void Save();
        void Remove();
    }
}