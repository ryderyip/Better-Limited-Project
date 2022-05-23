using System;

namespace Better_Limited_Project.StaffUtility.StaffEntity
{
    public static class DateTimePickerHelper
    {
        private const int DaysInAYear = 365;
        
        public static DateTime GetBirthdayMaximumDate()
        {
            return DateTime.Today - TimeSpan.FromDays(DaysInAYear * 18);
        }

        public static DateTime GetBirthdayMinimumDate()
        {
            return DateTime.Today - TimeSpan.FromDays(DaysInAYear * 200);
        }
    }
}