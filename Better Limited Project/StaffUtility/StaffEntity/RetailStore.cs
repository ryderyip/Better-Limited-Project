using System;

#nullable enable
namespace Better_Limited_Project.SettingsUtility
{
    [Serializable]
    public readonly struct RetailStore : IWorkplace
    {
        public string Name { get; }
        public string? Address { get; }

        public RetailStore(string name, string? address)
        {
            Name = name;
            Address = address;
        }
    }
}