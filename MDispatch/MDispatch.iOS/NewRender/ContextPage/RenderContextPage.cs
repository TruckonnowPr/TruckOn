using System;
using System.Collections.Generic;
using CoreGraphics;
using FormsControls.Base;
using MDispatch.iOS.NewRender.ContextPage;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: Xamarin.Forms.ExportRenderer(typeof(AnimationNavigationPage), typeof(RenderContextPage))]
namespace MDispatch.iOS.NewRender.ContextPage
{
    public class RenderContextPage : NavigationRenderer
    {
        public RenderContextPage()
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var nb = (AnimationNavigationPage)Element;
            if (InteractivePopGestureRecognizer != null)
            {
                InteractivePopGestureRecognizer.Enabled = false;

                if (nb != null)
                {
                    nb.BarBackgroundColor = Color.FromHex("#ffff");
                    nb.BarTextColor = Color.FromHex("#000000");
                }

            }
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            UINavigationBar.Appearance.SetTitleTextAttributes(new UITextAttributes()
            {
                Font = UIFont.FromName("Open Sans", 20),
            });
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            UIViewController vc = NavigationController.TopViewController;

            List<UIBarButtonItem> items = new List<UIBarButtonItem>();
            int i = ((ContentPage)Element).ToolbarItems.Count - 1;
            foreach (UIBarButtonItem item in vc.NavigationItem.RightBarButtonItems)
            {
                ToolbarItem toolBarItem = ((ContentPage)Element).ToolbarItems[i];

                UIButton btn = new UIButton(UIButtonType.Custom);
                btn.SetImage(item.Image, UIControlState.Normal);
                btn.Frame = new CGRect(0, 0, 23, 23);
                btn.TouchUpInside += (sender, args) =>
                {
                    item.Target.PerformSelector(item.Action, null, 0.0);
                };

                UIBarButtonItem customItem = new UIBarButtonItem(btn);
                customItem.CustomView.WidthAnchor.ConstraintEqualTo(10).Active = true;
                customItem.CustomView.HeightAnchor.ConstraintEqualTo(10).Active = true;
                items.Add(customItem);

                i--;
            }

            vc.NavigationItem.RightBarButtonItems = items.ToArray();
        }
    }
}