#nullable enable
using System;

namespace Better_Limited_Project.SettingsUtility
{
    [Serializable]
    public class WorkplaceInformation
    {
        public string Name { get; set; }
        public string ?Address { get; set; }
        
        /// <param name="name">Name of the workplace</param>
        public WorkplaceInformation(string name)
        {
            Name = name;
        }
    }
}