namespace Better_Limited_Project.RepositoryUtility
{
    public interface IRepositoryDelete<TEntity>
    {
        void Delete(TEntity entity);
    }
}