using MDispatch.Helpers.Language;
using MDispatch.Models.Enum;
using Plugin.Settings;

namespace MDispatch.Helpers
{
    public static class LanguageHelper
    {
        private static ILanguage Language { get; set; }

        public static string WelcomeText => Language.WelcomeText;
        public static string WelcomeDescriptionText => Language.WelcomeDescriptionText;
        public static string PlaceholderEmail => Language.PlaceholderEmail;
        public static string PlaceholderPassword => Language.PlaceholderPassword;
        public static string BtnLogInText => Language.BtnLogInText;
        public static string ForGotPasswordText => Language.ForGotPasswordText;

        public static string PasswordChangeRequestTitel => Language.PasswordChangeRequestTitel;
        public static string PlaceholderEmailChangeRequest => Language.PlaceholderEmailChangeRequest;
        public static string NotCorectEmail => Language.NotCorectEmail;
        public static string PlaceholderNameChangeRequest => Language.PlaceholderNameChangeRequest;
        public static string PasswordChangeRequestBtnText => Language.PasswordChangeRequestBtnText;

        public static string SuccessfulPasswordChangeRequest => Language.SuccessfulPasswordChangeRequest;

        public static string InspectionTodayAlert => Language.InspectionTodayAlert;
        public static string AskErrorAlert => Language.AskErrorAlert;
        public static string PassTheDeviceAlert => Language.PassTheDeviceAlert;
        public static string TechnicalWorkServiceAlert => Language.TechnicalWorkServiceAlert;
        public static string GiveMoneyAlert => Language.GiveMoneyAlert;
        public static string PaymentForDeliveryAlert => Language.PaymentForDeliveryAlert;
        public static string NotNetworkAlert => Language.NotNetworkAlert;
        public static string NoVehiclesAlert => Language.NoVehiclesAlert;
        public static string NoAvtorisationAlert => Language.NoAvtorisationAlert;
        public static string NoDataAlert => Language.NoDataAlert;
        public static string AnswersSaved => Language.AnswersSaved;
        public static string VideoSavedSuccessfully => Language.VideoSavedSuccessfully;
        public static string PaymentSaved => Language.PaymentSaved;
        public static string FutureDispatcherProblem => Language.FutureDispatcherProblem;
        public static string BOLIsSent => Language.BOLIsSent;
        public static string InformationDeliverySaved => Language.InformationDeliverySaved;
        public static string InformationPaymentSaved => Language.InformationPaymentSaved;
        public static string InformationPikedUpSaved => Language.InformationPikedUpSaved;
        public static string FeedbackSaved => Language.FeedbackSaved;
        public static string PaymmantMethodSaved => Language.PaymmantMethodSaved;

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
