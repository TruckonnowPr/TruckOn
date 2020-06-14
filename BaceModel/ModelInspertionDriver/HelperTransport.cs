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
                case "CargoVanMustHaveWithDually": transportVehicle = new CargoVanMustHaveWithDually(); break;
                case "PickUpDuallyChassisOpenFrameInTheBackMustHave2": transportVehicle = new PickUpDuallyChassisOpenFrameInTheBackMustHave2(); break;
                case "PickUpDuallyChassisMustHave2Door": transportVehicle = new PickUpDuallyChassisMustHave2Door(); break;
                case "PickUpDuallyChassisMustHave4Door": transportVehicle = new PickUpDuallyChassisMustHave4Door(); break;
                case "PickUpDuallyFlatbed4Door": transportVehicle = new PickUpDuallyFlatbed4Door(); break;
                case "PickUpDuallyFlatbedMustHave2Door": transportVehicle = new PickUpDuallyFlatbedMustHave2Door(); break;

                case "EnclosedTrailerTwoVehicles": transportVehicle = new EnclosedTrailerTwoVehicles(); break;
                case "GooseneckTrailerTwoVehicles": transportVehicle = new GooseneckTrailerTwoVehicles(); break;
                case "a1CarGooseneckTrailer": transportVehicle = new A1CarGooseneckTrailer(); break;
                case "A3CarEnclosedGooseneckTrailer": transportVehicle = new A3CarEnclosedGooseneckTrailer(); break;
                case "Bumperpook24_34ftFlatbed": transportVehicle = new Bumperpook24_34ftFlatbed(); break;

                case "Deffalt": transportVehicle = new DeffalteTransport(); break;
            }
            return transportVehicle;
        }
    }
}