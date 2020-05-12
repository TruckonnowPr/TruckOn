using System.Collections.Generic;

namespace BaceModel.ModelInspertionDriver.Truck
{
    public class FourDoorTruckChassisOpenFrame : ITransportVehicle
    {
        public int CountPhoto { get; set; } = 19;
        public string Type { get; set; } = "FourDoorTruckChassisOpenFrame";
        public bool IsNextInspection { get; set; } = true;
        public List<string> NamePatern { get; set; }
        public string PlateTruck { get; set; }
        public string PlateTraler { get; set; }
        public string TypeTransportVehicle { get; set; } = "Truck";
        public List<string> Layouts { get; set; }

        public FourDoorTruckChassisOpenFrame()
        {
            NamePatern = new List<string>()
            {
                "Truck windshield",
                "Right front headlight of a truck",
                "Truck engine radiator",
                "Left front headlight of a truck",
                "The front of the truck on the passenger side",
                "Front wheel of the truck on the passenger side",
                "Front wheel of the truck on the passenger side (Tread)",
                "Front door of the truck on the passenger side",
                "Rear door of the truck on the passenger side",
                "Rear wheel of the truck on the passenger side",
                "Rear wheel of the truck on the passenger side (Tread)",
                "The whole back of the truck",
                "Rear wheel of the truck on the driver's side",
                "Rear wheel of the truck on the driver's side (Tread)",
                "Rear door of the truck on the driver's side",
                "Front door of the truck on the driver's side",
                "The front of the truck on the driver's side",
                "Front wheel of the truck on the driver's side (Tread)",
                "Front wheel of the truck on the driver's side",
            };
            Layouts = new List<string>()
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15",
                "16",
                "17",
                "18",
                "19",
            };
        }
    }
}