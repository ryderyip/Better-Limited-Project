using System;

namespace Better_Limited_Project.StaffUtility.StaffEntity.Gender
{
    public static class GenderConverter
    {
        public static Gender Convert(char gender)
        {
            return gender.ToString().ToLower() switch
            {
                "m" => Gender.Male,
                "f" => Gender.Female,
                "n" => Gender.NonBinary,
                _ => throw new ArgumentException($"Gender \"{gender}\" is unidentifiable.")
            };
        }

        public static char Convert(Gender gender)
        {
            return gender switch
            {
                Gender.Male => 'M',
                Gender.Female => 'F',
                Gender.NonBinary => 'N',
                _ => throw new ArgumentException("Unknown/Not implemented gender.")
            };
        }
    }
}