using MDispatch.Models.Enum;
using MDispatch.NewElement;
using Plugin.Settings;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MDispatch.ViewModels.InspectionMV.Servise.Models
{
    public class MotorcycleSport : IVehicle
    {
        public string TypeIndex { get; set; } = "Sportbike";
        public int CountCarImg { get; set; } = 19;
        public string TypeVehicle { get; set; } = "motorcycle";

        public int GetIndexCar(int countPhoto)
        {
            int indecCar = 0;
            switch (countPhoto)
            {
                case 1:
                    {
                        indecCar = 20;
                        break;
                    }
                case 2:
                    {
                        indecCar = 3;
                        break;
                    }
                case 3:
                    {
                        indecCar = 4;
                        break;
                    }
                case 4:
                    {
                        indecCar = 21;
                        break;
                    }
                case 5:
                    {
                        indecCar = 7;
                        break;
                    }
                case 6:
                    {
                        indecCar = 6;
                        break;
                    }
                case 7:
                    {
                        indecCar = 8;
                        break;
                    }
                case 8:
                    {
                        indecCar = 22;
                        break;
                    }
                case 9:
                    {
                        indecCar = 12;
                        break;
                    }
                case 10:
                    {
                        indecCar = 13;
                        break;
                    }
                case 11:
                    {
                        indecCar = 23;
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
            else if (CrossSettings.Current.GetValueOrDefault("Language", (int)LanguageType.English) == (int)LanguageType.Spanish)
            {
                nameLayout = GetNameLayoutSpanish(inderxPhotoInspektion);
            }
            return nameLayout;
        }

        public string GetNameLayoutEnglish(int inderxPhotoInspektion)
        {
            string nameLayout = "";
            if (inderxPhotoInspektion == 1)
            {
                nameLayout = "Dashboard sportbike";
            }
            else if (inderxPhotoInspektion == 2)
            {
                nameLayout = "Dashboard and sportbike windshield";
            }
            else if (inderxPhotoInspektion == 3)
            {
                nameLayout = "Front of the sport bike on the right";
            }
            else if (inderxPhotoInspektion == 4)
            {
                nameLayout = "Rear view mirror sport bike on the right";
            }
            else if (inderxPhotoInspektion == 5)
            {
                nameLayout = "Front wheel of a sport bike on the right";
            }
            else if (inderxPhotoInspektion == 6)
            {
                nameLayout = "Sport bike headlights";
            }
            else if (inderxPhotoInspektion == 7)
            {
                nameLayout = "Sportbike windshield";
            }
            else if (inderxPhotoInspektion == 8)
            {
                nameLayout = "Front sport bike";
            }
            else if (inderxPhotoInspektion == 9)
            {
                nameLayout = "Right front headlight sport bike";
            }
            else if (inderxPhotoInspektion == 10)
            {
                nameLayout = "Left front headlight sport bike";
            }
            else if (inderxPhotoInspektion == 11)
            {
                nameLayout = "Front wheel of a sport bike on the left";
            }
            else if (inderxPhotoInspektion == 12)
            {
                nameLayout = "Front of the sport bike on the left";
            }
            else if (inderxPhotoInspektion == 13)
            {
                nameLayout = "Rear view mirror sport bike on the left";
            }
            else if (inderxPhotoInspektion == 14)
            {
                nameLayout = "Whole side sports bike on the left";
            }
            else if (inderxPhotoInspektion == 15)
            {
                nameLayout = "----------";
            }
            else if (inderxPhotoInspektion == 16)
            {
                nameLayout = "The back of the sports bike on the left";
            }
            else if (inderxPhotoInspektion == 17)
            {
                nameLayout = "Rear wheel sports bike left";
            }
            else if (inderxPhotoInspektion == 18)
            {
                nameLayout = "Rear wheel sports bike right";
            }
            else if (inderxPhotoInspektion == 19)
            {
                nameLayout = "The back of the sports bike on the right";
            }
            else if (inderxPhotoInspektion == 20)
            {
                nameLayout = "Rear belt mount vehicle on the driver's side";
            }
            else if (inderxPhotoInspektion == 21)
            {
                nameLayout = "Front belt mount vehicle on the driver's side";
            }
            else if (inderxPhotoInspektion == 22)
            {
                nameLayout = "Front belt mount vehicle on the passenger side";
            }
            else if (inderxPhotoInspektion == 23)
            {
                nameLayout = "Rear belt mount vehicle on the passenger side";
            }
            return nameLayout;
        }

        public string GetNameLayoutRussian(int inderxPhotoInspektion)
        {
            string nameLayout = "";
            if (inderxPhotoInspektion == 1)
            {
                nameLayout = "Спортбайк приборной панели";
            }
            else if (inderxPhotoInspektion == 2)
            {
                nameLayout = "Панель приборов и лобовое стекло спортбайка";
            }
            else if (inderxPhotoInspektion == 3)
            {
                nameLayout = "Передняя часть спортбайка справа";
            }
            else if (inderxPhotoInspektion == 4)
            {
                nameLayout = "Зеркало заднего вида спортбайк справа";
            }
            else if (inderxPhotoInspektion == 5)
            {
                nameLayout = "Переднее колесо спортбайка справа";
            }
            else if (inderxPhotoInspektion == 6)
            {
                nameLayout = "Фары спортивных мотоцикла";
            }
            else if (inderxPhotoInspektion == 7)
            {
                nameLayout = "Лобовое стекло спортбайка";
            }
            else if (inderxPhotoInspektion == 8)
            {
                nameLayout = "Спортивный мотоцикл с переди";
            }
            else if (inderxPhotoInspektion == 9)
            {
                nameLayout = "Передняя правая фара спортбайка";
            }
            else if (inderxPhotoInspektion == 10)
            {
                nameLayout = "Передняя левая фара спортбайка";
            }
            else if (inderxPhotoInspektion == 11)
            {
                nameLayout = "Переднее колесо спортбайка слева";
            }
            else if (inderxPhotoInspektion == 12)
            {
                nameLayout = "Передняя часть спортбайка слева";
            }
            else if (inderxPhotoInspektion == 13)
            {
                nameLayout = "Зеркало заднего вида спортбайк слева";
            }
            else if (inderxPhotoInspektion == 14)
            {
                nameLayout = "Вся левая сторона спортбайка";
            }
            else if (inderxPhotoInspektion == 15)
            {
                nameLayout = "----------";
            }
            else if (inderxPhotoInspektion == 16)
            {
                nameLayout = "Задняя часть спортбайка слева";
            }
            else if (inderxPhotoInspektion == 17)
            {
                nameLayout = "Колесо спортбайка слева";
            }
            else if (inderxPhotoInspektion == 18)
            {
                nameLayout = "Колесо спортбайка справа";
            }
            else if (inderxPhotoInspektion == 19)
            {
                nameLayout = "Задняя часть спортбайка справа";
            }
            else if (inderxPhotoInspektion == 20)
            {
                nameLayout = "Задний ремень крепления мотоцикла на стороне водителя";
            }
            else if (inderxPhotoInspektion == 21)
            {
                nameLayout = "Передний ремень крепления мотоцикла на стороне водителя";
            }
            else if (inderxPhotoInspektion == 22)
            {
                nameLayout = "Передниый ремень крепления мотоцикла на стороне пасажира";
            }
            else if (inderxPhotoInspektion == 23)
            {
                nameLayout = "Задний ремень крепления мотоцикла на стороне пасажира";
            }
            return nameLayout;
        }

        public string GetNameLayoutSpanish(int inderxPhotoInspektion)
        {
            string nameLayout = "";
            if (inderxPhotoInspektion == 1)
            {
                nameLayout = "Bicicleta deportiva para salpicadero";
            }
            else if (inderxPhotoInspektion == 2)
            {
                nameLayout = "Salpicadero y parabrisas de una moto deportiva.";
            }
            else if (inderxPhotoInspektion == 3)
            {
                nameLayout = "La parte delantera de la moto deportiva, a la derecha";
            }
            else if (inderxPhotoInspektion == 4)
            {
                nameLayout = "Bicicleta deportiva con espejo retrovisor a la derecha";
            }
            else if (inderxPhotoInspektion == 5)
            {
                nameLayout = "Rueda delantera de una moto deportiva a la derecha";
            }
            else if (inderxPhotoInspektion == 6)
            {
                nameLayout = "Rueda delantera de una moto deportiva a la derecha";
            }
            else if (inderxPhotoInspektion == 7)
            {
                nameLayout = "Parabrisas de moto deportiva";
            }
            else if (inderxPhotoInspektion == 8)
            {
                nameLayout = "Bicicleta deportiva desde el frente";
            }
            else if (inderxPhotoInspektion == 9)
            {
                nameLayout = "Moto deportiva con faro delantero derecho";
            }
            else if (inderxPhotoInspektion == 10)
            {
                nameLayout = "Moto deportiva con faro delantero izquierdo";
            }
            else if (inderxPhotoInspektion == 11)
            {
                nameLayout = "Rueda delantera de la moto deportiva a la izquierda";
            }
            else if (inderxPhotoInspektion == 12)
            {
                nameLayout = "La parte delantera de la moto deportiva a la izquierda.";
            }
            else if (inderxPhotoInspektion == 13)
            {
                nameLayout = "Espejo retrovisor moto deportiva izquierda";
            }
            else if (inderxPhotoInspektion == 14)
            {
                nameLayout = "Todo el lado izquierdo de la moto deportiva.";
            }
            else if (inderxPhotoInspektion == 15)
            {
                nameLayout = "----------";
            }
            else if (inderxPhotoInspektion == 16)
            {
                nameLayout = "La parte trasera de la moto deportiva a la izquierda";
            }
            else if (inderxPhotoInspektion == 17)
            {
                nameLayout = "Rueda de moto deportiva a la izquierda";
            }
            else if (inderxPhotoInspektion == 18)
            {
                nameLayout = "Rueda de moto deportiva a la derecha";
            }
            else if (inderxPhotoInspektion == 19)
            {
                nameLayout = "La parte trasera de la moto deportiva, a la derecha";
            }
            else if (inderxPhotoInspektion == 20)
            {
                nameLayout = "Correa trasera de motocicleta en el lado del conductor";
            }
            else if (inderxPhotoInspektion == 21)
            {
                nameLayout = "Correa de sujeción delantera de la motocicleta en el lado del conductor.";
            }
            else if (inderxPhotoInspektion == 22)
            {
                nameLayout = "Correa de motocicleta delantera en el lado del pasajero";
            }
            else if (inderxPhotoInspektion == 23)
            {
                nameLayout = "Correa trasera de motocicleta en el lado del pasajero";
            }
            return nameLayout;
        }

        public async Task OrintableScreen(int inderxPhotoInspektion)
        {
            DependencyService.Get<IOrientationHandler>().ForceLandscape();
        }
    }
}