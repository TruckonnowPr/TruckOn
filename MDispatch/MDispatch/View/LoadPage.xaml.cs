using System.Threading;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MDispatch.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoadPage : PopupPage
    {
		public LoadPage ()
		{
			InitializeComponent ();
            StartAnimation();
        }

        protected override bool OnBackgroundClicked()
        {
            return false;
        }

        private void StartAnimation()
        {
            var animation = new Animation(v => loaderImg.Scale = v, 1, 1.7);
            animation.Commit(this, "ScaleIt", length: 400, easing: Easing.SinInOut,
                finished: (v, c) => EndAnimation());
        }

        private void EndAnimation()
        {
            var animation = new Animation(v => loaderImg.Scale = v, 1.7, 1);
            animation.Commit(this, "ScaleIt", length: 400, easing: Easing.SinInOut,
                finished: (v, c) => StartAnimation());
        }
    }
}