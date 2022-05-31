using System;

#nullable enable
namespace Better_Limited_Project.StaffUtility.StaffEntity
{
    [Serializable]
    public class Warehouse : IWorkplace
    {
        public string Id { get; }
        public string Name { get; }
        public string? Address { get; }

        public Warehouse(string id, string name, string? address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
    }
}