using BaceModel.ModelInspertionDriver.Trailer;
using BaceModel.ModelInspertionDriver.Truck;
using DaoModels.DAO.Enum;
using DaoModels.DAO.Models.Settings;
using System.Collections.Generic;

namespace BaceModel.ModelInspertionDriver
{
    public class StandartProfileSettings
    {
        private List<ITransportVehicle> TransportVehikles;
        public List<TransportVehicle> TransportVehicles { get; set; }

        public StandartProfileSettings(TypeTransportVehikle typeTransportVehikle)
        {
            if (typeTransportVehikle == TypeTransportVehikle.Truck)
            {
                TransportVehikles = new List<ITransportVehicle>()
                {
                    new PickupFourWheel(),
                    new FourDoorTruckChassisOpenFrame(),
                };
                CreateSetings();
            }
            else if (typeTransportVehikle == TypeTransportVehikle.Trailer)
            {
                TransportVehikles = new List<ITransportVehicle>()
                {
                    new GooseneckTrailerTwoVehicles(),
                    new EnclosedTrailerTwoVehicles(),
                };
                CreateSetings();
            }
        }

        private void CreateSetings()
        {
            int index = 0;
            TransportVehicles = new List<TransportVehicle>();
            foreach(ITransportVehicle transportVehikle in TransportVehikles)
            {
                TransportVehicles.Add(new TransportVehicle()
                {
                    CountPhoto = transportVehikle.CountPhoto,
                    Layouts = new List<Layouts>(),
                    IsNextInspection = true,
                    Type = transportVehikle.Type,
                    TypeTransportVehicle = transportVehikle.TypeTransportVehicle
                });
                for(int i = 0; i < transportVehikle.NamePatern.Count; i++)
                {
                    TransportVehicles[index].Layouts.Add(new Layouts()
                    {
                        Index = transportVehikle.Layouts[i],
                        IsUsed = true,
                        Name = transportVehikle.NamePatern[i],
                        OrdinalIndex = i+1,
                    });
                }
                index++;
            }
        }

        //private ITransportVehicle GetTransportVehicle(string typeTruk)
        //{
        //    ITransportVehicle transportVehicle = null;
        //    switch (typeTruk)
        //    {
        //        case "PickupFourWheel": transportVehicle = new PickupFourWheel(); break;
        //        case "FourDoorTruckChassisOpenFrame": transportVehicle = new FourDoorTruckChassisOpenFrame(); break;

        //        case "GooseneckTrailerTwoVehicles": transportVehicle = new GooseneckTrailerTwoVehicles(); break;
        //        case "EnclosedTrailerTwoVehicles": transportVehicle = new EnclosedTrailerTwoVehicles(); break;
        //    }
        //    return transportVehicle;
        //}
    }
}