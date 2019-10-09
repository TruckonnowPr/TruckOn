﻿using MDispatch.Models;
using MDispatch.NewElement.ToastNotify;
using MDispatch.Service;
using MDispatch.Service.Net;
using MDispatch.View;
using MDispatch.View.AskPhoto;
using MDispatch.View.GlobalDialogView;
using MDispatch.View.Inspection;
using MDispatch.View.Inspection.PickedUp;
using Newtonsoft.Json;
using Plugin.Settings;
using Prism.Mvvm;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using static MDispatch.Service.ManagerDispatchMob;

namespace MDispatch.ViewModels.InspectionMV
{
    public class Ask1PageMV : BindableBase
    {
        public ManagerDispatchMob managerDispatchMob = null;
        public INavigation Navigation { get; set; }
        public InitDasbordDelegate initDasbordDelegate = null;
        private GetVechicleDelegate getVechicleDelegate = null;

        public Ask1PageMV(ManagerDispatchMob managerDispatchMob, VehiclwInformation vehiclwInformation, string idShip, INavigation navigation, InitDasbordDelegate initDasbordDelegate, GetVechicleDelegate getVechicleDelegate, 
            string onDeliveryToCarrier, string totalPaymentToCarrier)
        {
            this.getVechicleDelegate = getVechicleDelegate;
            this.initDasbordDelegate = initDasbordDelegate;
            this.managerDispatchMob = managerDispatchMob;
            Navigation = navigation;
            VehiclwInformation = vehiclwInformation;
            IdShip = idShip;
            OnDeliveryToCarrier = onDeliveryToCarrier;
            TotalPaymentToCarrier = totalPaymentToCarrier;
        }

        public string IdShip { get; set; }
        public string OnDeliveryToCarrier { get; set; }
        public string TotalPaymentToCarrier { get; set; }

        private Ask1 ask1 = null;
        public Ask1 Ask1
        {
            get => ask1;
            set => SetProperty(ref ask1, value);
        }

        private VehiclwInformation vehiclwInformation = null;
        public VehiclwInformation VehiclwInformation
        {
            get => vehiclwInformation;
            set => SetProperty(ref vehiclwInformation, value);
        }

        [System.Obsolete]
        public async void SaveAsk()
        {
            bool isNavigationMany = false;
            if (Navigation.NavigationStack.Count > 2)
            {
                await PopupNavigation.PushAsync(new LoadPage());
                isNavigationMany = true;
            }
            string token = CrossSettings.Current.GetValueOrDefault("Token", "");
            string description = null;
            int state = 0;
            CheckVechicleAndGoToResultPage();
            await Task.Run(() => Utils.CheckNet());
            if (App.isNetwork)
            {
                await Task.Run(() =>
                {
                    state = managerDispatchMob.AskWork("SaveAsk1", token, VehiclwInformation.Id, Ask1, ref description);
                    initDasbordDelegate.Invoke();
                });
                if (state == 2)
                {
                    if (isNavigationMany)
                    {
                        await PopupNavigation.RemovePageAsync(PopupNavigation.PopupStack[0]);
                        isNavigationMany = false;
                    }
                    if (Navigation.NavigationStack.Count > 1)
                    {
                        await Navigation.PopAsync();
                    }
                    await PopupNavigation.PushAsync(new Errror(description, Navigation));
                }
                else if (state == 3)
                {
                    if (isNavigationMany)
                    {
                        await PopupNavigation.RemovePageAsync(PopupNavigation.PopupStack[0]);
                        isNavigationMany = false;
                    }
                    DependencyService.Get<IToast>().ShowMessage("Answers to questions saved");
                    Navigation.RemovePage(Navigation.NavigationStack[1]);
                }
                else if (state == 4)
                {
                    if (isNavigationMany)
                    {
                        await PopupNavigation.RemovePageAsync(PopupNavigation.PopupStack[0]);
                        isNavigationMany = false;
                    }
                    if (Navigation.NavigationStack.Count > 1)
                    {
                        await Navigation.PopAsync();
                    }
                    await PopupNavigation.PushAsync(new Errror("Technical work on the service", Navigation));
                }
            }
            else
            {
                if (Navigation.NavigationStack.Count > 1)
                {
                    await Navigation.PopAsync();
                }
            }
        }

        [System.Obsolete]
        private async void CheckVechicleAndGoToResultPage()
        {
            List<VehiclwInformation> vehiclwInformation1s = getVechicleDelegate.Invoke();
            int indexCurrentVechecle = vehiclwInformation1s.FindIndex(v => v == VehiclwInformation);
            if(vehiclwInformation1s.Count-1 == indexCurrentVechecle)
            {
                await Navigation.PushAsync(new ClientStart(managerDispatchMob, VehiclwInformation, IdShip, initDasbordDelegate, OnDeliveryToCarrier, TotalPaymentToCarrier));
                await PopupNavigation.PushAsync(new TempPageHint1());
            }
            else
            {
                await PopupNavigation.PushAsync(new HintPageVechicle("Continuing inspection Picked up", vehiclwInformation1s[indexCurrentVechecle + 1]));
                await Navigation.PushAsync(new AskPage(managerDispatchMob, vehiclwInformation1s[indexCurrentVechecle+1], IdShip, initDasbordDelegate, getVechicleDelegate, OnDeliveryToCarrier, TotalPaymentToCarrier), true);
            }
        }

        internal void ResetAskSeatBelts(byte[] oldRes, byte[] newRetake)
        {
            string base64 = JsonConvert.SerializeObject(newRetake);
            Photo photo = Ask1.App_will_force_driver_to_take_pictures_of_each_strap.FirstOrDefault(a => a.Base64 == JsonConvert.SerializeObject(oldRes));
            if (photo != null)
            {
                photo.Base64 = base64;
            }
        }

        internal void ResetAskInTrack(byte[] oldRes, byte[] newRetake)
        {

            string base64 = JsonConvert.SerializeObject(newRetake);
            Photo photo = Ask1.Photo_after_loading_in_the_truck.FirstOrDefault(a => a.Base64 == JsonConvert.SerializeObject(oldRes));
            if (photo != null)
            {
                photo.Base64 = base64;
            }
        }
    }
}