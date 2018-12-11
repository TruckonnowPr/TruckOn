﻿using MDispatch.Models;
using Plugin.Settings;
using Prism.Mvvm;
using System.Threading.Tasks;

namespace MDispatch.ViewModels.AskPhoto
{
    public class AskPageMV : BindableBase
    {
        public ManagerDispatchMob managerDispatchMob = null;

        public AskPageMV(ManagerDispatchMob managerDispatchMob, VehiclwInformation vehiclwInformation)
        {
            this.managerDispatchMob = managerDispatchMob;
            VehiclwInformation = vehiclwInformation;
        }

        private Ask ask = null;
        public Ask Ask
        {
            get => ask;
            set => SetProperty(ref ask, value);
        }

        private VehiclwInformation vehiclwInformation = null;
        public VehiclwInformation VehiclwInformation
        {
            get => vehiclwInformation;
            set => SetProperty(ref vehiclwInformation, value);
        }

        public async void SaveAsk()
        {
            string token = CrossSettings.Current.GetValueOrDefault("Token", "");
            string description = null;
            int state = 0;
            await Task.Run(() =>
            {
               //state = managerDispatchMob.PhotoWork("SavePhoto", token, VehiclwInformation.Id, PhotoInArrayByte, ref description);
            });
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

            }
            else if (state == 4)
            {
                //FeedBack = "Technical work on the service";
            }
        }
    }
}
