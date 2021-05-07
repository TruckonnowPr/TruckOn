namespace MDispatch.Helpers.Language
{
    public class EnglishLanguage : ILanguage
    {
        public string WelcomeText => "Welcome Back";
        public string WelcomeDescriptionText => "Log in to continue";
        public string PlaceholderEmail => "Email";
        public string PlaceholderPassword => "Password";
        public string BtnLogInText => "Log in";
        public string ForGotPasswordText => "Forgot password?";

        public string PasswordChangeRequestTitel => "Password Change Request";
        public string PlaceholderEmailChangeRequest => "Enter your mail here";
        public string NotCorectEmail => "The entered mail format is not correct";
        public string PlaceholderNameChangeRequest => "Enter your full name here";
        public string PasswordChangeRequestBtnText => "Request Password Changes";

        public string SuccessfulPasswordChangeRequest => "Password reset data sent to you by mail:";

        public string InspectionTodayAlert => "You have already passed inspection today";
        public string AskErrorAlert => "You did not fill in all the required fields, you can continue the inspection only when filling in the required fields !!";
        public string PassTheDeviceAlert => "Please pass the device to the client";
        public string TechnicalWorkServiceAlert => "Technical work on the service";
        public string GiveMoneyAlert => "Give money for delivery to the driver";
        public string PaymentForDeliveryAlert => "You must enter the amount of payment for delivery";
        public string NotNetworkAlert => "Not Network";
        public string NoVehiclesAlert => "There are no vehicles in the order.\n\nIn order to pass the inspection, ask the dispatcher to add a vehicle.";
        public string NoAvtorisationAlert => "Not Authorized";
        public string NoDataAlert => "No Data";
        public string AnswersSaved => "Answers to questions saved";
        public string VideoSavedSuccessfully => "Video capture saved successfully";
        public string PaymentSaved => "Payment method photo saved";
        public string FutureDispatcherProblem => "In the near future the dispatcher see the problem";
        public string BOLIsSent => "A copy of BOL is sent to the mail";
        public string InformationDeliverySaved => "Information about delivery saved";
        public string InformationPaymentSaved => "Information about Paymmant saved";
        public string InformationPikedUpSaved => "Information about Picked Up saved";
        public string FeedbackSaved => "Feedback saved";
        public string PaymmantMethodSaved => "Paymmant method saved";

        public string ScanPlateNumber => "Scan Plate number";
        public string TitleSetPlateTruckAlert => "Please write the number plate of the truck";
        public string TitleSetPlateTrailerAlert => "Please write the number plate of the trailer";
        public string PlaceholderSetPlateTruckAlert => "Enter № plate truck";
        public string PlaceholderSetPlateTrailerkAlert => "Enter № plate trailer";
        public string CancelBtnText => "Cancel";
        public string SendBtnText => "Send";

        public string TitleInfoPage => "Info";
        public string TitlePikedUpInfo => "Pickup information";
        public string TitleDeliveryInfo => "Delivery information";
        public string TitlePaymentInfo => "Payment information";
        public string ContatInfo => "Contact: ";
        public string PhoneInfo => "Phone: ";
        public string PaymentInfo => "Payment: ";
        public string Instructions => "Instructions";
        public string ReedInstructionsBtnText => "I have read the instructions";

        public string TitleSettingsPage => "Settings";
        public string DocumentInfo => "Documents";
        public string ShowDocumentBtnText => "Show documents";
        public string LastInspactionInfo => "Last inspection: ";
        public string TruckPlateInfo => "Truck plate: ";
        public string TrailerPalateInfo => "Trailer plate: ";
        public string TitleDocumentsTrailerTruckNumber => "Documents by trailer and truck number";
        public string NumberTruckPlateInfo => "№ plate truck:";
        public string NumberTrailerPalateInfo => "№ plate trailer:";
        public string Application => "Application";
        public string CurrentVersion => "Current version: ";
        public string LastUpdateAvailable => "Last update available: ";
        public string SignOutBtnText => "Sign out";

        public string NamePageTabActive => "Active";
        public string NamePageTabDelivery => "Delivery";
        public string NamePageTabArchived => "Archived";

        public string TitleInspectionDriverAlert => "To take an order, you need to pass the inspection of the truck and the trailer, pass the inspection of the truck?";
        public string YesBtnText => "Yes";
        public string NoBtnText => "No";
    }
}