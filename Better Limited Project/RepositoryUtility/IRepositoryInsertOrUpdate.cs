namespace Better_Limited_Project.RepositoryUtility
{
    public interface IRepositoryInsertOrUpdate<TEntity> where TEntity : IEntity
    {
        void InsertOrUpdate(TEntity entity);
    }
}