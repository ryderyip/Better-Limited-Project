using System.Globalization;
using System.Threading;

namespace Better_Limited_Project.SettingsUtility
{
    /// <summary>
    ///     For switching languages in forms
    /// </summary>
    public static class LanguageController
    {
        /// <summary>
        ///     Set the language of all forms to the specified language
        /// </summary>
        public static void SetSystemLanguage(Language language)
        {
            string cultureName = GetCultureName(language);
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(cultureName);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(cultureName);
        }

        private static string GetCultureName(Language language)
        {
            return language switch
            {
                Language.TraditionalChinese => "zh-HK",
                Language.SimplifiedChinese => "zh-CHS",
                _ => "en-US"
            };
        }
    }
}