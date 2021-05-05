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
    }
}
