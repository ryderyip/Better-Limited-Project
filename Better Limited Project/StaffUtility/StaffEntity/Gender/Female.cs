using System;

namespace Better_Limited_Project.StaffUtility.StaffEntity.Gender
{
    [Serializable]
    public class Female : IGender
    {
        public string Name { get; } = "Female";
    }
}