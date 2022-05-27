namespace Better_Limited_Project.RepositoryUtility
{
    public interface IRepositoryDelete<TEntity> where TEntity : IEntity
    {
        void Delete(TEntity entity);
    }
}