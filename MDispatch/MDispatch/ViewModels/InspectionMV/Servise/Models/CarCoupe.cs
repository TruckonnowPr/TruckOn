using MDispatch.Models.Enum;
using MDispatch.NewElement;
using Plugin.Settings;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MDispatch.ViewModels.InspectionMV.Servise.Models
{
    public class CarCoupe : IVehicle
    {
        public string TypeIndex { get; set; } = "Coupe";
        public int CountCarImg { get; set; } = 39;
        public string TypeVehicle { get; set; } = "car";

        public int GetIndexCar(int countPhoto)
        {
            int indecCar = 0;
            switch(countPhoto)
            {
                case 1:
                    {
                        indecCar = 40;
                        break;
                    }
                case 2:
                    {
                        indecCar = 7;
                        break;
                    }
                case 3:
                    {
                        indecCar = 8;
                        break;
                    }
                case 4:
                    {
                        indecCar = 41;
                        break;
                    }
                case 5:
                    {
                        indecCar = 21;
                        break;
                    }
                case 6:
                    {
                        indecCar = 15;
                        break;
                    }
                case 7:
                    {
                        indecCar = 42;
                        break;
                    }
                case 8:
                    {
                        indecCar = 27;
                        break;
                    }
                case 9:
                    {
                        indecCar = 28;
                        break;
                    }
                case 10:
                    {
                        indecCar = 43;
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

        //CrossSettings.Current.GetValueOrDefault("Language" , (int)LanguageType.English)


        public string GetNameLayout(int inderxPhotoInspektion)
        {
            string nameLayout = "";
            if(CrossSettings.Current.GetValueOrDefault("Language", (int)LanguageType.English) == (int)LanguageType.English)
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
                nameLayout = "Vehicle dashboard";
            }
            else if (inderxPhotoInspektion == 2)
            {
                nameLayout = "Driver seat";
            }
            else if (inderxPhotoInspektion == 3)
            {
                nameLayout = "Driver side kit";
            }
            else if (inderxPhotoInspektion == 4)
            {
                nameLayout = "Driver's door";
            }
            else if (inderxPhotoInspektion == 5)
            {
                nameLayout = "Driver side kit";
            }
            else if (inderxPhotoInspektion == 6)
            {
                nameLayout = "Coupe";
            }
            else if (inderxPhotoInspektion == 7)
            {
                nameLayout = "Driver's door";
            }
            else if (inderxPhotoInspektion == 8)
            {
                nameLayout = "Rearview Mirror Driver's Side";
            }
            else if (inderxPhotoInspektion == 9)
            {
                nameLayout = "Rearview Mirror Driver's Sidee";
            }
            else if (inderxPhotoInspektion == 10)
            {
                nameLayout = "Front of the compartment, driver's side";
            }
            else if (inderxPhotoInspektion == 11)
            {
                nameLayout = "Front wheel driver's side";
            }
            else if (inderxPhotoInspektion == 12)
            {
                nameLayout = "Front bumper, driver's side";
            }
            else if (inderxPhotoInspektion == 13)
            {
                nameLayout = "Front headlight, driver's side";
            }
            else if (inderxPhotoInspektion == 14)
            {
                nameLayout = "Front headlight, driver's side";
            }
            else if (inderxPhotoInspektion == 15)
            {
                nameLayout = "Front bumper";
            }
            else if (inderxPhotoInspektion == 16)
            {
                nameLayout = "The entire front of the coupe";
            }
            else if (inderxPhotoInspektion == 17)
            {
                nameLayout = "Right side of the front bumper";
            }
            else if (inderxPhotoInspektion == 18)
            {
                nameLayout = "Central side of the front bumper";
            }
            else if (inderxPhotoInspektion == 19)
            {
                nameLayout = "Left side of the front bumper";
            }
            else if (inderxPhotoInspektion == 20)
            {
                nameLayout = "Сoupe hood";
            }
            else if (inderxPhotoInspektion == 21)
            {
                nameLayout = "Windshield Coupe";
            }
            else if (inderxPhotoInspektion == 22)
            {
                nameLayout = "Front Headlight on the passenger side";
            }
            else if (inderxPhotoInspektion == 23)
            {
                nameLayout = "Front Headlight on the passenger side";
            }
            else if (inderxPhotoInspektion == 24)
            {
                nameLayout = "Front bumper, passenger side";
            }
            else if (inderxPhotoInspektion == 25)
            {
                nameLayout = "Front front wheel passenger side";
            }
            else if (inderxPhotoInspektion == 26)
            {
                nameLayout = "Front of the compartment, passenger side";
            }
            else if (inderxPhotoInspektion == 27)
            {
                nameLayout = "Passenger door";
            }
            else if (inderxPhotoInspektion == 28)
            {
                nameLayout = "Rearview Mirror Driver's Side";
            }
            else if (inderxPhotoInspektion == 29)
            {
                nameLayout = "Right rear view mirror (Front part)";
            }
            else if (inderxPhotoInspektion == 30)
            {
                nameLayout = "Rear of passenger compartment";
            }
            else if (inderxPhotoInspektion == 31)
            {
                nameLayout = "Rear front wheel passenger side";
            }
            else if (inderxPhotoInspektion == 32)
            {
                nameLayout = "The entire passenger side of the compartment";
            }
            else if (inderxPhotoInspektion == 33)
            {
                nameLayout = "Rear Headlight, driver's side";
            }
            else if (inderxPhotoInspektion == 34)
            {
                nameLayout = "Rear front wheel passenger side";
            }
            else if (inderxPhotoInspektion == 35)
            {
                nameLayout = "The entire rear of the coupe";
            }
            else if (inderxPhotoInspektion == 36)
            {
                nameLayout = "Rear Headlight, passenger side";
            }
            else if (inderxPhotoInspektion == 37)
            {
                nameLayout = "Rear window coupe";
            }
            else if (inderxPhotoInspektion == 38)
            {
                nameLayout = "Rear of passenger compartment";
            }
            else if (inderxPhotoInspektion == 39)
            {
                nameLayout = "The whole driver’s side of the coupe";
            }
            else if (inderxPhotoInspektion == 40)
            {
                nameLayout = "Rear belt mount vehicle on the driver's side";
            }
            else if (inderxPhotoInspektion == 41)
            {
                nameLayout = "Front belt mount vehicle on the driver's side";
            }
            else if (inderxPhotoInspektion == 42)
            {
                nameLayout = "Front belt mount vehicle on the passenger side";
            }
            else if (inderxPhotoInspektion == 43)
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
                nameLayout = "Приборная панель автомобиля";
            }
            else if (inderxPhotoInspektion == 2)
            {
                nameLayout = "Сиденье водителя";
            }
            else if (inderxPhotoInspektion == 3)
            {
                nameLayout = "Комплект со стороны водителя";
            }
            else if (inderxPhotoInspektion == 4)
            {
                nameLayout = "Водительская дверь";
            }
            else if (inderxPhotoInspektion == 5)
            {
                nameLayout = "Комплект со стороны водителя";
            }
            else if (inderxPhotoInspektion == 6)
            {
                nameLayout = "Купе";
            }
            else if (inderxPhotoInspektion == 7)
            {
                nameLayout = "Водительская дверь";
            }
            else if (inderxPhotoInspektion == 8)
            {
                nameLayout = "Зеркало заднего вида со стороны водителя";
            }
            else if (inderxPhotoInspektion == 9)
            {
                nameLayout = "Зеркало заднего вида со стороны водителя";
            }
            else if (inderxPhotoInspektion == 10)
            {
                nameLayout = "Передняя часть отсека, сторона водителя";
            }
            else if (inderxPhotoInspektion == 11)
            {
                nameLayout = "Переднее колесо со стороны водителя";
            }
            else if (inderxPhotoInspektion == 12)
            {
                nameLayout = "Передний бампер со стороны водителя";
            }
            else if (inderxPhotoInspektion == 13)
            {
                nameLayout = "Передняя фара со стороны водителя";
            }
            else if (inderxPhotoInspektion == 14)
            {
                nameLayout = "Передняя фара со стороны водителя";
            }
            else if (inderxPhotoInspektion == 15)
            {
                nameLayout = "Передний бампер";
            }
            else if (inderxPhotoInspektion == 16)
            {
                nameLayout = "Вся передняя часть купе";
            }
            else if (inderxPhotoInspektion == 17)
            {
                nameLayout = "Правая сторона переднего бампера";
            }
            else if (inderxPhotoInspektion == 18)
            {
                nameLayout = "Центральная сторона переднего бампера";
            }
            else if (inderxPhotoInspektion == 19)
            {
                nameLayout = "Левая сторона переднего бампера";
            }
            else if (inderxPhotoInspektion == 20)
            {
                nameLayout = "Вытяжка купе";
            }
            else if (inderxPhotoInspektion == 21)
            {
                nameLayout = "Лобовое стекло купе";
            }
            else if (inderxPhotoInspektion == 22)
            {
                nameLayout = "Передняя фара на стороне пассажира";
            }
            else if (inderxPhotoInspektion == 23)
            {
                nameLayout = "Передняя фара на стороне пассажира";
            }
            else if (inderxPhotoInspektion == 24)
            {
                nameLayout = "Передний бампер со стороны пассажира";
            }
            else if (inderxPhotoInspektion == 25)
            {
                nameLayout = "Переднее переднее колесо со стороны пассажира";
            }
            else if (inderxPhotoInspektion == 26)
            {
                nameLayout = "Передняя часть купе со стороны пассажира";
            }
            else if (inderxPhotoInspektion == 27)
            {
                nameLayout = "Пассажирская дверь";
            }
            else if (inderxPhotoInspektion == 28)
            {
                nameLayout = "Зеркало заднего вида со стороны водителя";
            }
            else if (inderxPhotoInspektion == 29)
            {
                nameLayout = "Зеркало заднего вида правое (передняя часть)";
            }
            else if (inderxPhotoInspektion == 30)
            {
                nameLayout = "Задняя часть салона";
            }
            else if (inderxPhotoInspektion == 31)
            {
                nameLayout = "Заднее переднее колесо со стороны пассажира";
            }
            else if (inderxPhotoInspektion == 32)
            {
                nameLayout = "Вся пассажирская часть купе";
            }
            else if (inderxPhotoInspektion == 33)
            {
                nameLayout = "Фара задняя со стороны водителя";
            }
            else if (inderxPhotoInspektion == 34)
            {
                nameLayout = "Заднее переднее колесо со стороны пассажира";
            }
            else if (inderxPhotoInspektion == 35)
            {
                nameLayout = "Вся задняя часть купе";
            }
            else if (inderxPhotoInspektion == 36)
            {
                nameLayout = "Задний фонарь на стороне пассажира";
            }
            else if (inderxPhotoInspektion == 37)
            {
                nameLayout = "Заднее стекло купе";
            }
            else if (inderxPhotoInspektion == 38)
            {
                nameLayout = "Задняя часть салона";
            }
            else if (inderxPhotoInspektion == 39)
            {
                nameLayout = "Вся водительская сторона купе";
            }
            else if (inderxPhotoInspektion == 40)
            {
                nameLayout = "Задний ремень крепления автомобиля на стороне водителя";
            }
            else if (inderxPhotoInspektion == 41)
            {
                nameLayout = "Передний ремень крепления автомобиля на стороне водителя";
            }
            else if (inderxPhotoInspektion == 42)
            {
                nameLayout = "Автомобиль с передним ремнем безопасности на стороне пассажира";
            }
            else if (inderxPhotoInspektion == 43)
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
                nameLayout = "Salpicadero del coche";
            }
            else if (inderxPhotoInspektion == 2)
            {
                nameLayout = "Asiento del conductor";
            }
            else if (inderxPhotoInspektion == 3)
            {
                nameLayout = "Kit del lado del conductor";
            }
            else if (inderxPhotoInspektion == 4)
            {
                nameLayout = "Puerta del conductor";
            }
            else if (inderxPhotoInspektion == 5)
            {
                nameLayout = "Kit del lado del conductor";
            }
            else if (inderxPhotoInspektion == 6)
            {
                nameLayout = "Cupé";
            }
            else if (inderxPhotoInspektion == 7)
            {
                nameLayout = "Puerta del conductor";
            }
            else if (inderxPhotoInspektion == 8)
            {
                nameLayout = "Espejo retrovisor, lado del conductor";
            }
            else if (inderxPhotoInspektion == 9)
            {
                nameLayout = "Espejo retrovisor, lado del conductor";
            }
            else if (inderxPhotoInspektion == 10)
            {
                nameLayout = "Compartimento delantero, lado del conductor";
            }
            else if (inderxPhotoInspektion == 11)
            {
                nameLayout = "Del lado del conductor de la rueda delantera";
            }
            else if (inderxPhotoInspektion == 12)
            {
                nameLayout = "Parachoques delantero, lado del conductor";
            }
            else if (inderxPhotoInspektion == 13)
            {
                nameLayout = "Faro delantero, lado del conductor";
            }
            else if (inderxPhotoInspektion == 14)
            {
                nameLayout = "Faro delantero, lado del conductor";
            }
            else if (inderxPhotoInspektion == 15)
            {
                nameLayout = "Parachoques delantero";
            }
            else if (inderxPhotoInspektion == 16)
            {
                nameLayout = "Todo el frente del cupé";
            }
            else if (inderxPhotoInspektion == 17)
            {
                nameLayout = "Parachoques delantero lado derecho";
            }
            else if (inderxPhotoInspektion == 18)
            {
                nameLayout = "Lado central del parachoques delantero";
            }
            else if (inderxPhotoInspektion == 19)
            {
                nameLayout = "Lado izquierdo del parachoques delantero";
            }
            else if (inderxPhotoInspektion == 20)
            {
                nameLayout = "Capó de cupé";
            }
            else if (inderxPhotoInspektion == 21)
            {
                nameLayout = "Parabrisas cupé";
            }
            else if (inderxPhotoInspektion == 22)
            {
                nameLayout = "Faro delantero, lado del pasajero";
            }
            else if (inderxPhotoInspektion == 23)
            {
                nameLayout = "Faro delantero, lado del pasajero";
            }
            else if (inderxPhotoInspektion == 24)
            {
                nameLayout = "Parachoques delantero, lado del pasajero";
            }
            else if (inderxPhotoInspektion == 25)
            {
                nameLayout = "Lado del pasajero de la rueda delantera delantera";
            }
            else if (inderxPhotoInspektion == 26)
            {
                nameLayout = "Coupe delantero, lado del pasajero";
            }
            else if (inderxPhotoInspektion == 27)
            {
                nameLayout = "Puerta del pasajero";
            }
            else if (inderxPhotoInspektion == 28)
            {
                nameLayout = "Espejo retrovisor, lado del conductor";
            }
            else if (inderxPhotoInspektion == 29)
            {
                nameLayout = "Espejo retrovisor, lado del conductor";
            }
            else if (inderxPhotoInspektion == 30)
            {
                nameLayout = "Detrás de la cabaña";
            }
            else if (inderxPhotoInspektion == 31)
            {
                nameLayout = "Lado del pasajero de la rueda delantera trasera";
            }
            else if (inderxPhotoInspektion == 32)
            {
                nameLayout = "Todo el habitáculo del habitáculo";
            }
            else if (inderxPhotoInspektion == 33)
            {
                nameLayout = "Faro trasero en el lado del conductor";
            }
            else if (inderxPhotoInspektion == 34)
            {
                nameLayout = "Lado del pasajero de la rueda delantera trasera";
            }
            else if (inderxPhotoInspektion == 35)
            {
                nameLayout = "Toda la parte trasera del cupé";
            }
            else if (inderxPhotoInspektion == 36)
            {
                nameLayout = "Luz trasera, lado del pasajero";
            }
            else if (inderxPhotoInspektion == 37)
            {
                nameLayout = "Vidrio trasero cupé";
            }
            else if (inderxPhotoInspektion == 38)
            {
                nameLayout = "Detrás de la cabaña";
            }
            else if (inderxPhotoInspektion == 39)
            {
                nameLayout = "Todo el lado del conductor del cupé.";
            }
            else if (inderxPhotoInspektion == 40)
            {
                nameLayout = "Cinturón de seguridad trasero para automóvil, lado del conductor";
            }
            else if (inderxPhotoInspektion == 41)
            {
                nameLayout = "Correa de sujeción delantera del coche en el lado del conductor.";
            }
            else if (inderxPhotoInspektion == 42)
            {
                nameLayout = "Coche con cinturón de seguridad delantero en el lado del pasajero";
            }
            else if (inderxPhotoInspektion == 43)
            {
                nameLayout = "Vehículo con clip para cinturón en la parte trasera del lado del pasajero";
            }
            return nameLayout;
        }

        public async Task OrintableScreen(int inderxPhotoInspektion)
        {
            DependencyService.Get<IOrientationHandler>().ForceLandscape();
            //if (inderxPhotoInspektion == 12 || inderxPhotoInspektion == 13 || inderxPhotoInspektion == 14 || inderxPhotoInspektion == 15)
            //{
            //    DependencyService.Get<IOrientationHandler>().ForceSensor();
            //}
            //else if (inderxPhotoInspektion == 1 || inderxPhotoInspektion == 4 || inderxPhotoInspektion == 8 || inderxPhotoInspektion == 19 || inderxPhotoInspektion == 21
            //    || inderxPhotoInspektion == 22 || inderxPhotoInspektion == 28 || inderxPhotoInspektion == 29 || inderxPhotoInspektion == 29 || inderxPhotoInspektion == 30
            //     || inderxPhotoInspektion == 31 || inderxPhotoInspektion == 32 || inderxPhotoInspektion == 33 || inderxPhotoInspektion == 34 || inderxPhotoInspektion == 35
            //      || inderxPhotoInspektion == 37 || inderxPhotoInspektion == 39)
            //{
            //    DependencyService.Get<IOrientationHandler>().ForcePortrait();
            //}
            //else if (inderxPhotoInspektion == 2 || inderxPhotoInspektion == 3 || inderxPhotoInspektion == 5 || inderxPhotoInspektion == 6 || inderxPhotoInspektion == 7 || inderxPhotoInspektion == 9
            //     || inderxPhotoInspektion == 10 || inderxPhotoInspektion == 11 || inderxPhotoInspektion == 16 || inderxPhotoInspektion == 17 || inderxPhotoInspektion == 18 || inderxPhotoInspektion == 20
            //      || inderxPhotoInspektion == 23 || inderxPhotoInspektion == 24 || inderxPhotoInspektion == 25 || inderxPhotoInspektion == 26 || inderxPhotoInspektion == 27 || inderxPhotoInspektion == 36
            //       || inderxPhotoInspektion == 38)
            //{
            //    DependencyService.Get<IOrientationHandler>().ForceLandscape();
            //}
        }
    }
}