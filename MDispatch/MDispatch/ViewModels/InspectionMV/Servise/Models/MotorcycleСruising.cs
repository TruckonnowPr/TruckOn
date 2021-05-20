using MDispatch.Models.Enum;
using MDispatch.NewElement;
using Plugin.Settings;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MDispatch.ViewModels.InspectionMV.Servise.Models
{
    public class MotorcycleСruising : IVehicle
    {
        public string TypeIndex { get; set; } = "Cruisemotorcycle";
        public int CountCarImg { get; set; } = 11;
        public string TypeVehicle { get; set; } = "motorcycle";

        public int GetIndexCar(int countPhoto)
        {
            int indecCar = 0;
            switch (countPhoto)
            {
                case 1:
                    {
                        indecCar = 12;
                        break;
                    }
                case 2:
                    {
                        indecCar = 5;
                        break;
                    }
                case 3:
                    {
                        indecCar = 13;
                        break;
                    }
                case 4:
                    {
                        indecCar = 14;
                        break;
                    }
                case 5:
                    {
                        indecCar = 9;
                        break;
                    }
                case 6:
                    {
                        indecCar = 15;
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

        public string GetNameLayout(int inderxPhotoInspektion)
        {
            string nameLayout = "";
            if (CrossSettings.Current.GetValueOrDefault("Language", (int)LanguageType.English) == (int)LanguageType.English)
            {
                nameLayout = GetNameLayoutEnglish(inderxPhotoInspektion);
            }
            else if (CrossSettings.Current.GetValueOrDefault("Language", (int)LanguageType.English) == (int)LanguageType.Russian)
            {
                nameLayout = GetNameLayoutRussian(inderxPhotoInspektion);
            }
            return nameLayout;
        }

        public string GetNameLayoutEnglish(int inderxPhotoInspektion)
        {
            string nameLayout = "";
            switch (inderxPhotoInspektion)
            {
                case 1: nameLayout = "Vehicle(Cruise Motorcycle) Dashboard"; break;
                case 2: nameLayout = "Vehicle(Cruise Motorcycle) Petrol Tank "; break;
                case 3: nameLayout = "All Right Side of the Vehicle(Cruise Motorcycle)"; break;
                case 4: nameLayout = "Front wheel on the right of the vehicle(Cruise motorcycle)"; break;
                case 5: nameLayout = "Central Right of the Vehicle(Cruise Motorcycle)"; break;
                case 6: nameLayout = "Rear Wheel of Vehicle(Cruise Motorcycle) Right "; break;
                case 7: nameLayout = "Vehicle(Cruise motorcycle) at the rear"; break;
                case 8: nameLayout = "Rear Wheel of Vehicle(Cruise Motorcycle) Left"; break;
                case 9: nameLayout = "Central Left of the Vehicle(Cruise Motorcycle)"; break;
                case 10: nameLayout = "Front wheel on the left of the vehicle (Cruise motorcycle)"; break;
                case 11: nameLayout = "All Left Side of the Vehicle(Cruise Motorcycle)"; break;
                case 12: nameLayout = "Rear belt mount vehicle on the driver's side"; break;
                case 13: nameLayout = "Front belt mount vehicle on the driver's side"; break;
                case 14: nameLayout = "Front belt mount vehicle on the passenger side"; break;
                case 15: nameLayout = "Rear belt mount vehicle on the passenger side"; break;
            }
            return nameLayout;
        }

        public string GetNameLayoutRussian(int inderxPhotoInspektion)
        {
            string nameLayout = "";
            switch (inderxPhotoInspektion)
            {
                case 1: nameLayout = "Приборная панель мотоцикла(Круизный мотоцикл)"; break;
                case 2: nameLayout = "Бензобак"; break;
                case 3: nameLayout = "Вся правая сторона мотоцикла(Круизный мотоцикл)"; break;
                case 4: nameLayout = "Переднее колесо справа от мотоцикла(Круизный мотоцикл)"; break;
                case 5: nameLayout = "Центральная правая сторона мотоцикла(Круизный мотоцикл)"; break;
                case 6: nameLayout = "Заднее колесо мотоцикла(Круизный мотоцикл) справа"; break;
                case 7: nameLayout = "Мотоцикла(Круизный мотоцикл) сзади"; break;
                case 8: nameLayout = "Заднее колесо мотоцикла(Круизный мотоцикл) слева"; break;
                case 9: nameLayout = "Центральная левая сторона мотоцикла(Круизный мотоцикл)"; break;
                case 10: nameLayout = "Переднее колесо мотоцикла(Круизный мотоцикл) слева"; break;
                case 11: nameLayout = "Вся левая сторона мотоцикла(Круизный мотоцикл)"; break;
                case 24: nameLayout = "Задний ремень крепления мотоцикла на стороне водителя"; break;
                case 25: nameLayout = "Передний ремень крепления мотоцикла на стороне водителя"; break;
                case 26: nameLayout = "Передниый ремень крепления мотоцикла на стороне пасажира"; break;
                case 27: nameLayout = "Задний ремень крепления мотоцикла на стороне пасажира"; break;
            }
            return nameLayout;
        }

        public async Task OrintableScreen(int inderxPhotoInspektion)
        {
            DependencyService.Get<IOrientationHandler>().ForceLandscape();
        }
    }
}