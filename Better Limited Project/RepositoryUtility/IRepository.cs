using System;
using System.Collections.Generic;

namespace Better_Limited_Project.RepositoryUtility
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        TEntity? FindById(string id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> FindAll(Predicate<TEntity> filter);
    }
}