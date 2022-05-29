using System;

namespace Better_Limited_Project.StaffUtility.StaffEntity.Gender
{
    [Serializable]
    public class Male : IGender
    {
        public string Name { get; } = "Male";
    }
}