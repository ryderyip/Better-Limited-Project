namespace Better_Limited_Project.RepositoryUtility
{
    public interface IRepositoryInsert<TEntity> where TEntity : IEntity
    {
        void Insert(TEntity entity);
    }
}