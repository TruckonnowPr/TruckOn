﻿using MDispatch.NewElement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MDispatch.View.AskPhoto.CameraPageFolder
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CameraItems : CameraPage
    {
        AskPage askPage = null;

        public CameraItems (AskPage askPage)
		{
            this.askPage = askPage;
            InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);

        }

        private async void CameraPage_OnPhotoResult(PhotoResultEventArgs result)
        {
            await Navigation.PopAsync(true);
            if (!result.Success)
                return;
            askPage.AddPhotoItems(result.Image);
        }
    }
}