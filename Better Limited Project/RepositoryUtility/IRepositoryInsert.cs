namespace Better_Limited_Project.RepositoryUtility
{
    public interface IRepositoryInsert<TEntity>
    {
        void Insert(TEntity entity);
    }
}