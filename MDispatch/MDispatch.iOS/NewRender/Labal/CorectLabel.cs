using System;
using MDispatch.iOS.NewRender.Labal;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(Label), typeof(CorectLabel))]
namespace MDispatch.iOS.NewRender.Labal
{
    public class CorectLabel : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Label> e)
        {
            base.OnElementChanged(e);
        }
    }
}
