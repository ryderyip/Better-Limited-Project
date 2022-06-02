using System;
using System.Collections.Generic;
using Better_Limited_Project.RepositoryUtility;

namespace Better_Limited_Project.ServiceUtility.Installation
{
    public  class InstallationRequestRepository : IRepository<InstallationRequest>, IRepositoryInsertOrUpdate<InstallationRequest>
    {
        public void InsertOrUpdate(InstallationRequest entity)
        {
            throw new System.NotImplementedException();
        }

        public InstallationRequest FindById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InstallationRequest> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InstallationRequest> FindAll(Predicate<InstallationRequest> filter)
        {
            throw new NotImplementedException();
        }
    }
}