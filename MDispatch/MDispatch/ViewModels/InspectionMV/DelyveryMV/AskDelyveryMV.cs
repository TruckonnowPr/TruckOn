﻿using MDispatch.Models;
using MDispatch.Service;
using MDispatch.View;
using MDispatch.View.Inspection.Delyvery;
using Plugin.Settings;
using Prism.Mvvm;
using Rg.Plugins.Popup.Services;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using static MDispatch.Service.ManagerDispatchMob;

namespace MDispatch.ViewModels.InspectionMV.DelyveryMV
{
    public class AskDelyveryMV : BindableBase
    {
        public ManagerDispatchMob managerDispatchMob = null;
        public INavigation Navigation { get; set; }
        private InitDasbordDelegate initDasbordDelegate = null;

        public AskDelyveryMV(ManagerDispatchMob managerDispatchMob, VehiclwInformation vehiclwInformation, string idShip, INavigation navigation, InitDasbordDelegate initDasbordDelegate)
        {
            this.initDasbordDelegate = initDasbordDelegate;
            this.managerDispatchMob = managerDispatchMob;
            Navigation = navigation;
            VehiclwInformation = vehiclwInformation;
            IdShip = idShip;
        }

        private string IdShip { get; set; }

        private VehiclwInformation vehiclwInformation = null;
        public VehiclwInformation VehiclwInformation
        {
            get => vehiclwInformation;
            set => SetProperty(ref vehiclwInformation, value);
        }

        private AskDelyvery askDelyvery = null;
        public AskDelyvery AskDelyvery
        {
            get => askDelyvery;
            set => SetProperty(ref askDelyvery, value);
        }
        
        public TimeSpan TimeOfCurren
        {
            get => DateTime.Now.TimeOfDay;
        }

        public async void SaveAsk()
        {
            await PopupNavigation.PushAsync(new LoadPage(), true);
            string token = CrossSettings.Current.GetValueOrDefault("Token", "");
            string description = null;
            int state = 0;
            await Task.Run(() =>
            {
                state = managerDispatchMob.AskWork("AskDelyvery", token, VehiclwInformation.Id, askDelyvery, ref description);
                initDasbordDelegate.Invoke();
            });
            await PopupNavigation.PopAsync(true);
            if (state == 1)
            {
                //FeedBack = "Not Network";
            }
            else if (state == 2)
            {
                //FeedBack = description;
            }
            else if (state == 3)
            {
                await PopupNavigation.PushAsync(new TempDialogPage());
                await Navigation.PushAsync(new AskForUserDelyvery(managerDispatchMob, VehiclwInformation, IdShip, initDasbordDelegate));
                Navigation.RemovePage(Navigation.NavigationStack[2]);
            }
            else if (state == 4)
            {
                //FeedBack = "Technical work on the service";
            }
        }
    }
}