using System;
using Better_Limited_Project.StaffUtility.StaffEntity.Gender;

namespace Better_Limited_Project.StaffUtility.StaffEntity
{
    public class Staff : IEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime HiredOn { get; set; }
        public IGender Gender { get; set; }
        public Department Department { get; set; }
        public StaffTitle Title { get; set; }

        public void Save()
        {
            var repo = new StaffRepository();
            if (repo.FindById(Id) == null)
                repo.Insert(this);
            else
                repo.Update(this);
        }
    }
}