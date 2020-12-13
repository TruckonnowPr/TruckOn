using MDispatch.Models;
using MDispatch.Service;
using MDispatch.Service.Helpers;
using MDispatch.Service.Net;
using MDispatch.View.GlobalDialogView;
using Plugin.DeviceInfo;
using Plugin.DeviceInfo.Abstractions;
using Plugin.Settings;
using Prism.Commands;
using Prism.Mvvm;
using Rg.Plugins.Popup.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using static MDispatch.Service.ManagerDispatchMob;

namespace MDispatch.ViewModels.TAbbMV
{
    public class DelyveryMV : BindableBase
    {
        public ManagerDispatchMob managerDispatchMob = null;
        public INavigation Navigation { get; set; }
        public DelegateCommand RefreshCommand { get; set; }
        public InitDasbordDelegate initDasbordDelegate;

        public DelyveryMV(ManagerDispatchMob managerDispatchMob, INavigation navigation)
        {
            Navigation = navigation;
            Shippings = new List<Shipping>();
            initDasbordDelegate = Init;
            this.managerDispatchMob = managerDispatchMob;
            RefreshCommand = new DelegateCommand(PreVibartionLoad);
        }

        private List<Shipping> shippings = null;
        public List<Shipping> Shippings
        {
            get => shippings;
            set => SetProperty(ref shippings, value);
        }

        private bool isRefr = false;
        public bool IsRefr
        {
            get => isRefr;
            set => SetProperty(ref isRefr, value);
        }

        private void PreVibartionLoad()
        {
            if (CrossDeviceInfo.Current.Platform == Platform.Android)
            {
                Vibration.Vibrate(20);
            }
            Init();
        }

        [System.Obsolete]
        public async void Init()
        {
            IsRefr = true;
            string token = CrossSettings.Current.GetValueOrDefault("Token", "");
            string description = null;
            int state = 0;
            List<Shipping> shippings = null;
            await Task.Run(() =>  Utils.CheckNet());
            if (App.isNetwork)
            {
                await Task.Run(() =>
                {
                    state = managerDispatchMob.OrderWork("OrderDelyveryGet", token, ref description, ref shippings);
                });
                if (state == 1)
                {
                    GlobalHelper.OutAccount();
                    await PopupNavigation.PushAsync(new Alert(description, null));
                }
                else if (state == 2)
                {
                    //await PopupNavigation.PushAsync(new Errror(description, null));
                     HelpersView.CallError(description);
                }
                else if (state == 3)
                {
                    HelpersView.Hidden();
                    Shippings = shippings;
                }
                else if (state == 4)
                {
                    //await PopupNavigation.PushAsync(new Errror("Technical work on the service", null));
                    HelpersView.CallError("Technical work on the service");
                }
            }
            IsRefr = false;
        }
    }
}
