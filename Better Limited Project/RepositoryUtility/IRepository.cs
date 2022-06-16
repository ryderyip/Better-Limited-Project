using System;
using System.Collections.Generic;

namespace Better_Limited_Project.RepositoryUtility
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> FindAll(Predicate<TEntity> filter);
    }
}