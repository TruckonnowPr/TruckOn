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
    }
}
