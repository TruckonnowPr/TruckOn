using System.Collections.Generic;

namespace BaceModel.ModelInspertionDriver.Truck
{
    public class PickUpDually4TiresInTheBackMustHave4Door : ITransportVehicle
    {
        public int CountPhoto { get; set; } = 23;
        public string Type { get; set; } = "PickUpDually4TiresInTheBackMustHave4Door";
        public bool IsNextInspection { get; set; } = true;
        public List<string> NamePatern { get; set; }
        public string PlateTruck { get; set; }
        public string PlateTraler { get; set; }
        public string TypeTransportVehicle { get; set; } = "Truck";
        public List<string> Layouts { get; set; }

        public PickUpDually4TiresInTheBackMustHave4Door()
        {
            NamePatern = new List<string>()
            {
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
            };
            Layouts = new List<string>()
            {
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
            };
        }
    }
}
