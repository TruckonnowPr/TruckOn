﻿using MDispatch.NewElement;
using MDispatch.ViewModels.AskPhoto;
using Xamarin.Forms;

namespace MDispatch.ViewModels.InspectionMV.Models
{
    public class CarPickUp : ICar
    {
        public string typeIndex { get; set; } = "Pick Up";
        public int CountCarImg { get; set; } = 35;

        public string GetNameLayout(int inderxPhotoInspektion)
        {
            string nameLayout = "";
            return nameLayout;
        }

        public async void OrintableScreen(int inderxPhotoInspektion)
        {
            DependencyService.Get<IOrientationHandler>().ForceSensor();
            //if (inderxPhotoInspektion == 2 || inderxPhotoInspektion == 3)
            //{
            //    DependencyService.Get<IOrientationHandler>().ForceSensor();
            //}
            //else if (inderxPhotoInspektion == 7 || inderxPhotoInspektion == 8 || inderxPhotoInspektion == 9 || inderxPhotoInspektion == 10 || inderxPhotoInspektion == 10
            //    || inderxPhotoInspektion == 12 || inderxPhotoInspektion == 13 || inderxPhotoInspektion == 14 || inderxPhotoInspektion == 15 || inderxPhotoInspektion == 16
            //    || inderxPhotoInspektion == 17 || inderxPhotoInspektion == 18 || inderxPhotoInspektion == 19 || inderxPhotoInspektion == 20 || inderxPhotoInspektion == 22
            //    || inderxPhotoInspektion == 23 || inderxPhotoInspektion == 26 || inderxPhotoInspektion == 27 || inderxPhotoInspektion == 33 || inderxPhotoInspektion == 35)
            //{
            //    DependencyService.Get<IOrientationHandler>().ForcePortrait();
            //}
            //else if (inderxPhotoInspektion == 1 || inderxPhotoInspektion == 4 || inderxPhotoInspektion == 5 || inderxPhotoInspektion == 6 || inderxPhotoInspektion == 21
            //    || inderxPhotoInspektion == 24 || inderxPhotoInspektion == 25 || inderxPhotoInspektion == 25 || inderxPhotoInspektion == 28 || inderxPhotoInspektion == 29
            //    || inderxPhotoInspektion == 30 || inderxPhotoInspektion == 31 || inderxPhotoInspektion == 32 || inderxPhotoInspektion == 34 || inderxPhotoInspektion == 36)
            //{
            //    DependencyService.Get<IOrientationHandler>().ForceLandscape();
            //}
        }

        public int GetIndexCar(int countPhoto)
        {
            int indecCar = 0;
            switch (countPhoto)
            {
                case 1:
                    {
                        indecCar = 27;
                        break;
                    }
                case 2:
                    {
                        indecCar = 1;
                        break;
                    }
                case 3:
                    {
                        indecCar = 4;
                        break;
                    }
                case 4:
                    {
                        indecCar = 2;
                        break;
                    }
                case 5:
                    {
                        indecCar = 3;
                        break;
                    }
                case 6:
                    {
                        indecCar = 28;
                        break;
                    }
                default:
                    {
                        indecCar = 26;
                        break;
                    }

            }
            return indecCar;
        }

        public int GetIndexCarFullPhoto(int countPhoto)
        {
            int indecCar = 0;
            switch (countPhoto)
            {
                case 1:
                    {
                        indecCar = 5;
                        break;
                    }
                case 2:
                    {
                        indecCar = 23;
                        break;
                    }
                case 3:
                    {
                        indecCar = 6;
                        break;
                    }
                case 4:
                    {
                        indecCar = 28;
                        break;
                    }
                case 5:
                    {
                        indecCar = 12;
                        break;
                    }
                case 6:
                    {
                        indecCar = 13;
                        break;
                    }
                case 7:
                    {
                        indecCar = 14;
                        break;
                    }
                case 8:
                    {
                        indecCar = 33;
                        break;
                    }
                case 9:
                    {
                        indecCar = 20;
                        break;
                    }
                case 10:
                    {
                        indecCar = 21;
                        break;
                    }
                case 11:
                    {
                        indecCar = 22;
                        break;
                    }
                default:
                    {
                        indecCar = 0;
                        break;
                    }

            }
            return indecCar;
        }
    }
}