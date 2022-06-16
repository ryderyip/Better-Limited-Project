using System;
using System.Drawing;
using System.Linq;
using Better_Limited_Project.Login;
using Better_Limited_Project.Properties;
using Better_Limited_Project.StaffUtility.Repository;

namespace Better_Limited_Project.StaffUtility.StaffEntity
{
    [Serializable]
    public class Staff : IEntity
    {
        public Staff(string name, DateTime dateOfBirth, DateTime hiredOn, Gender.Gender gender, Department department, StaffTitle title)
        {
            Id = new StaffRepository().GetNewId();
            Name = name;
            DateOfBirth = dateOfBirth;
            HiredOn = hiredOn;
            Gender = gender;
            Department = department;
            Title = title;
        }

        public Staff(string id, string name, DateTime dateOfBirth, DateTime hiredOn, Gender.Gender gender, Department department, StaffTitle title)
        {
            Id = id;
            Name = name;
            DateOfBirth = dateOfBirth;
            HiredOn = hiredOn;
            Gender = gender;
            Department = department;
            Title = title;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime HiredOn { get; set; }
        public Gender.Gender Gender { get; set; }
        public Department Department { get; set; }
        public StaffTitle Title { get; set; }

        public void Save()
        {
            new StaffRepository().Insert(this);
        }

        public void SetImage(Image image)
        {
            StaffImageRepository.InsertOrUpdate(this, image);
        }

        public Image GetImage()
        {
            return StaffImageRepository.GetByStaffId(Id)
                   ?? Resources.no_image;
        }

        public void Remove()
        {
            StaffImageRepository.Delete(Id);
            new StaffRepository().RemoveStaff(this);
        }

        public StaffAccount GetLoginAccount()
        {
            return new StaffAccountRepository().GetAll().FirstOrDefault(ac => ac.StaffId == Id)
                   ?? throw new InvalidOperationException($"Staff \"{Name} ({Id}) does not have a staff account.");
        }
    }
}