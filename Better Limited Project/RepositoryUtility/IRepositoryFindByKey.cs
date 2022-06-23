namespace Better_Limited_Project.RepositoryUtility
{
    public interface IRepositoryFindByKey<TEntity, TKey1>
    {
        TEntity? FindByKey(TKey1 key1);
    }

    public interface IRepositoryFindByKey<TEntity, TKey1, TKey2>
    {
        TEntity? FindByKeys(TKey1 key1, TKey2 key2);
    }
}