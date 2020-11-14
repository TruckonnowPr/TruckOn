using MDispatch.ViewModels;
using Rg.Plugins.Popup.Services;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MDispatch.View.A_R
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Avtorization : ContentPage
	{
        private AvtorizationMV avtorizationMV = null;

        public Avtorization ()
		{
            InitializeComponent ();
            avtorizationMV = new AvtorizationMV();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = avtorizationMV;
        }

        private async void Entry_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            ValidationInpEmail(e.NewTextValue);
        }

        private void ValidationInpEmail(string email)
        {
            if (IsValidEmail(email))
            {
                doneImg.IsVisible = true;
                unDoneImg.IsVisible = false;
            }
            else
            {
                doneImg.IsVisible = false;
                unDoneImg.IsVisible = true;
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        [System.Obsolete]
        private async void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            await PopupNavigation.PushAsync(new ForgotPassword(avtorizationMV));
        }

        void TapGestureRecognizer_Tapped_1(System.Object sender, System.EventArgs e)
        {
            hdPswImg.IsVisible = false;
            unhdPswImg.IsVisible = true;
            passwordEnt.IsVisible = false;
        }

        void TapGestureRecognizer_Tapped_2(System.Object sender, System.EventArgs e)
        {
            hdPswImg.IsVisible = true;
            unhdPswImg.IsVisible = false;
            passwordEnt.IsVisible = true;
        }
    }
}