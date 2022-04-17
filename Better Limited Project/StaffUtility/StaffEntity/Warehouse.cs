using System;

#nullable enable
namespace Better_Limited_Project.SettingsUtility
{
    [Serializable]
    public readonly struct Warehouse : IWorkplace
    {
        public string Name { get; }
        public string? Address { get; }
        
        public Warehouse(string name, string? address)
        {
            Name = name;
            Address = address;
        }
    }
}