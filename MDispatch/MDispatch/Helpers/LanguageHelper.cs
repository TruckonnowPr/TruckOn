using MDispatch.Helpers.Language;
using MDispatch.Models.Enum;
using Plugin.Settings;

namespace MDispatch.Helpers
{
    public static class LanguageHelper
    {
        public static ILanguage Language { get; set; }

        public static string WelcomeText => Language.WelcomeText;
        public static string WelcomeDescriptionText => Language.WelcomeDescriptionText;
        public static string PlaceholderEmail => Language.PlaceholderEmail;
        public static string PlaceholderPassword => Language.PlaceholderPassword;
        public static string BtnLogInText => Language.BtnLogInText;
        public static string ForGotPasswordText => Language.ForGotPasswordText;

        public static void InitLanguage()
        {
            switch(CrossSettings.Current.GetValueOrDefault("Language" , (int)LanguageType.English))
            {
                case (int)LanguageType.English:
                    {
                        Language = new EnglishLanguage();
                        break;
                    }
            }
        }
    }
}
