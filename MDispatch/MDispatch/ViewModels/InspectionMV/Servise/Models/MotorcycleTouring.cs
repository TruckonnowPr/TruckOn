using MDispatch.Models.Enum;
using MDispatch.NewElement;
using Plugin.Settings;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MDispatch.ViewModels.InspectionMV.Servise.Models
{
    public class MotorcycleTouring : IVehicle
    {
        public string TypeIndex { get; set; } = "Touringmotorcycle";
        public int CountCarImg { get; set; } = 14;
        public string TypeVehicle { get; set; } = "motorcycle";

        public int GetIndexCar(int countPhoto)
        {
            int indecCar = 0;
            switch (countPhoto)
            {
                case 1:
                    {
                        indecCar = 15;
                        break;
                    }
                case 2:
                    {
                        indecCar = 4;
                        break;
                    }
                case 3:
                    {
                        indecCar = 16;
                        break;
                    }
                case 4:
                    {
                        indecCar = 7;
                        break;
                    }
                case 5:
                    {
                        indecCar = 8;
                        break;
                    }
                case 6:
                    {
                        indecCar = 17;
                        break;
                    }
                case 7:
                    {
                        indecCar = 11;
                        break;
                    }
                case 8:
                    {
                        indecCar = 18;
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
                case 1: nameLayout = "Vehicle Dashboard (Touring Motorcycle)"; break;
                case 2: nameLayout = "The entire right side of the vehicle (Touring motorcycle)"; break;
                case 3: nameLayout = "Rear right side of the vehicle (Touring motorcycle)"; break;
                case 4: nameLayout = "Central right of the vehicle (Touring motorcycle)"; break;
                case 5: nameLayout = "---------- (Touring motorcycle)"; break;
                case 6: nameLayout = "Front Right Wheel of a Vehicle (Touring Motorcycle)"; break;
                case 7: nameLayout = "Front part from the right corner of the vehicle (Touring motorcycle)"; break;
                case 8: nameLayout = "Front part from the left corner of the vehicle (Touring motorcycle)"; break;
                case 9: nameLayout = "Front Left Wheel of a Vehicle (Touring Motorcycle)"; break;
                case 10: nameLayout = "---------- (Touring Motorcycle)"; break;
                case 11: nameLayout = "Central left of the vehicle (Touring motorcycle)"; break;
                case 12: nameLayout = "Rear left side of the vehicle (Touring motorcycle)"; break;
                case 13: nameLayout = "The entire left side of the vehicle (Touring motorcycle)"; break;
                case 14: nameLayout = "Vehicle (Touring motorcycle) at the rear"; break;
                case 15: nameLayout = "Rear belt mount vehicle on the driver's side"; break;
                case 16: nameLayout = "Front belt mount vehicle on the driver's side"; break;
                case 17: nameLayout = "Front belt mount vehicle on the passenger side"; break;
                case 18: nameLayout = "Rear belt mount vehicle on the passenger side"; break;
            }
            return nameLayout;
        }

        public string GetNameLayoutRussian(int inderxPhotoInspektion)
        {
            string nameLayout = "";
            switch (inderxPhotoInspektion)
            {
                case 1: nameLayout = "Приборная панель мотоцикла(Туристический мотоцикл)"; break;
                case 2: nameLayout = "Вся правая сторона мотоцикла(Туристический мотоцикл)"; break;
                case 3: nameLayout = "Задняя правая сторона мотоцикла(Туристический мотоцикл)"; break;
                case 4: nameLayout = "----------(Туристический мотоцик)"; break;
                case 5: nameLayout = "----------(Туристический мотоцик)"; break;
                case 6: nameLayout = "Переднее правое колесо мотоцикла(Туристический мотоцикл)"; break;
                case 7: nameLayout = "Передняя часть из правого угла мотоцикла(Туристический мотоцикл)"; break;
                case 8: nameLayout = "Передняя часть из левого угла мотоцикла(Туристический мотоцикл)"; break;
                case 9: nameLayout = "Переднее левое колесо мотоцикла(Туристический мотоцикл)"; break;
                case 10: nameLayout = "----------(Туристический мотоцикл)"; break;
                case 11: nameLayout = "Центральная левая часть мотоцикла(Туристический мотоцикл)"; break;
                case 12: nameLayout = "Задняя левая сторона мотоцикла(Туристический мотоцикл)"; break;
                case 13: nameLayout = "Вся левая сторона мотоцикла(Туристический мотоцикл)"; break;
                case 14: nameLayout = "Мотоцикл(Туристический мотоцикл) сзади"; break;
                case 15: nameLayout = "Задний ремень крепления мотоцикла на стороне водителя"; break;
                case 16: nameLayout = "Передний ремень крепления мотоцикла на стороне водителя"; break;
                case 17: nameLayout = "Передниый ремень крепления мотоцикла на стороне пасажира"; break;
                case 18: nameLayout = "Задний ремень крепления мотоцикла на стороне пасажира"; break;
            }
            return nameLayout;
        }

        public async Task OrintableScreen(int inderxPhotoInspektion)
        {
            DependencyService.Get<IOrientationHandler>().ForceLandscape();
        }
    }
}