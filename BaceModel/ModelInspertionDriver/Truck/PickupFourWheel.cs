using System.Collections.Generic;

namespace BaceModel.ModelInspertionDriver.Truck
{
    public class PickupFourWheel : ITransportVehicle
    {
        public int CountPhoto { get; set; } = 21;
        public string Type { get; set; } = "PickupFourWheel";
        public bool IsNextInspection { get; set; } = true;
        public List<string> NamePatern { get; set; }
        public string PlateTruck { get; set; }
        public string PlateTraler { get; set; }
        public string TypeTransportVehicle { get; set; } = "Truck";
        public List<string> Layouts { get; set; }

        public PickupFourWheel()
        {
            NamePatern = new List<string>()
            {
                "The front of the truck",
                "Truck windshield",
                "Right front headlight of a truck",
                "Truck engine radiator",
                "Left front headlight of a truck",
                "The front of the truck on the passenger side",
                "Front wheel of the truck on the passenger side (Tread)",
                "Truck doors on the passenger side",
                "Rear side of the passenger side",
                "Fuel cap",
                "Rear wheel of the truck on the passenger side",
                "Rear wheel of the truck on the passenger side (Tread)",
                "Right side of the back of the truck",
                "Tool box",
                "Left side of the back of the truck",
                "Rear side of the driver's side",
                "Rear wheel of the truck on the driver's side",
                "Rear wheel of the truck on the driver's side (Tread)",
                "Truck doors on the driver's side",
                "The front of the truck on the driver's side",
                "Front wheel of the truck on the driver's side (Tread)",
            };
            Layouts = new List<string>()
            {
                "1",
                "2",
                "3",
                "4",
                "6",
                "7",
                "8",
                "9",
                "11",
                "12",
                "13",
                "14",
                "15",
                "16",
                "17",
                "19",
                "20",
                "21",
            };
        }
    }
}