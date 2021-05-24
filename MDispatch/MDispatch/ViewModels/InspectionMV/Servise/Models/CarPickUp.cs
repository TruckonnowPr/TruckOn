using MDispatch.Models.Enum;
using MDispatch.NewElement;
using Plugin.Settings;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MDispatch.ViewModels.InspectionMV.Servise.Models
{
    public class CarPickUp : IVehicle
    {
        public string TypeIndex { get; set; } = "Pick Up";
        public int CountCarImg { get; set; } = 35;
        public string TypeVehicle { get; set; } = "car";

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
                nameLayout = "Pickup dashboard";
            }
            else if (inderxPhotoInspektion == 2)
            {
                nameLayout = "Pickup Salon";
            }
            else if (inderxPhotoInspektion == 3)
            {
                nameLayout = "Driver seat";
            }
            else if (inderxPhotoInspektion == 4)
            {
                nameLayout = "Driver seat";
            }
            else if (inderxPhotoInspektion == 5)
            {
                nameLayout = "Front driver door";
            }
            else if (inderxPhotoInspektion == 6)
            {
                nameLayout = "Front of the pickUp, driver's side";
            }
            else if (inderxPhotoInspektion == 7)
            {
                nameLayout = "Rear-view mirror of a pickup driver's side";
            }
            else if (inderxPhotoInspektion == 8)
            {
                nameLayout = "Rear-view mirror of a pickup driver's side";
            }
            else if (inderxPhotoInspektion == 9)
            {
                nameLayout = "Front of the pickUp, driver's side";
            }
            else if (inderxPhotoInspektion == 10)
            {
                nameLayout = "The front wheel of a pickup driver's side";
            }
            else if (inderxPhotoInspektion == 11)
            {
                nameLayout = "The right side of the front bumper of the pickup";
            }
            else if (inderxPhotoInspektion == 12)
            {
                nameLayout = "Right front headlight of a pickup bumper";
            }
            else if (inderxPhotoInspektion == 13)
            {
                nameLayout = "The center side of the front bumper of the pickup";
            }
            else if (inderxPhotoInspektion == 14)
            {
                nameLayout = "The left side of the front bumper of the pickup";
            }
            else if (inderxPhotoInspektion == 15)
            {
                nameLayout = "Left front headlight of a pickup bumper";
            }
            else if (inderxPhotoInspektion == 16)
            {
                nameLayout = "Hood of a pickup";
            }
            else if (inderxPhotoInspektion == 17)
            {
                nameLayout = "Windshield pickup";
            }
            else if (inderxPhotoInspektion == 18)
            {
                nameLayout = "Pickup roof";
            }
            else if (inderxPhotoInspektion == 19)
            {
                nameLayout = "Front of the Pickup on the passenger side";
            }
            else if (inderxPhotoInspektion == 20)
            {
                nameLayout = "The front wheel of a pickup passenger side";
            }
            else if (inderxPhotoInspektion == 21)
            {
                nameLayout = "Front of the Pickup on the passenger side";
            }
            else if (inderxPhotoInspektion == 22)
            {
                nameLayout = "Rear-view mirror of a pickup passenger side";
            }
            else if (inderxPhotoInspektion == 23)
            {
                nameLayout = "Rear-view mirror of a pickup passenger side";
            }
            else if (inderxPhotoInspektion == 24)
            {
                nameLayout = "Front passenger door";
            }
            else if (inderxPhotoInspektion == 25)
            {
                nameLayout = "Rear passenger door";
            }
            else if (inderxPhotoInspektion == 26)
            {
                nameLayout = "Rear of the Pickup on the passenger side";
            }
            else if (inderxPhotoInspektion == 27)
            {
                nameLayout = "The rear wheel of a pickup passenger side";
            }
            else if (inderxPhotoInspektion == 28)
            {
                nameLayout = "Rear of the Pickup on the passenger side";
            }
            else if (inderxPhotoInspektion == 29)
            {
                nameLayout = "The right side of the rear bumper";
            }
            else if (inderxPhotoInspektion == 30)
            {
                nameLayout = "The centr side of the rear bumper";
            }
            else if (inderxPhotoInspektion == 31)
            {
                nameLayout = "The left side of the rear bumper";
            }
            else if (inderxPhotoInspektion == 32)
            {
                nameLayout = "Rear of the Pickup on the driver's side";
            }
            else if (inderxPhotoInspektion == 33)
            {
                nameLayout = "The rear wheel of a pickup driver's side";
            }
            else if (inderxPhotoInspektion == 34)
            {
                nameLayout = "Rear of the Pickup on the driver's side";
            }
            else if (inderxPhotoInspektion == 35)
            {
                nameLayout = "Rear driver's door";
            }
            else if (inderxPhotoInspektion == 36)
            {
                nameLayout = "Rear belt mount vehicle on the driver's side";
            }
            else if (inderxPhotoInspektion == 37)
            {
                nameLayout = "Front belt mount vehicle on the driver's side";
            }
            else if (inderxPhotoInspektion == 38)
            {
                nameLayout = "Front belt mount vehicle on the passenger side";
            }
            else if (inderxPhotoInspektion == 39)
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
                nameLayout = "Приборная панель пикапа";
            }
            else if (inderxPhotoInspektion == 2)
            {
                nameLayout = "Салон пикапа";
            }
            else if (inderxPhotoInspektion == 3)
            {
                nameLayout = "Сиденье водителя";
            }
            else if (inderxPhotoInspektion == 4)
            {
                nameLayout = "Сиденье водителя";
            }
            else if (inderxPhotoInspektion == 5)
            {
                nameLayout = "Передняя дверь водителя";
            }
            else if (inderxPhotoInspektion == 6)
            {
                nameLayout = "Передняя часть пикапа со стороны водителя";
            }
            else if (inderxPhotoInspektion == 7)
            {
                nameLayout = "Зеркало заднего вида со стороны водителя пикапа";
            }
            else if (inderxPhotoInspektion == 8)
            {
                nameLayout = "Зеркало заднего вида со стороны водителя пикапа";
            }
            else if (inderxPhotoInspektion == 9)
            {
                nameLayout = "Передняя часть пикапа со стороны водителяe";
            }
            else if (inderxPhotoInspektion == 10)
            {
                nameLayout = "Переднее колесо пикапа со стороны водителя";
            }
            else if (inderxPhotoInspektion == 11)
            {
                nameLayout = "Правая сторона переднего бампера пикапа";
            }
            else if (inderxPhotoInspektion == 12)
            {
                nameLayout = "Правая передняя фара пикап-бампера";
            }
            else if (inderxPhotoInspektion == 13)
            {
                nameLayout = "Центральная сторона переднего бампера пикапа";
            }
            else if (inderxPhotoInspektion == 14)
            {
                nameLayout = "Левая часть переднего бампера пикапа";
            }
            else if (inderxPhotoInspektion == 15)
            {
                nameLayout = "Левая передняя фара пикап-бампера";
            }
            else if (inderxPhotoInspektion == 16)
            {
                nameLayout = "Капот пикапа";
            }
            else if (inderxPhotoInspektion == 17)
            {
                nameLayout = "Подборщик лобового стекла";
            }
            else if (inderxPhotoInspektion == 18)
            {
                nameLayout = "Пикап крыша";
            }
            else if (inderxPhotoInspektion == 19)
            {
                nameLayout = "Передняя часть пикапа со стороны пассажира";
            }
            else if (inderxPhotoInspektion == 20)
            {
                nameLayout = "Переднее колесо пикапа со стороны пассажира";
            }
            else if (inderxPhotoInspektion == 21)
            {
                nameLayout = "Передняя часть пикапа со стороны пассажира";
            }
            else if (inderxPhotoInspektion == 22)
            {
                nameLayout = "Зеркало заднего вида со стороны пассажира пикапа";
            }
            else if (inderxPhotoInspektion == 23)
            {
                nameLayout = "Зеркало заднего вида со стороны пассажира пикапа";
            }
            else if (inderxPhotoInspektion == 24)
            {
                nameLayout = "Дверь переднего пассажира";
            }
            else if (inderxPhotoInspektion == 25)
            {
                nameLayout = "Дверь заднего пассажира";
            }
            else if (inderxPhotoInspektion == 26)
            {
                nameLayout = "Задняя часть пикапа со стороны пассажира";
            }
            else if (inderxPhotoInspektion == 27)
            {
                nameLayout = "Заднее колесо пикапа со стороны пассажира";
            }
            else if (inderxPhotoInspektion == 28)
            {
                nameLayout = "Задняя часть пикапа со стороны пассажира";
            }
            else if (inderxPhotoInspektion == 29)
            {
                nameLayout = "Правая сторона заднего бампера";
            }
            else if (inderxPhotoInspektion == 30)
            {
                nameLayout = "Центральная сторона заднего бампера";
            }
            else if (inderxPhotoInspektion == 31)
            {
                nameLayout = "Левая часть заднего бампера";
            }
            else if (inderxPhotoInspektion == 32)
            {
                nameLayout = "Задняя часть пикапа со стороны водителя";
            }
            else if (inderxPhotoInspektion == 33)
            {
                nameLayout = "Заднее колесо пикапа со стороны водителя";
            }
            else if (inderxPhotoInspektion == 34)
            {
                nameLayout = "Задняя часть пикапа со стороны водителя";
            }
            else if (inderxPhotoInspektion == 35)
            {
                nameLayout = "Задняя дверь водителя";
            }
            else if (inderxPhotoInspektion == 36)
            {
                nameLayout = "Задний ремень крепления автомобиля на стороне водителя";
            }
            else if (inderxPhotoInspektion == 37)
            {
                nameLayout = "Передний ремень крепления автомобиля на стороне водителя";
            }
            else if (inderxPhotoInspektion == 38)
            {
                nameLayout = "Автомобиль с передним ремнем безопасности на стороне пассажира";
            }
            else if (inderxPhotoInspektion == 39)
            {
                nameLayout = "Автомобиль с креплением на ремне сзади на стороне пассажира";
            }
            return nameLayout;
        }

        public string GetNameLayoutSpanish(int inderxPhotoInspektion)
        {
            string nameLayout = "";
            if (inderxPhotoInspektion == 1)
            {
                nameLayout = "Tablero de mandos pickup";
            }
            else if (inderxPhotoInspektion == 2)
            {
                nameLayout = "Salón pickup";
            }
            else if (inderxPhotoInspektion == 3)
            {
                nameLayout = "Asiento";
            }
            else if (inderxPhotoInspektion == 4)
            {
                nameLayout = "Asiento";
            }
            else if (inderxPhotoInspektion == 5)
            {
                nameLayout = "Puerta de entrada del conductor";
            }
            else if (inderxPhotoInspektion == 6)
            {
                nameLayout = "El frente de pickup desde el lado del conductor";
            }
            else if (inderxPhotoInspektion == 7)
            {
                nameLayout = "Espejo retrovisor, lado del conductor pickup";
            }
            else if (inderxPhotoInspektion == 8)
            {
                nameLayout = "Espejo retrovisor, lado del conductor pickup";
            }
            else if (inderxPhotoInspektion == 9)
            {
                nameLayout = "El frente de pickup desde el lado del conductor";
            }
            else if (inderxPhotoInspektion == 10)
            {
                nameLayout = "Rueda delantera pickup desde el lado del conductor";
            }
            else if (inderxPhotoInspektion == 11)
            {
                nameLayout = "Parachoques delantero lado derecho pickup";
            }
            else if (inderxPhotoInspektion == 12)
            {
                nameLayout = "Faro derecho pickup";
            }
            else if (inderxPhotoInspektion == 13)
            {
                nameLayout = "Lado central del parachoques delantero pickup";
            }
            else if (inderxPhotoInspektion == 14)
            {
                nameLayout = "Lado izquierdo del parachoques delantero pickup";
            }
            else if (inderxPhotoInspektion == 15)
            {
                nameLayout = "Faro delantero izquierdo pickup";
            }
            else if (inderxPhotoInspektion == 16)
            {
                nameLayout = "Capucha pickup";
            }
            else if (inderxPhotoInspektion == 17)
            {
                nameLayout = "Selección de parabrisas";
            }
            else if (inderxPhotoInspektion == 18)
            {
                nameLayout = "Techo pickup";
            }
            else if (inderxPhotoInspektion == 19)
            {
                nameLayout = "El frente de pickup desde el lado del pasajero";
            }
            else if (inderxPhotoInspektion == 20)
            {
                nameLayout = "Rueda delantera pickup desde el lado del pasajero";
            }
            else if (inderxPhotoInspektion == 21)
            {
                nameLayout = "El frente de pickup desde el lado del pasajero";
            }
            else if (inderxPhotoInspektion == 22)
            {
                nameLayout = "Espejo retrovisor, lado del pasajero pickup";
            }
            else if (inderxPhotoInspektion == 23)
            {
                nameLayout = "Espejo retrovisor, lado del pasajero pickup";
            }
            else if (inderxPhotoInspektion == 24)
            {
                nameLayout = "Puerta del acompañante";
            }
            else if (inderxPhotoInspektion == 25)
            {
                nameLayout = "Puerta del pasajero trasero";
            }
            else if (inderxPhotoInspektion == 26)
            {
                nameLayout = "Parte trasera pickup desde el lado del pasajero";
            }
            else if (inderxPhotoInspektion == 27)
            {
                nameLayout = "Заднее колесо pickup desde el lado del pasajero";
            }
            else if (inderxPhotoInspektion == 28)
            {
                nameLayout = "Parte trasera pickup desde el lado del pasajero";
            }
            else if (inderxPhotoInspektion == 29)
            {
                nameLayout = "Lado derecho del parachoques trasero";
            }
            else if (inderxPhotoInspektion == 30)
            {
                nameLayout = "Lado central del parachoques trasero";
            }
            else if (inderxPhotoInspektion == 31)
            {
                nameLayout = "Lado izquierdo del parachoques trasero";
            }
            else if (inderxPhotoInspektion == 32)
            {
                nameLayout = "Parte trasera pickup desde el lado del conductor";
            }
            else if (inderxPhotoInspektion == 33)
            {
                nameLayout = "Заднее колесо pickup desde el lado del conductor";
            }
            else if (inderxPhotoInspektion == 34)
            {
                nameLayout = "Parte trasera pickup desde el lado del conductor";
            }
            else if (inderxPhotoInspektion == 35)
            {
                nameLayout = "Puerta trasera del conductor";
            }
            else if (inderxPhotoInspektion == 36)
            {
                nameLayout = "Cinturón de seguridad trasero para automóvil, lado del conductor";
            }
            else if (inderxPhotoInspektion == 37)
            {
                nameLayout = "Correa de sujeción delantera del coche en el lado del conductor.";
            }
            else if (inderxPhotoInspektion == 38)
            {
                nameLayout = "Coche con cinturón de seguridad delantero en el lado del pasajero";
            }
            else if (inderxPhotoInspektion == 39)
            {
                nameLayout = "Vehículo con clip para cinturón en la parte trasera del lado del pasajero";
            }
            return nameLayout;
        }

        public async Task OrintableScreen(int inderxPhotoInspektion)
        {
            DependencyService.Get<IOrientationHandler>().ForceLandscape();
            //if (inderxPhotoInspektion == 2 || inderxPhotoInspektion == 3 || inderxPhotoInspektion == 6 || inderxPhotoInspektion == 7 || inderxPhotoInspektion == 8 || inderxPhotoInspektion == 11 || inderxPhotoInspektion == 12 || inderxPhotoInspektion == 13 || inderxPhotoInspektion == 16
            //    || inderxPhotoInspektion == 17 || inderxPhotoInspektion == 18 || inderxPhotoInspektion == 20 || inderxPhotoInspektion == 21 || inderxPhotoInspektion == 22 || inderxPhotoInspektion == 23 || inderxPhotoInspektion == 24 || inderxPhotoInspektion == 28
            //    || inderxPhotoInspektion == 29 || inderxPhotoInspektion == 30 || inderxPhotoInspektion == 31 || inderxPhotoInspektion == 34 || inderxPhotoInspektion == 35)
            //{
            //    DependencyService.Get<IOrientationHandler>().ForcePortrait();
            //}
            //else if (inderxPhotoInspektion == 1 || inderxPhotoInspektion == 4 || inderxPhotoInspektion == 5 || inderxPhotoInspektion == 6 || inderxPhotoInspektion == 9 || inderxPhotoInspektion == 10 || inderxPhotoInspektion == 14 || inderxPhotoInspektion == 15
            //    || inderxPhotoInspektion == 19 || inderxPhotoInspektion == 25 || inderxPhotoInspektion == 26 || inderxPhotoInspektion == 27 || inderxPhotoInspektion == 32 || inderxPhotoInspektion == 33)
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
                        indecCar = 36;
                        break;
                    }
                case 2:
                    {
                        indecCar = 5;
                        break;
                    }
                case 3:
                    {
                        indecCar = 7;
                        break;
                    }
                case 4:
                    {
                        indecCar = 37;
                        break;
                    }
                case 5:
                    {
                        indecCar = 17;
                        break;
                    }
                case 6:
                    {
                        indecCar = 11;
                        break;
                    }
                case 7:
                    {
                        indecCar = 13;
                        break;
                    }
                case 8:
                    {
                        indecCar = 14;
                        break;
                    }
                case 9:
                    {
                        indecCar = 38;
                        break;
                    }
                case 10:
                    {
                        indecCar = 24;
                        break;
                    }
                case 11:
                    {
                        indecCar = 22;
                        break;
                    }
                case 12:
                    {
                        indecCar = 39;
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