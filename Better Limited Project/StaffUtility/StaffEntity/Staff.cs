using System;

namespace Better_Limited_Project.StaffUtility.StaffEntity
{
    public class Staff
    {
        public Staff(string? id, string name, DateTime dateOfBirth, DateTime hiredOn, char gender, Department department, StaffTitle title)
        {
            Id = id;
            Name = name;
            DateOfBirth = dateOfBirth;
            HiredOn = hiredOn;
            Gender = gender;
            Department = department;
            Title = title;
        }

        public string? Id { get; }
        public string Name { get; }
        public DateTime DateOfBirth { get; }
        public DateTime HiredOn { get; }
        public char Gender { get; }
        public Department Department { get; }
        public StaffTitle Title { get; }
    }
}