using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.Entity
{
    public interface IStock
    {
        Product Product { get; }
        IWorkplace Workplace { get; }
        int Quantity { get; set; }
        int RestockLevel { get; set; }
        void Update();
    }
}