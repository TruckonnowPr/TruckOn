namespace MDispatch.Helpers.Language
{
    public interface ILanguage
    {
        string WelcomeText { get; }
        string WelcomeDescriptionText { get; }
        string PlaceholderEmail { get; }
        string PlaceholderPassword { get; }
        string BtnLogInText { get; }
        string ForGotPasswordText { get; }

        string PasswordChangeRequestTitel { get; }
        string PlaceholderEmailChangeRequest { get; }
        string NotCorectEmail { get; }
        string PlaceholderNameChangeRequest { get; }
        string PasswordChangeRequestBtnText { get; }

        string SuccessfulPasswordChangeRequest { get; }

        string InspectionTodayAlert { get; }
        string AskErrorAlert { get; }
        string PassTheDeviceAlert { get; }
        string TechnicalWorkServiceAlert { get; }
        string GiveMoneyAlert { get; }
        string PaymentForDeliveryAlert { get; }
        string NotNetworkAlert { get; }
        string NoVehiclesAlert { get; }
        string NoAvtorisationAlert { get; }
        string NoDataAlert { get; }
        string AnswersSaved { get; }
        string VideoSavedSuccessfully { get; }
        string PaymentSaved { get; }
        string FutureDispatcherProblem { get; }
        string BOLIsSent { get; }
        string InformationDeliverySaved { get; }
        string InformationPaymentSaved { get; }
        string InformationPikedUpSaved { get; }
        string FeedbackSaved { get; }
        string PaymmantMethodSaved { get; }

        string ScanPlateNumber { get; }

        string TitleSetPlateTruckAlert { get; }
        string TitleSetPlateTrailerAlert { get; }
        string PlaceholderSetPlateTruckAlert { get; }
        string PlaceholderSetPlateTrailerkAlert { get; }
        string CancelBtnText { get; }
        string SendBtnText { get; }

        string TitleInfoPage { get; }
        string TitlePikedUpInfo { get; }
        string TitleDeliveryInfo { get; }
        string TitlePaymentInfo { get; }
        string ContatInfo { get; }
        string PhoneInfo { get; }
        string PaymentInfo { get; }
        string Instructions { get; }
        string ReedInstructionsBtnText { get; }

        string TitleSettingsPage { get; }
        string DocumentInfo { get; }
        string ShowDocumentBtnText { get; }
        string LastInspactionInfo { get; }
        string TruckPlateInfo { get; }
        string TrailerPalateInfo { get; }
        string TitleDocumentsTrailerTruckNumber { get; }
        string NumberTruckPlateInfo { get; }
        string NumberTrailerPalateInfo { get; }
        string Application { get; }
        string CurrentVersion { get; }
        string LastUpdateAvailable { get; }
        string SignOutBtnText { get; }

        string NamePageTabActive { get; }
        string NamePageTabDelivery { get; }
        string NamePageTabArchived { get; }

        string TitleInspectionDriverAlert { get; }
        string YesBtnText { get; }
        string NoBtnText { get; }
    }
}
