using System.Collections.Generic;

namespace BaceModel.ModelInspertionDriver.Trailer
{
    public class GooseneckTrailerTwoVehicles : ITransportVehicle
    {
        public int CountPhoto { get; set; } = 9;
        public string Type { get; set; } = "GooseneckTrailerTwoVehicles";
        public bool IsNextInspection { get; set; } = false;
        public List<string> NamePatern { get; set; }
        public string PlateTruck { get; set; }
        public string PlateTraler { get; set; }
        public string TypeTransportVehicle { get; set; } = "Trailer";
        public List<string> Layouts { get; set; }

        public GooseneckTrailerTwoVehicles()
        {
            NamePatern = new List<string>()
            {
                "Front the passanger side corner of the trailer",
                "The whole the passanger side of the trailer",
                "The first the passanger side wheel of the trailer",
                "The second the passanger side wheel of the trailer", 
                "Back of trailer",
                "The whole the driver's side of the trailer",
                "The second the driver's side wheel of the trailer",
                "The first the driver's side wheel of the trailer",
                "Front the driver's side corner of the trailer",    
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
            };
        }
    }
}