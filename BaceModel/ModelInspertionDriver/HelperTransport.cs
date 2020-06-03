using BaceModel.ModelInspertionDriver.Trailer;
using BaceModel.ModelInspertionDriver.Truck;

namespace BaceModel.ModelInspertionDriver
{
    public class HelperTransport
    {
        public static ITransportVehicle GetTransportVehicle(string typeTruk)
        {
            ITransportVehicle transportVehicle = null;
            switch (typeTruk)
            {
                case "PickupFourWheel": transportVehicle = new PickupFourWheel(); break;
                case "FourDoorTruckChassisOpenFrame": transportVehicle = new FourDoorTruckChassisOpenFrame(); break;
                case "BoxTruckSingleWheel": transportVehicle = new BoxTruckSingleWheel(); break;
                case "BoxTruckWheelDually": transportVehicle = new BoxTruckWheelDually(); break;
                case "CargiVanChasissDuallyOrSingleWheel": transportVehicle = new CargiVanChasissDuallyOrSingleWheel(); break;

                case "EnclosedTrailerTwoVehicles": transportVehicle = new EnclosedTrailerTwoVehicles(); break;
                case "GooseneckTrailerTwoVehicles": transportVehicle = new GooseneckTrailerTwoVehicles(); break;

                case "Deffalt": transportVehicle = new DeffalteTransport(); break;
            }
            return transportVehicle;
        }
    }
}