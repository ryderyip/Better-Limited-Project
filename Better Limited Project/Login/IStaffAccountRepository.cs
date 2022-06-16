using Better_Limited_Project.RepositoryUtility;

namespace Better_Limited_Project.Login
{
    public interface IStaffAccountRepository : IRepository<StaffAccount>, IRepositoryInsertOrUpdate<StaffAccount>,
        IRepositoryDelete<StaffAccount>, IRepositoryFindByKey<StaffAccount, string>
    {}
}