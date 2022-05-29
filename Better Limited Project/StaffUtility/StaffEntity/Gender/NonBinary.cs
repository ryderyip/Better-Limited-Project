using System;

namespace Better_Limited_Project.StaffUtility.StaffEntity.Gender
{
    [Serializable]
    public class NonBinary : IGender
    {
        public string Name { get; } = "Non-Binary";
    }
}