using System.Collections.Generic;

namespace BaceModel.ModelInspertionDriver.Trailer
{
    public class EnclosedTrailerTwoVehicles : ITransportVehicle
    {
        public int CountPhoto { get; set; } = 13;
        public string Type { get; set; } = "EnclosedTrailerTwoVehicles";
        public bool IsNextInspection { get; set; } = false;
        public List<string> NamePatern { get; set; }
        public string PlateTruck { get; set; }
        public string PlateTraler { get; set; }
        public string TypeTransportVehicle { get; set; } = "Trailer";
        public List<string> Layouts { get; set; }

        public EnclosedTrailerTwoVehicles()
        {
            NamePatern = new List<string>()
            {
                "Front the passenger side corner of the trailer",
                "The whole Front the passenger side of the trailer",
                "The first Front the passenger side wheel of the trailer",
                "The second Front the passenger side wheel of the trailer",
                "Rear corner from the passenger side of the trailer",     
                "Back of trailer",                      
                "Trailer interior",                    
                "Outdoor trailer with ramp",
                "Rear corner from the driver's side of the trailer",
                "The whole the driver's corner side of the trailer",
                "The second the driver's corner side wheel of the trailer",
                "The first the driver's corner side wheel of the trailer",
                "Front the driver's corner side corner of the trailer",    
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
            };
        }
    }
}