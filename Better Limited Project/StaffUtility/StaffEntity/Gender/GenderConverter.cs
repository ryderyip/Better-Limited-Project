using System;

namespace Better_Limited_Project.StaffUtility.StaffEntity.Gender
{
    public static class GenderConverter
    {
        public static IGender Convert(char gender)
        {
            return gender.ToString().ToLower() switch
            {
                "m" => new Male(),
                "f" => new Female(),
                "n" => new NonBinary(),
                _ => throw new ArgumentException($"Gender \"{gender}\" is unidentifiable.")
            };
        }

        public static char Convert(IGender gender)
        {
            return gender switch
            {
                Male => 'M',
                Female => 'F',
                NonBinary => 'N',
                _ => throw new ArgumentException($"Unknown/Not implemented gender.")
            };
        }
    }
}