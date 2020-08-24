using Xamarin.Forms;

namespace MDispatch.NewElement.AuntificationID
{
    public static class AuthenticationID
    {
        public static void AvtorizatiionID()
        {
            DependencyService.Get<IAuntificationID>().GetAuthenticationMethod();
            if (DependencyService.Get<IAuntificationID>().BiometryType != "none")
            {
                DependencyService.Get<IAuntificationID>().Authentication();
            }
        }
    }
}