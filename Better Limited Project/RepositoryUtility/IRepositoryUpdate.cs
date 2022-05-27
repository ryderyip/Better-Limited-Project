namespace Better_Limited_Project.RepositoryUtility
{
    public interface IRepositoryUpdate<TEntity> where TEntity : IEntity
    {
        void Update(TEntity entity);
    }
}