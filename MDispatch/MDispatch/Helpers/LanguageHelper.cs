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

        public static string ContinuingInspectionDelivery => Language.ContinuingInspectionDelivery;
        public static string ContinuingInspectionPickedUp => Language.ContinuingInspectionPickedUp;
        public static string StartInspectionDelivery => Language.StartInspectionDelivery;
        public static string StartInspectionPickedUp => Language.StartInspectionPickedUp;

        public static string HintPhotoItemsPage => Language.HintPhotoItemsPage;
        public static string HintPhotoInspactionPage => Language.HintPhotoInspactionPage;
        public static string HintPhotoInTruckPage => Language.HintPhotoInTruckPage;
        public static string HintPhotoSeatBeltsPage => Language.HintPhotoSeatBeltsPage;

        public static string TitleAskQuestionPage => Language.TitleAskQuestionPage;
        public static string ItemNextPage => Language.ItemNextPage;

        public static string AskBlockWeatherTitle => Language.AskBlockWeatherTitle;
        public static string ClearAnswer => Language.ClearAnswer;
        public static string RainAnswer => Language.RainAnswer;
        public static string SnowAnswer => Language.SnowAnswer;
        public static string DustAnswer => Language.DustAnswer;

        public static string AskBlockLightBrightnessTitle => Language.AskBlockLightBrightnessTitle;
        public static string HighAnswer => Language.HighAnswer;
        public static string LowAnswer => Language.LowAnswer;

        public static string AskBlockSafeLoctionTitle => Language.AskBlockSafeLoctionTitle;

        public static string AskBlockFarFromTrailerTitle => Language.AskBlockFarFromTrailerTitle;
        public static string PlaceholderFarFromTrailerAnswer => Language.PlaceholderFarFromTrailerAnswer;

        public static string AskBlockGaveKeysTitle => Language.AskBlockGaveKeysTitle;
        public static string PlaceholderGaveKeysAnswer => Language.PlaceholderGaveKeysAnswer;

        public static string AskBlockEnoughSpaceTitle => Language.AskBlockEnoughSpaceTitle;

        public static string AskBlockAnyoneRushingTitle => Language.AskBlockAnyoneRushingTitle;

        public static string AskBlockNamePersonTitle => Language.AskBlockNamePersonTitle;
        public static string PlaceholderNamePersonAnswer => Language.PlaceholderNamePersonAnswer;

        public static string AskBlockTypeCarTitle => Language.AskBlockTypeCarTitle;

        public static string AskBlockPlateTitle => Language.AskBlockPlateTitle;
        public static string PlaceholderPlateAnswer => Language.PlaceholderPlateAnswer;

        public static string AskBlockConditionTitle => Language.AskBlockConditionTitle;
        public static string CleanAnswer => Language.CleanAnswer;
        public static string DirtyAnswer => Language.DirtyAnswer;
        public static string Snow1Answer => Language.Snow1Answer;
        public static string WetAnswer => Language.WetAnswer;
        public static string ExtraDirtyAnswer => Language.ExtraDirtyAnswer;

        public static string AskBlockAdditionalItemsTitle => Language.AskBlockAdditionalItemsTitle;

        public static string HintAddDamagePage => Language.HintAddDamagePage;
        public static string NextInspactionBtnText => Language.NextInspactionBtnText;
        public static string BackMainBtnText => Language.BackMainBtnText;

        public static string RetakeBtnText => Language.RetakeBtnText;
        public static string NextBtnText => Language.NextBtnText;
        public static string AddDamagBtnText => Language.AddDamagBtnText;
        public static string AddPhotoText => Language.AddPhotoText;

        public static string AskBlockJumpedVehicleTitle => Language.AskBlockJumpedVehicleTitle;

        public static string AskBlockMusteMileageTitle => Language.AskBlockMusteMileageTitle;
        public static string PlaceholderMusteMileage => Language.PlaceholderMusteMileage;

        public static string AskBlockImperfectionsWileLoadingTitle => Language.AskBlockImperfectionsWileLoadingTitle;
        public static string PlaceholderMechanicalDefects => Language.PlaceholderMechanicalDefects;

        public static string AskBlockMethodExitTitle => Language.AskBlockMethodExitTitle;
        public static string DoorAnswer => Language.DoorAnswer;
        public static string WindowAnswer => Language.WindowAnswer;
        public static string SunroofAnswer => Language.SunroofAnswer;
        public static string ConvertibleAnswer => Language.ConvertibleAnswer;

        public static string AskBlockHelpYouLoadTitle => Language.AskBlockHelpYouLoadTitle;
        public static string AskBlockLoadTheVehicleTitle => Language.AskBlockLoadTheVehicleTitle;
        public static string PlaceholderName => Language.PlaceholderName;

        public static string AskBlockDamageAnythingTitle => Language.AskBlockDamageAnythingTitle;
        public static string PlaceholderIfAny => Language.PlaceholderIfAny;

        public static string AskBlockUsedWinchTitle => Language.AskBlockUsedWinchTitle;

        public static string TitleHelloCustomerPage => Language.TitleHelloCustomerPage;
        public static string ThankYouForUsingOurCompany => Language.ThankYouForUsingOurCompany;
        public static string ThankYouForUsingOurCompany1 => Language.ThankYouForUsingOurCompany1;
        public static string StartBtnText => Language.StartBtnText;

        public static string AskBlockFullNameTitle => Language.AskBlockFullNameTitle;
        public static string PlaceholderFullName => Language.PlaceholderFullName;

        public static string AskBlockYourPhoneTitle => Language.AskBlockYourPhoneTitle;
        public static string PlaceholderYourPhone => Language.PlaceholderYourPhone;

        public static string AskBlockManyKesTitle => Language.AskBlockManyKesTitle;
        public static string PlaceholderManyKes => Language.PlaceholderManyKes;

        public static string AskBlockGivenToDriverTitle => Language.AskBlockGivenToDriverTitle;
        public static string IDontKnowBtnText => Language.IDontKnowBtnText;

        public static string ContinuetnBtnText => Language.ContinuetnBtnText;

        public static string TitleBillOfLandingPage => Language.TitleBillOfLandingPage;

        public static string TitleOriginInfo => Language.TitleOriginInfo;
        public static string TitleDestinatiinInfo => Language.TitleDestinatiinInfo;
        public static string TitleYourSignature => Language.TitleYourSignature;
        public static string SaveBtnText => Language.SaveBtnText;

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
