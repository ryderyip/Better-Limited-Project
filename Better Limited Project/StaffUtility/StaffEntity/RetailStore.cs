using System;

#nullable enable
namespace Better_Limited_Project.StaffUtility.StaffEntity
{
    [Serializable]
    public class RetailStore : IWorkplace, IEntity
    {
        public string Id { get; }
        public string Name { get; }
        public string Address { get; }

        public RetailStore(string id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
    }
}