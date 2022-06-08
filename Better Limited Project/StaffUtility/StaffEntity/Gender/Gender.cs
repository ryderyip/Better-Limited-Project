using System.ComponentModel.DataAnnotations;

namespace Better_Limited_Project.StaffUtility.StaffEntity.Gender
{
    public enum Gender
    {
        [Display(Name = "Male")] 
        Male,
        [Display(Name = "Female")] Female, [Display(Name = "Non Binary")] NonBinary
    }
}