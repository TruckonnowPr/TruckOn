using MDispatch.Models.Enum;
using MDispatch.NewElement;
using Plugin.Settings;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MDispatch.ViewModels.InspectionMV.Servise.Models
{
    public class CarSuv : IVehicle
    {
        public string TypeIndex { get; set; } = "Suv";
        public int CountCarImg { get; set; } = 36;
        public string TypeVehicle { get; set; } = "car";

        public int GetIndexCar(int countPhoto)
        {
            int indecCar = 0;
            switch (countPhoto)
            {
                case 1:
                    {
                        indecCar = 37;
                        break;
                    }
                case 2:
                    {
                        indecCar = 5;
                        break;
                    }
                case 3:
                    {
                        indecCar = 6;
                        break;
                    }
                case 4:
                    {
                        indecCar = 38;
                        break;
                    }
                case 5:
                    {
                        indecCar = 17;
                        break;
                    }
                case 6:
                    {
                        indecCar = 12;
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
                        indecCar = 39;
                        break;
                    }
                case 10:
                    {
                        indecCar = 22;
                        break;
                    }
                case 11:
                    {
                        indecCar = 23;
                        break;
                    }
                case 12:
                    {
                        indecCar = 40;
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
                nameLayout = "Vehicle(SUV) dashboard";
            }
            else if (inderxPhotoInspektion == 2)
            {
                nameLayout = "Vehicle(SUV) interior";
            }
            else if (inderxPhotoInspektion == 3)
            {
                nameLayout = "Vehicle(SUV) interior";
            }
            else if (inderxPhotoInspektion == 4)
            {
                nameLayout = "Driving door from inside the vehicle(SUV)";
            }
            else if (inderxPhotoInspektion == 5)
            {
                nameLayout = "Front door from inside the vehicle(SUV) on the driver's side";
            }
            else if (inderxPhotoInspektion == 6)
            {
                nameLayout = "Rearview mirror vehicle(SUV) on the driver's side";
            }
            else if (inderxPhotoInspektion == 7)
            {
                nameLayout = "Rearview mirror vehicle(SUV) on the driver's side";
            }
            else if (inderxPhotoInspektion == 8)
            {
                nameLayout = "Front of the vehicle(SUV) on the driver's side";
            }
            else if (inderxPhotoInspektion == 9)
            {
                nameLayout = "Front wheel of the vehicle(SUV) on the driver's side";
            }
            else if (inderxPhotoInspektion == 10)
            {
                nameLayout = "Front of the vehicle(SUV) on the driver's side";
            }
            else if (inderxPhotoInspektion == 11)
            {
                nameLayout = "Right front headlight of the vehicle(SUV)";
            }
            else if (inderxPhotoInspektion == 12)
            {
                nameLayout = "The right side of the front bumper of the vehicle(SUV)";
            }
            else if (inderxPhotoInspektion == 13)
            {
                nameLayout = "The centr side of the front bumper of the vehicle(SUV)";
            }
            else if (inderxPhotoInspektion == 14)
            {
                nameLayout = "The left side of the front bumper of the vehicle(SUV)";
            }
            else if (inderxPhotoInspektion == 15)
            {
                nameLayout = "Left front headlight of the vehicle(SUV)";
            }
            else if (inderxPhotoInspektion == 16)
            {
                nameLayout = "Vehicle(SUV) hood";
            }
            else if (inderxPhotoInspektion == 17)
            {
                nameLayout = "Vehicle(SUV) Windshield";
            }
            else if (inderxPhotoInspektion == 18)
            {
                nameLayout = "The entire front of the vehicle(SUV)";
            }
            else if (inderxPhotoInspektion == 19)
            {
                nameLayout = "Front of the vehicle(SUV) on the passenger side";
            }
            else if (inderxPhotoInspektion == 20)
            {
                nameLayout = "Front of the vehicle(SUV) on the passenger side";
            }
            else if (inderxPhotoInspektion == 21)
            {
                nameLayout = "Front wheel of the vehicle(SUV) on the passenger side";
            }
            else if (inderxPhotoInspektion == 22)
            {
                nameLayout = "Front door from inside the vehicle(SUV) on the passenger side";
            }
            else if (inderxPhotoInspektion == 23)
            {
                nameLayout = "Rearview mirror vehicle(SUV) on the passenger side";
            }
            else if (inderxPhotoInspektion == 24)
            {
                nameLayout = "Rearview mirror vehicle(SUV) on the passenger side";
            }
            else if (inderxPhotoInspektion == 25)
            {
                nameLayout = "Rear door of the vehicle(SUV) on the passenger side";
            }
            else if (inderxPhotoInspektion == 26)
            {
                nameLayout = "Rear of the vehicle(SUV) on the passenger side";
            }
            else if (inderxPhotoInspektion == 27)
            {
                nameLayout = "Rear wheel of the vehicle(SUV) on the passenger side";
            }
            else if (inderxPhotoInspektion == 28)
            {
                nameLayout = "All part of the vehicle(SUV) on the passenger side";
            }
            else if (inderxPhotoInspektion == 29)
            {
                nameLayout = "The right side of the rear bumper of the vehicle(SUV)";
            }
            else if (inderxPhotoInspektion == 30)
            {
                nameLayout = "The center side of the rear bumper of the vehicle(SUV)";
            }
            else if (inderxPhotoInspektion == 31)
            {
                nameLayout = "Vehicle(SUV) Rear Window";
            }
            else if (inderxPhotoInspektion == 32)
            {
                nameLayout = "The left side of the rear bumper of the vehicle(SUV)";
            }
            else if (inderxPhotoInspektion == 33)
            {
                nameLayout = "Rear of the vehicle(SUV) on the driver's side";
            }
            else if (inderxPhotoInspektion == 34)
            {
                nameLayout = "Rear wheel of the vehicle(SUV) on the driver's side";
            }
            else if (inderxPhotoInspektion == 35)
            {
                nameLayout = "Rear door of the vehicle(SUV) on the driver's side";
            }
            else if (inderxPhotoInspektion == 36)
            {
                nameLayout = "All part of the vehicle(SUV) on the driver's side";
            }
            else if (inderxPhotoInspektion == 37)
            {
                nameLayout = "Rear belt mount vehicle on the driver's side";
            }
            else if (inderxPhotoInspektion == 38)
            {
                nameLayout = "Front belt mount vehicle on the driver's side";
            }
            else if (inderxPhotoInspektion == 39)
            {
                nameLayout = "Front belt mount vehicle on the passenger side";
            }
            else if (inderxPhotoInspektion == 40)
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
                nameLayout = "Приборная панель автомобиля(SUV)";
            }
            else if (inderxPhotoInspektion == 2)
            {
                nameLayout = "Салон автомобиля(SUV)";
            }
            else if (inderxPhotoInspektion == 3)
            {
                nameLayout = "Салон автомобиля(SUV)";
            }
            else if (inderxPhotoInspektion == 4)
            {
                nameLayout = "Дверь из салона автомобиля(SUV)";
            }
            else if (inderxPhotoInspektion == 5)
            {
                nameLayout = "Передняя дверь изнутри автомобиля(SUV) со стороны водителя";
            }
            else if (inderxPhotoInspektion == 6)
            {
                nameLayout = "Зеркало заднего вида автомобиля(SUV) на стороне водителя";
            }
            else if (inderxPhotoInspektion == 7)
            {
                nameLayout = "Зеркало заднего вида автомобиля(SUV) на стороне водителя";
            }
            else if (inderxPhotoInspektion == 8)
            {
                nameLayout = "Передняя часть автомобиля(SUV) со стороны водителя";
            }
            else if (inderxPhotoInspektion == 9)
            {
                nameLayout = "Переднее колесо автомобиля(SUV) со стороны водителя";
            }
            else if (inderxPhotoInspektion == 10)
            {
                nameLayout = "Передняя часть автомобиля(SUV) со стороны водителя";
            }
            else if (inderxPhotoInspektion == 11)
            {
                nameLayout = "Правая передняя фара автомобиля(SUV)";
            }
            else if (inderxPhotoInspektion == 12)
            {
                nameLayout = "Правая часть переднего бампера автомобиля(SUV)";
            }
            else if (inderxPhotoInspektion == 13)
            {
                nameLayout = "Центральная сторона переднего бампера автомобиляSUV)";
            }
            else if (inderxPhotoInspektion == 14)
            {
                nameLayout = "Левая сторона переднего бампера автомобиля(SUV)";
            }
            else if (inderxPhotoInspektion == 15)
            {
                nameLayout = "Левая передняя фара автомобиля(SUV)";
            }
            else if (inderxPhotoInspektion == 16)
            {
                nameLayout = "Капот автомобиля(SUV)";
            }
            else if (inderxPhotoInspektion == 17)
            {
                nameLayout = "Лобовое стекло автомобиля(SUV)";
            }
            else if (inderxPhotoInspektion == 18)
            {
                nameLayout = "Вся передняя часть автомобиля(SUV)";
            }
            else if (inderxPhotoInspektion == 19)
            {
                nameLayout = "Передняя часть автомобиля(SUV) со стороны пассажира";
            }
            else if (inderxPhotoInspektion == 20)
            {
                nameLayout = "Передняя часть автомобилем(SUV) со стороны пассажира";
            }
            else if (inderxPhotoInspektion == 21)
            {
                nameLayout = "Переднее колесо автомобиля(SUV) со стороны пассажира";
            }
            else if (inderxPhotoInspektion == 22)
            {
                nameLayout = "Передняя дверь изнутри автомобиля(SUV) со стороны пассажира";
            }
            else if (inderxPhotoInspektion == 23)
            {
                nameLayout = "Зеркало заднего вида автомобиля(SUV) на стороне пассажира";
            }
            else if (inderxPhotoInspektion == 24)
            {
                nameLayout = "Зеркало заднего вида автомобиля(SUV) на стороне пассажира";
            }
            else if (inderxPhotoInspektion == 25)
            {
                nameLayout = "Задняя дверь автомобиля(SUV) со стороны пассажира";
            }
            else if (inderxPhotoInspektion == 26)
            {
                nameLayout = "Задняя часть автомобиля(SUV) со стороны пассажира";
            }
            else if (inderxPhotoInspektion == 27)
            {
                nameLayout = "Заднее колесо автомобиля(SUV) со стороны пассажира";
            }
            else if (inderxPhotoInspektion == 28)
            {
                nameLayout = "Вся часть автомобиля(SUV) на стороне пассажира";
            }
            else if (inderxPhotoInspektion == 29)
            {
                nameLayout = "Правая сторона заднего бампера автомобиля(SUV)";
            }
            else if (inderxPhotoInspektion == 30)
            {
                nameLayout = "Центральная сторона заднего бампера автомобиля(SUV)";
            }
            else if (inderxPhotoInspektion == 31)
            {
                nameLayout = "Заднее стекло автомобиля(SUV)";
            }
            else if (inderxPhotoInspektion == 32)
            {
                nameLayout = "Левая сторона заднего бампера автомобиля(SUV)";
            }
            else if (inderxPhotoInspektion == 33)
            {
                nameLayout = "Задняя часть автомобиля(SUV) со стороны водителя";
            }
            else if (inderxPhotoInspektion == 34)
            {
                nameLayout = "Заднее колесо автомобиля(SUV) со стороны водителя";
            }
            else if (inderxPhotoInspektion == 35)
            {
                nameLayout = "Задняя дверь автомобиля(SUV) со стороны водителя";
            }
            else if (inderxPhotoInspektion == 36)
            {
                nameLayout = "Вся часть автомобиля(SUV) на стороне водителя";
            }
            else if (inderxPhotoInspektion == 37)
            {
                nameLayout = "Задний ремень крепления автомобиля на стороне водителя";
            }
            else if (inderxPhotoInspektion == 38)
            {
                nameLayout = "Передний ремень крепления автомобиля на стороне водителя";
            }
            else if (inderxPhotoInspektion == 39)
            {
                nameLayout = "Автомобиль с передним ремнем безопасности на стороне пассажира";
            }
            else if (inderxPhotoInspektion == 40)
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
                nameLayout = "Salpicadero del coche(SUV)";
            }
            else if (inderxPhotoInspektion == 2)
            {
                nameLayout = "Interior del vehículo(SUV)";
            }
            else if (inderxPhotoInspektion == 3)
            {
                nameLayout = "Interior del vehículo(SUV)";
            }
            else if (inderxPhotoInspektion == 4)
            {
                nameLayout = "Puerta del auto(SUV)";
            }
            else if (inderxPhotoInspektion == 5)
            {
                nameLayout = "Puerta de entrada desde el interior del coche(SUV) desde el lado del conductor";
            }
            else if (inderxPhotoInspektion == 6)
            {
                nameLayout = "Espejo retrovisor del coche(SUV) en el lado del conductor";
            }
            else if (inderxPhotoInspektion == 7)
            {
                nameLayout = "Espejo retrovisor del coche(SUV) en el lado del conductor";
            }
            else if (inderxPhotoInspektion == 8)
            {
                nameLayout = "Delante del coche(SUV) desde el lado del conductor";
            }
            else if (inderxPhotoInspektion == 9)
            {
                nameLayout = "Rueda delantera del coche(SUV) desde el lado del conductor";
            }
            else if (inderxPhotoInspektion == 10)
            {
                nameLayout = "Delante del coche(SUV) desde el lado del conductor";
            }
            else if (inderxPhotoInspektion == 11)
            {
                nameLayout = "Faro delantero derecho del coche(SUV)";
            }
            else if (inderxPhotoInspektion == 12)
            {
                nameLayout = "El lado derecho del parachoques delantero del automóvil(SUV)";
            }
            else if (inderxPhotoInspektion == 13)
            {
                nameLayout = "El lado central del parachoques delantero del automóvil(SUV)";
            }
            else if (inderxPhotoInspektion == 14)
            {
                nameLayout = "Lado izquierdo del parachoques delantero del coche(SUV)";
            }
            else if (inderxPhotoInspektion == 15)
            {
                nameLayout = "Faro delantero izquierdo del coche(SUV)";
            }
            else if (inderxPhotoInspektion == 16)
            {
                nameLayout = "Tapa del motor del carro(SUV)";
            }
            else if (inderxPhotoInspektion == 17)
            {
                nameLayout = "Parabrisas de coche(SUV)";
            }
            else if (inderxPhotoInspektion == 18)
            {
                nameLayout = "Todo el frente del auto(SUV)";
            }
            else if (inderxPhotoInspektion == 19)
            {
                nameLayout = "Delante del coche(SUV) desde el lado del pasajero";
            }
            else if (inderxPhotoInspektion == 20)
            {
                nameLayout = "Frente del vehiculo(SUV) en el lado del pasajero";
            }
            else if (inderxPhotoInspektion == 21)
            {
                nameLayout = "Rueda delantera del coche(SUV) desde el lado del pasajero";
            }
            else if (inderxPhotoInspektion == 22)
            {
                nameLayout = "Puerta de entrada desde el interior del coche(SUV) desde el lado del pasajero";
            }
            else if (inderxPhotoInspektion == 23)
            {
                nameLayout = "Espejo retrovisor del coche(SUV) en el lado del pasajero";
            }
            else if (inderxPhotoInspektion == 24)
            {
                nameLayout = "Espejo retrovisor del coche(SUV) en el lado del pasajero";
            }
            else if (inderxPhotoInspektion == 25)
            {
                nameLayout = "Puerta trasera del coche(SUV) desde el lado del pasajero";
            }
            else if (inderxPhotoInspektion == 26)
            {
                nameLayout = "Parte trasera del coche(SUV) desde el lado del pasajero";
            }
            else if (inderxPhotoInspektion == 27)
            {
                nameLayout = "Rueda trasera de un coche(SUV) desde el lado del pasajero";
            }
            else if (inderxPhotoInspektion == 28)
            {
                nameLayout = "Toda la parte del coche(SUV) en el lado del pasajero";
            }
            else if (inderxPhotoInspektion == 29)
            {
                nameLayout = "Lado derecho del parachoques trasero del coche(SUV)";
            }
            else if (inderxPhotoInspektion == 30)
            {
                nameLayout = "El lado central del parachoques trasero del automóvil(SUV)";
            }
            else if (inderxPhotoInspektion == 31)
            {
                nameLayout = "Ventana trasera del coche(SUV)";
            }
            else if (inderxPhotoInspektion == 32)
            {
                nameLayout = "Lado izquierdo del parachoques trasero del coche(SUV)";
            }
            else if (inderxPhotoInspektion == 33)
            {
                nameLayout = "Parte trasera del coche(SUV) desde el lado del conductor";
            }
            else if (inderxPhotoInspektion == 34)
            {
                nameLayout = "Rueda trasera de un coche(SUV) desde el lado del conductor";
            }
            else if (inderxPhotoInspektion == 35)
            {
                nameLayout = "Puerta trasera del coche(SUV) desde el lado del conductor";
            }
            else if (inderxPhotoInspektion == 36)
            {
                nameLayout = "Toda la parte del coche(SUV) en el lado del conductor";
            }
            else if (inderxPhotoInspektion == 37)
            {
                nameLayout = "Correa de sujeción trasera del coche en el lado del conductor";
            }
            else if (inderxPhotoInspektion == 38)
            {
                nameLayout = "Correa de sujeción delantera del coche en el lado del conductor.";
            }
            else if (inderxPhotoInspektion == 39)
            {
                nameLayout = "Coche con cinturón de seguridad delantero en el lado del pasajero";
            }
            else if (inderxPhotoInspektion == 40)
            {
                nameLayout = "Coche con clip para cinturón en la parte trasera del lado del pasajero";
            }
            return nameLayout;
        }

        public async Task OrintableScreen(int inderxPhotoInspektion)
        {
            DependencyService.Get<IOrientationHandler>().ForceLandscape();
            //if (inderxPhotoInspektion == 2 || inderxPhotoInspektion == 3 )
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
    }
}