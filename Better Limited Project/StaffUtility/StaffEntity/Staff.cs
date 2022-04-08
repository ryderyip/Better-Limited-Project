using System;
using Better_Limited_Project.Staff.StaffEntity;

namespace Better_Limited_Project.StaffUtility.StaffEntity
{
    public class Staff
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime HiredOn { get; set; }
        public char Gender { get; set; }
        public Department Department { get; set; }
        public StaffTitle StaffTitle { get; set; }
    }
}