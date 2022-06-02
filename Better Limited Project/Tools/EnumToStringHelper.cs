using System;
using System.ComponentModel.DataAnnotations;

namespace Better_Limited_Project.Tools
{
    public static class EnumToStringHelper
    {
        public static string GetDisplayValue(Enum @enum)
        {
            var fieldInfo = @enum.GetType().GetField(@enum.ToString());

            if (fieldInfo.GetCustomAttributes(
                typeof(DisplayAttribute), false) is not DisplayAttribute[] descriptionAttributes) return string.Empty;
            return descriptionAttributes.Length > 0 ? descriptionAttributes[0].Name : @enum.ToString();
        }
    }
}