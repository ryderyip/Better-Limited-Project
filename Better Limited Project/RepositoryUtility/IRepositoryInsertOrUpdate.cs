namespace Better_Limited_Project.RepositoryUtility
{
    public interface IRepositoryInsertOrUpdate<TEntity>
    {
        void InsertOrUpdate(TEntity entity);
    }
}