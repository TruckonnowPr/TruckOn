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

        public static string ScanPlateNumber => Language.ScanPlateNumber;
        public static string TitleSetPlateTruckAlert => Language.TitleSetPlateTruckAlert;
        public static string TitleSetPlateTrailerAlert => Language.TitleSetPlateTrailerAlert;
        public static string PlaceholderSetPlateTruckAlert => Language.PlaceholderSetPlateTruckAlert;
        public static string PlaceholderSetPlateTrailerkAlert => Language.PlaceholderSetPlateTrailerkAlert;
        public static string CancelBtnText => Language.CancelBtnText;
        public static string SendBtnText => Language.SendBtnText;

        public static string TitleInfoPage => Language.TitleInfoPage;
        public static string TitlePikedUpInfo => Language.TitlePikedUpInfo;
        public static string TitleDeliveryInfo => Language.TitleDeliveryInfo;
        public static string TitlePaymentInfo => Language.TitlePaymentInfo;
        public static string ContatInfo => Language.ContatInfo;
        public static string PhoneInfo => Language.PhoneInfo;
        public static string PaymentInfo => Language.PaymentInfo;
        public static string Instructions => Language.Instructions;
        public static string ReedInstructionsBtnText => Language.ReedInstructionsBtnText;

        public static string TitleSettingsPage => Language.TitleSettingsPage;
        public static string DocumentInfo => Language.DocumentInfo;
        public static string ShowDocumentBtnText => Language.ShowDocumentBtnText;
        public static string LastInspactionInfo => Language.LastInspactionInfo;
        public static string TruckPlateInfo => Language.TruckPlateInfo;
        public static string TrailerPalateInfo => Language.TrailerPalateInfo;
        public static string TitleDocumentsTrailerTruckNumber => Language.TitleDocumentsTrailerTruckNumber;
        public static string NumberTruckPlateInfo => Language.NumberTruckPlateInfo;
        public static string NumberTrailerPalateInfo => Language.NumberTrailerPalateInfo;
        public static string Application => Language.Application;
        public static string CurrentVersion => Language.CurrentVersion;
        public static string LastUpdateAvailable => Language.LastUpdateAvailable;
        public static string SignOutBtnText => Language.SignOutBtnText;

        public static string NamePageTabActive => Language.NamePageTabActive;
        public static string NamePageTabDelivery => Language.NamePageTabDelivery;
        public static string NamePageTabArchived => Language.NamePageTabArchived;

        public static string TitleInspectionDriverAlert => Language.TitleInspectionDriverAlert;
        public static string YesBtnText => Language.YesBtnText;
        public static string NoBtnText => Language.NoBtnText;

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
